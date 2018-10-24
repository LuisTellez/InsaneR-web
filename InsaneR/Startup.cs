using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InsaneR.Startup))]
namespace InsaneR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
