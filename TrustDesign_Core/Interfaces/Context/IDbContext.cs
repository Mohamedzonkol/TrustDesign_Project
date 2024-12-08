using Microsoft.EntityFrameworkCore;
using TrustDesgin_Domain.Entites;

namespace TrustDesign_Core.Interfaces.Context;

public interface IDbContext
{
    DbSet<User> Users { get; }

}