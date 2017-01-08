using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HybridClient.Startup))]
namespace HybridClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
