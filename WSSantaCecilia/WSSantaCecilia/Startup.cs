using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSSantaCecilia.Startup))]
namespace WSSantaCecilia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
