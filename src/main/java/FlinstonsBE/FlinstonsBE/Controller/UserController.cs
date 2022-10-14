using Microsoft.AspNetCore.Mvc;

namespace FlinstonsBE.HyperMedia.Controller
{
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(); 
      
    }
}
