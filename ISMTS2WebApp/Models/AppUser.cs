using Microsoft.AspNetCore.Identity;
using System;

namespace ISMTS2WebApp.Models
{
    public class AppUser: IdentityUser
    {
        public bool IsAdmin { get; set; }
        public string CustomData { get; set; }
    }

    public class UserLoggedInDetails
    {
        public DateTime LoggedIn { get; set; }
        public DateTime LoggedOut { get; set; }
        public int UserId { get; set; }
    }
}

