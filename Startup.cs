using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RyanEFExample.Startup))]
namespace RyanEFExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
