using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitProjectOne.Startup))]
namespace GitProjectOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
