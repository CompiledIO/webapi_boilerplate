
using Api.Core.Dto;
using System.Threading.Tasks;

namespace Api.Core.Interfaces.Services
{
    public interface IJwtFactory
    {
        Task<Token> GenerateEncodedToken(string id, string userName);
    }
}
