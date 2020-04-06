using Microsoft.Owin;
using Owin;
using TimeCard.Controllers;

[assembly: OwinStartupAttribute(typeof(TimeCard.Startup))]
namespace TimeCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.CreatePerOwinContext<ApplicationRoleManager>(Application‌​RoleManager.Create);

            ConfigureAuth(app);
        }
    }
}
