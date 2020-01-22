using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pc533016MIS4200.Startup))]
namespace pc533016MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
