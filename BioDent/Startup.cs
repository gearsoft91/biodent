using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BioDent.Startup))]
namespace BioDent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
