using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(maDMPTranslator.Startup))]
namespace maDMPTranslator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
