namespace Api.Core.Domain.Entities
{
    public class AppUser
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public AppUser(string firstName, string lastName, string email, string userName, string id = null, string passwordHash = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            PasswordHash = passwordHash;
        }
    }
}
