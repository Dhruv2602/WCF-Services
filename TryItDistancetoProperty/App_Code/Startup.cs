using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItDistancetoProperty.Startup))]
namespace TryItDistancetoProperty
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
