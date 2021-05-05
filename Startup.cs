using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MRent.Startup))]
namespace MRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
