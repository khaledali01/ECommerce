using ECommerce.Data.Entities;
using ECommerce.Data.Repository;
using ECommerce.Data.UserModels;
using ECommerce.Services.JWT;
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

        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly IJWTTokenService _tokenService;
        public UserController(UserManager<ApplicationUser> userManager,
             IGenericRepository<Cart> cartsRepo,
             SignInManager<ApplicationUser> signInManager, 
             IJWTTokenService tokenService
             )
        {
            _cartsRepo = cartsRepo;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {

            var user = new ApplicationUser
            {
                UserName = registerModel.FirstName,
            };


            var result = await _userManager.CreateAsync(user, registerModel.Password);

            if (result.Succeeded)
            {
                Cart cart = new() { UserId = registerModel.UserName };
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

            var checkPassword = await _signInManager.CheckPasswordSignInAsync(userExists, loginModel.Password, false);

            if (checkPassword.Succeeded)
            {
                return Ok(new
                {
                    result = checkPassword, 
                    username = userExists.UserName, 
                    email = userExists.Email, 
                    userid = userExists.Id, 
                    token = _tokenService.GenerateToken(userExists), 
                    isadmin = userExists.IsAdmin,
                });
            }
            else
            {
                return BadRequest();
            }


        }
    }
}