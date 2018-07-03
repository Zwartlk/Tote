using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tote.Startup))]
namespace Tote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
