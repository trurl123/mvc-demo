using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTasks2.Startup))]
namespace MyTasks2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
