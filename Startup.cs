using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GRP26Project.Startup))]
namespace GRP26Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
