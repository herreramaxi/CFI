using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CFI.Startup))]
namespace CFI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
