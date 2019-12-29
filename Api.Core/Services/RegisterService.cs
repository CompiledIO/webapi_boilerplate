using Api.Core.Domain.Entities;
using Api.Core.Dto.Requests.User;
using Api.Core.Dto.Responses.User;
using Api.Core.Interfaces;
using Api.Core.Interfaces.Repositories;
using Api.Core.Interfaces.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Core.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly IUserRepository _userRepository;

        public RegisterService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(RegisterRequest message, IOutputPort<RegisterResponse> outputPort)
        {
            var response = await _userRepository.Create(new AppUser(message.FirstName, message.LastName, message.Email, message.UserName), message.Password);
            outputPort.Handle(response.Success ? new RegisterResponse(response.Id, true) : new RegisterResponse(response.Errors.Select(e => e.Description)));
            return response.Success;
        }
    }
}
