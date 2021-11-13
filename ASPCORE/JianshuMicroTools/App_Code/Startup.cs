using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JianshuMicroTools.Startup))]
namespace JianshuMicroTools
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
