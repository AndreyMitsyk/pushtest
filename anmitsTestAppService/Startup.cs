using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(anmitsTestAppService.Startup))]

namespace anmitsTestAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}