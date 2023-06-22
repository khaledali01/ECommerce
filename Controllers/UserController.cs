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
			
			var  user = new ApplicationUser
            {
                UserName = registerModel.FirstName,
			};


            var result = await _userManager.CreateAsync(user, registerModel.Password);

            

        	return Ok(result);

		

        }
    }
}