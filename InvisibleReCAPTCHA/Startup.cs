using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvisibleReCAPTCHA.Startup))]
namespace InvisibleReCAPTCHA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
