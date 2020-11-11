using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFoodPortal.Startup))]
namespace MVCFoodPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
