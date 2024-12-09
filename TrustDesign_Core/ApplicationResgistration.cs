using Microsoft.Extensions.DependencyInjection;
using TrustDesign_Core.Interfaces.Services;
using TrustDesign_Core.Services;

namespace TrustDesign_Core
{
    public static class ApplicationResgistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserService>();
        }
    }
}
