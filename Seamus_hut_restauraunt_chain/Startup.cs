using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seamus_hut_restauraunt_chain.Startup))]
namespace Seamus_hut_restauraunt_chain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
