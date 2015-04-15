using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Northwind.Startup))]
namespace MVC_Northwind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
