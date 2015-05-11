using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChocolateWeb.Startup))]
namespace ChocolateWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
