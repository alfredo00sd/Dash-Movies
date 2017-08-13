using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dash_Movies.Startup))]
namespace Dash_Movies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
