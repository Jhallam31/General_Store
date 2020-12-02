using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(General_Store.Startup))]
namespace General_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
