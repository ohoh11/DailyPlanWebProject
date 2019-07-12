using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DailyPlanWebApp.Startup))]
namespace DailyPlanWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
