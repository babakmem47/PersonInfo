using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonInfo.Startup))]
namespace PersonInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
