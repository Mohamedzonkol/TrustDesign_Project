using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrustDesgin_Domain.Entites;
using TrustDesign_Core.Interfaces;

namespace TrustDesgin_Persistence.DbContext;

public class AppDbContext : IdentityDbContext<User>,IDbContext
{

    public AppDbContext(DbContextOptions options):base(options)
    {
        
    }
}