using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASGay_Portfolio.Startup))]
namespace ASGay_Portfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
