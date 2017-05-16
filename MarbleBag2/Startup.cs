using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarbleBag2.Startup))]
namespace MarbleBag2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
