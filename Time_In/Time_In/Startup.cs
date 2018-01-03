using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Time_In.Startup))]
namespace Time_In
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
