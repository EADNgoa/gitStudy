using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gitstudy.Startup))]
namespace Gitstudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
