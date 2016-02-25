using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xamillionaire.Web.Startup))]
namespace Xamillionaire.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
