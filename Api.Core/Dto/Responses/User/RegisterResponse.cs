using Api.Core.Interfaces;
using System.Collections.Generic;
namespace Api.Core.Dto.Responses.User
{
    public class RegisterResponse : ServiceResponseMessage
    {
        public string Id { get; }
        public IEnumerable<string> Errors { get; }

        public RegisterResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public RegisterResponse(string id, bool success = false, string message = null) : base(success, message)
        {
            Id = id;
        }
    }
}
