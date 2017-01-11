using System;
using System.Security.Cryptography.X509Certificates;
using IdentityServer3.Core.Configuration;
using Owin;
using Project_2._1.IdentityServer;

namespace Project_2._1
{
    public sealed class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map(
                "/core",
                coreApp => {
                    coreApp.UseIdentityServer(new IdentityServerOptions
                    {
                        SiteName = "Standalone Identity Server",
                        SigningCertificate = LoadCertificate(),
                        Factory = new IdentityServerServiceFactory()
                                .UseInMemoryClients(Clients.Get())
                                .UseInMemoryScopes(Scopes.Get())
                                .UseInMemoryUsers(Users.Get()),
                        RequireSsl = true
                    });
                });
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                string.Format(@"{0}\bin\cert.pfx", AppDomain.CurrentDomain.BaseDirectory), "qwertz");
        }
    }
}