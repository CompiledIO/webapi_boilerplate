using System.Threading.Tasks;
using Api.Core.Dto.Requests.User;
using Api.Core.Interfaces.Services;
using Api.Presenters;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        private readonly RegisterPresenter _registerUserPresenter;

        public RegisterController(IRegisterService registerService, RegisterPresenter registerUserPresenter)
        {
            _registerService = registerService;
            _registerUserPresenter = registerUserPresenter;
        }

        // POST api/accounts
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Models.Requests.RegisterRequest request)
        {
            if (!ModelState.IsValid)
            { // re-render the view when validation failed.
                return BadRequest(ModelState);
            }
            await _registerService.Handle(new RegisterRequest(request.FirstName, request.LastName, request.Email, request.UserName, request.Password), _registerUserPresenter);
            return _registerUserPresenter.ContentResult;
        }
    }
}
