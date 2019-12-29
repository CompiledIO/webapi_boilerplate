using Api.Core.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core.Dto.Repositories
{
    public class CreateUserResponse : BaseResponse
    {
        public string Id { get; set; }

        public CreateUserResponse(string id, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
        {
            Id = id;
        }
    }
}
