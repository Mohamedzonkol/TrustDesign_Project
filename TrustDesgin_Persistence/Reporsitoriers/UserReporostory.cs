using TrustDesgin_Domain.Entites;
using TrustDesgin_Persistence.DbContext;
using TrustDesign_Core.Interfaces.Reporesitories;

namespace TrustDesgin_Persistence.Reporsitoriers
{
    public class UserReporostory : Reporsitory<User>, IUserReporostory
    {
        public UserReporostory(ApplicationDbContext context) : base(context)
        {
        }
    }
}
