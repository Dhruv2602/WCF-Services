using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItPollutionIndex.Startup))]
namespace TryItPollutionIndex
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
