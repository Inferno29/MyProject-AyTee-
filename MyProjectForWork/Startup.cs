using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProjectForWork.Startup))]
namespace MyProjectForWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
