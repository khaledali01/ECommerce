using ECommerce.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Data.Repository;

namespace ECommerce.Controllers
{
    [ApiController]
	[Route("api/[controller]")]

	public class ProductsController : ControllerBase
	{
        private readonly IGenericRepository<Product> _productRepository;

        public ProductsController(IGenericRepository<Product> gRepository)
		{
            _productRepository = gRepository;
        }

		[HttpGet]
		public async Task<IActionResult> GetProducts()
		{
			var res = await _productRepository.GetAll();
			return Ok(res);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProduct(int id)
		{
			var product = await _productRepository.GetById(id);

			if (product == null)
			{
				return NotFound();
			}

			return Ok(product);
		}
	}
}
