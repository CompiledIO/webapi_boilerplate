using Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core.Dto.Responses.User
{
    public class LoginResponse : ServiceResponseMessage
    {
        public Token Token { get; }
        public IEnumerable<Error> Errors { get; }

        public LoginResponse(IEnumerable<Error> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }

        public LoginResponse(Token token, bool success = false, string message = null) : base(success, message)
        {
            Token = token;
        }
    }
}
