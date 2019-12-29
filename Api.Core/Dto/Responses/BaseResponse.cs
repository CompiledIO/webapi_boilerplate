using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Core.Dto.Responses
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; }
        public IEnumerable<Error> Errors { get; set; }
        protected BaseResponse(bool success = false, IEnumerable<Error> errors = null)
        {
            Success = success;
            Errors = errors;
        }
    }
}
