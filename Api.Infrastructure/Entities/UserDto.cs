using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Infrastructure.Entities
{
    public class UserDto : BaseDto
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }
    }
}
