using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdetoFood.Startup))]
namespace OdetoFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
