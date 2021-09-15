using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SA_PRG522_6680.Startup))]
namespace SA_PRG522_6680
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
