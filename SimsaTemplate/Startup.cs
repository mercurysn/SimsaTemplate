using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimsaTemplate.Startup))]
namespace SimsaTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
