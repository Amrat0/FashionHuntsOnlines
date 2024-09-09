using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FashionHuntsOnlines.Startup))]
namespace FashionHuntsOnlines
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
