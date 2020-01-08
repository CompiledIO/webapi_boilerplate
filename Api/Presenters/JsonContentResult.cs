using Microsoft.AspNetCore.Mvc;

namespace Api.Presenters
{
    public sealed class JsonContentResult : ContentResult
    {
        public JsonContentResult()
        {
            ContentType = "application/json";
        }
    }
}
