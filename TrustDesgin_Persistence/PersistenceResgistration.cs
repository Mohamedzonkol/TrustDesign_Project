using Microsoft.Extensions.DependencyInjection;
using TrustDesgin_Persistence.Reporsitoriers;
using TrustDesign_Core.Interfaces.Reporesitories;

namespace TrustDesgin_Persistence
{
    public static class PersistenceResgistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IUserReporostory, UserReporostory>();
        }
    }
}
