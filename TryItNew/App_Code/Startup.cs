using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItNew.Startup))]
namespace TryItNew
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
