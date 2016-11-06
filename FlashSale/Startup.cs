using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlashSale.Startup))]
namespace FlashSale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
