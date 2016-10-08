using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contentful.Web.Startup))]
namespace Contentful.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
