using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POU.Startup))]
namespace POU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
