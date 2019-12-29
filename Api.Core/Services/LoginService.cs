using Api.Core.Dto;
using Api.Core.Dto.Requests.User;
using Api.Core.Dto.Responses.User;
using Api.Core.Interfaces;
using Api.Core.Interfaces.Repositories;
using Api.Core.Interfaces.Services;
using System.Threading.Tasks;

namespace Api.Core.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtFactory _jwtFactory;

        public LoginService(IUserRepository userRepository, IJwtFactory jwtFactory)
        {
            _userRepository = userRepository;
            _jwtFactory = jwtFactory;
        }

        public async Task<bool> Handle(LoginRequest message, IOutputPort<LoginResponse> outputPort)
        {
            if (!string.IsNullOrEmpty(message.UserName) && !string.IsNullOrEmpty(message.Password))
            {
                // confirm we have a user with the given name
                var user = await _userRepository.FindByName(message.UserName);
                if (user != null)
                {
                    // validate password
                    if (await _userRepository.CheckPassword(user, message.Password))
                    {
                        // generate token
                        outputPort.Handle(new LoginResponse(await _jwtFactory.GenerateEncodedToken(user.Id, user.UserName), true));
                        return true;
                    }
                }
            }
            outputPort.Handle(new LoginResponse(new[] { new Error(GlobalVariables.error_loginFailure, "Invalid username or password.") }));
            return false;
        }
    }
}
