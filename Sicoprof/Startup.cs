using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sicoprof.Startup))]
namespace Sicoprof
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
