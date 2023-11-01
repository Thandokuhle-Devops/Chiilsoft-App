using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chillisoft.Startup))]
namespace Chillisoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
