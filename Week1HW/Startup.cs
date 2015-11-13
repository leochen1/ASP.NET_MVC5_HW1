using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week1HW.Startup))]
namespace Week1HW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
