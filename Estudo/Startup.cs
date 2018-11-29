using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Estudo.Startup))]
namespace Estudo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
