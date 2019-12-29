using Api.Core.Dto.Requests.User;
using Api.Core.Dto.Responses.User;

namespace Api.Core.Interfaces.Services
{
    public interface IRegisterService : IRequestHandler<RegisterRequest, RegisterResponse>
    {
    }
}
