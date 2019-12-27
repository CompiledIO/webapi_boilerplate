using Microsoft.AspNetCore.Identity;
using System;

namespace Api.Infrastructure.Data.Entities
{
    public class UserDto : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
