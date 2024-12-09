using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TrustDesgin_Domain.Entites;

public class User:IdentityUser
{
    [Key]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string UserPictuer { get; set; }
}