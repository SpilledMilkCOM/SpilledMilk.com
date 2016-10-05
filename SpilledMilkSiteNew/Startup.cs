using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpilledMilkSiteNew.Startup))]
namespace SpilledMilkSiteNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}