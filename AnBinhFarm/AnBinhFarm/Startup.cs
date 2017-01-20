using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnBinhFarm.Startup))]
namespace AnBinhFarm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
