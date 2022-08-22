using Microsoft.AspNetCore.Identity;

namespace ISMTS2WebApp.Models
{
    public class AppUser: IdentityUser
    {
        public bool IsAdmin { get; set; }
        public string CustomData { get; set; }
    }
}
