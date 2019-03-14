using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oatest1.Startup))]
namespace oatest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
