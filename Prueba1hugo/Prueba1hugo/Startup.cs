using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba1hugo.Startup))]
namespace Prueba1hugo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
