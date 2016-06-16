using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartHealth.Web.Startup))]
namespace SmartHealth.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
