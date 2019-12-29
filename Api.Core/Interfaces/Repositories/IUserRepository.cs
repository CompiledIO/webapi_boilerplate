using Api.Core.Domain.Entities;
using Api.Core.Dto.Repositories;
using System.Threading.Tasks;

namespace Api.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<CreateUserResponse> Create(AppUser user, string password);
        Task<AppUser> FindByName(string userName);
        Task<bool> CheckPassword(AppUser user, string password);
    }
}
