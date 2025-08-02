using System.Runtime.CompilerServices;

namespace MyWebSite.WebApi.Controllers
{
    public static class SecurityController
    {
        public static void SecurityRoute(this WebApplication app)
        {
            var loginGroup = app.MapGroup("Security");
            loginGroup.MapGet("SignIn", () => {
            
            });
        }
    }
}
