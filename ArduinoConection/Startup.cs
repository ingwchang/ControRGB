using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArduinoConection.Startup))]
namespace ArduinoConection
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
