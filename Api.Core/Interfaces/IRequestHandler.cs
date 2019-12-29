using System.Threading.Tasks;

namespace Api.Core.Interfaces
{
    public interface IRequestHandler<in TRequest, out TResponse> where TRequest : IRequest<TResponse>
    {
        Task<bool> Handle(TRequest message, IOutputPort<TResponse> outputPort);
    }
}
