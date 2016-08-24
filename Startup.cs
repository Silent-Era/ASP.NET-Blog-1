using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPBlog.Startup))]
namespace ASPBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
