using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrivacyApplication.Startup))]
namespace PrivacyApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
