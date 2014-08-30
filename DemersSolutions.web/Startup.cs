using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1Quick1.Web.Startup))]
namespace _1Quick1.Web {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
