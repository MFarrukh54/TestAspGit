using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitAppTest.Startup))]
namespace gitAppTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
