using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMSDemo1.Startup))]
namespace DMSDemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
