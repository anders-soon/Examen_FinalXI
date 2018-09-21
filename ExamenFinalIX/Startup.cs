using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenFinalIX.Startup))]
namespace ExamenFinalIX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
