using TrustDesign_Core.Interfaces.Reporesitories;
using TrustDesign_Core.Interfaces.Services;

namespace TrustDesign_Core.Services
{
    public class UserService(IUserReporostory userReporostory) : IUserServices
    {
    }
}
