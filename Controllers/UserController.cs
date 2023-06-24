using ECommerce.Data.UserModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {

            var user = new ApplicationUser
            {
                UserName = registerModel.FirstName,
            };


            var result = await _userManager.CreateAsync(user, registerModel.Password);



            return Ok(result);



        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {

            var userExists = await _userManager.FindByNameAsync(loginModel.UserName);

            if (userExists == null)
            {
                return BadRequest();
            }

            var checkPassword = await _userManager.CheckPasswordAsync(userExists, loginModel.Password);

            if(checkPassword) {
                return Ok(checkPassword);
            } else {
                return BadRequest();
            }

            
        }
    }
}