using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1_ASP.NET_Web_Forms.Startup))]
namespace _1_ASP.NET_Web_Forms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
