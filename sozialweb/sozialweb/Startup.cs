using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sozialweb.Startup))]
namespace sozialweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
