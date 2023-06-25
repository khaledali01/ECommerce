using ECommerce.Data;
using ECommerce.Data.DTO;
using ECommerce.Data.Entities;
using ECommerce.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
       
		private readonly ECommerceContext _ecommerceContext;
		private readonly IGenericRepository<CartProduct> _cartProductsRepo;
		private readonly IGenericRepository<Cart> _cartsRepo;

		public CartController(ECommerceContext ecommerceContext, 
            IGenericRepository<CartProduct> cartProductsRepo, 
            IGenericRepository<Cart> cartsRepo
            ) {
            _cartProductsRepo = cartProductsRepo;
			_cartsRepo = cartsRepo;
			_ecommerceContext = ecommerceContext;
        }
            
        [HttpPost]
        public async Task<IActionResult> AddToCart(CartDTO cartDto)
        {
            // var cartsWithProducts = await _ecommerceContext.Carts.Include(n => n.Products).ToListAsync();
            var carts = await _ecommerceContext.Carts.ToListAsync();
            var userCart = carts.Where(n => n.UserId == cartDto.UserId).FirstOrDefault();

            CartProduct cartProduct = new()
            {
                ProductId = cartDto.Product.ProductID,
                Name = cartDto.Product.Name,
                Description = cartDto.Product.Description,
                ImageURL = cartDto.Product.ImageURL,
                Price = cartDto.Product.Price,
                Quantity = cartDto.Product.Quantity,
                Color = cartDto.Product.Color,
                Brand = cartDto.Product.Brand,
				

		    };

            //cartProduct.Cart = userCart;

            await _cartProductsRepo.Insert(cartProduct);

            //await _cartsRepo.Update(userCart);

            return Ok(userCart);


            




        }

    }
}