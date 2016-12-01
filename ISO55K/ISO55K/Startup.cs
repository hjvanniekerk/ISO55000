using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISO55K.Startup))]
namespace ISO55K
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
