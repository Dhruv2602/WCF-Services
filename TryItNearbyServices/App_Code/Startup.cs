using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItNearbyServices.Startup))]
namespace TryItNearbyServices
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
