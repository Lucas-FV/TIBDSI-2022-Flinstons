using FlinstonBE.Application.Users.Handlers.Protocols;
using FlinstonBE.Application.Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flinstons.HyperMedia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ICreateUserHandler _createUserHandler;

        public UserController(ICreateUserHandler createUserHandler)
        {
            _createUserHandler = createUserHandler;
        }
        [HttpGet]
        public IActionResult Get() => Ok();

        [HttpPost]  
        public async Task<IActionResult> Post(UserRequestModel userRequestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);      
            }
            UserResponseModel responseModel = await _createUserHandler.CreateUserAsync(userRequestModel);
            return Created("", responseModel);
        }

    }
}
