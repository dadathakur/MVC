using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_MVC_app.Startup))]
namespace New_MVC_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
