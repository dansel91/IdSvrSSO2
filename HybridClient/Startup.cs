using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Web.Helpers;
using HybridClient;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace HybridClient
{
    public class Startup
    {
        private const string IdServBaseUri = "https://localhost:44311/core/";
        private const string ClientUri = "http://localhost:5496/";

        public void Configuration(IAppBuilder app)
        {
            //all claims-based identities must return a unique value for that claim typ (Anti-CSRF(Cross site request forgery) protection)
            AntiForgeryConfig.UniqueClaimTypeIdentifier = "sub";
            // get name instead of http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name
            JwtSecurityTokenHandler.InboundClaimTypeMap = new Dictionary<string, string>();

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(
                new OpenIdConnectAuthenticationOptions
                {
                    ClientId = "hybridclient01",
                    Authority = IdServBaseUri,
                    RedirectUri = ClientUri,
                    PostLogoutRedirectUri = ClientUri,
                    ResponseType = "code id_token token",
                    Scope = "openid profile email roles offline_access",
                    TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = "name",
                        RoleClaimType = "role"
                    },
                    SignInAsAuthenticationType = "Cookies"
                });
        }
    }
}
