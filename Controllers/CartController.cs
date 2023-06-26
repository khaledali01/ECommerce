using ECommerce.Data.DTO;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Data.Entities;
using ECommerce.Data.Repository;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {

        private readonly IGenericRepository<Cart> _cartRepo;

        public CartController(IGenericRepository<Cart> cartRepo)
        {
            _cartRepo = cartRepo;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] CartDTO cartDto)
        {

            Cart userCart = new() {
                UserId = cartDto.Id
            };

            await _cartRepo.Insert(userCart);

            return Ok(userCart);


        }

    }
}