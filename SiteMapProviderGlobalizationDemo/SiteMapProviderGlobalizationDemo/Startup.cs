using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteMapProviderGlobalizationDemo.Startup))]
namespace SiteMapProviderGlobalizationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
