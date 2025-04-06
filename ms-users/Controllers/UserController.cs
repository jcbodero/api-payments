using Microsoft.AspNetCore.Mvc;
using ms_users.Services;

namespace ms_users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetUserProfile(int id)
        {
            var profile = _userService.GetUserProfile(id);
            return Ok(profile);
        }
    }
}
