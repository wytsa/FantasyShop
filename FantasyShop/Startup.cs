using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FantasyShop.Startup))]
namespace FantasyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
