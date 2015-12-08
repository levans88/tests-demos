using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2_ASP.NET_MVC.Startup))]
namespace _2_ASP.NET_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
