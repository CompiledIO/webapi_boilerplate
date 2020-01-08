using Api.Core.Dto.Responses.User;
using Api.Core.Interfaces;
using Api.Serialization;
using System.Net;

namespace Api.Presenters
{
    public sealed class RegisterPresenter : IOutputPort<RegisterResponse>
    {
        public JsonContentResult ContentResult { get; }

        public RegisterPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(RegisterResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            ContentResult.Content = JsonSerializer.SerializeObject(response);
        }
    }
}
