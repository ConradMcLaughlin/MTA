using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsingSessionState.Startup))]
namespace UsingSessionState
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
