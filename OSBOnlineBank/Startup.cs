using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSBOnlineBank.Startup))]
namespace OSBOnlineBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
