using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItGasPrices.Startup))]
namespace TryItGasPrices
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
