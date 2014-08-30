using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemersSolutions.web.Startup))]
namespace DemersSolutions.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
