using ECommerce.Data.Entities;
using ECommerce.Data.Repository;
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
        private readonly IGenericRepository<Cart> _cartsRepo;
        public UserController(UserManager<ApplicationUser> userManager, IGenericRepository<Cart> cartsRepo)
        {
            _cartsRepo = cartsRepo;
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {

            var user = new ApplicationUser
            {
                UserName = registerModel.FirstName,
            };


            var result = await _userManager.CreateAsync(user, registerModel.Password);

            if (result.Succeeded) {
                Cart cart = new() {UserId = registerModel.UserName};
                await _cartsRepo.Insert(cart);
            }

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