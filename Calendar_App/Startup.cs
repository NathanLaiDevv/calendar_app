using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calendar_App.Startup))]
namespace Calendar_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
