using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Libreria_Web.Startup))]
namespace Libreria_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
