using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrustDesgin_Domain.Entites;
using TrustDesign_Core.Interfaces.Context;

namespace TrustDesgin_Persistence.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<User>, IDbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
