using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarvelMovieRental.Startup))]
namespace MarvelMovieRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
