using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebsite.Startup))]
namespace TestWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
