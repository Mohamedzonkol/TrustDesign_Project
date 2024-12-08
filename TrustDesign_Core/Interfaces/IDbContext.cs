using Microsoft.EntityFrameworkCore;
using TrustDesgin_Domain.Entites;

namespace TrustDesign_Core.Interfaces;

public interface IDbContext
{
    DbSet<User> Users { get;}
    
}