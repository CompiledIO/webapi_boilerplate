using Api.Core.Dto.Responses.User;
using Api.Core.Interfaces;

namespace Api.Core.Dto.Requests.User
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string UserName { get; }
        public string Password { get; }
        public LoginRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
