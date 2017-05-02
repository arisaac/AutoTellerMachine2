using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoTellerMachine2.Startup))]
namespace AutoTellerMachine2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
