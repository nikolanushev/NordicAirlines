using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nordic.Startup))]
namespace Nordic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
