using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(acce_master.Startup))]
namespace acce_master
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
