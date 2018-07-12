using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBridgeProject.Startup))]
namespace MVCBridgeProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
