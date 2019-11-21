using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BabyShop.Startup))]
namespace BabyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
