﻿using ECommerce.Data.Entities;
using ECommerce.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    [ApiController]
	[Route("api/[controller]")]

	public class ProductsController : ControllerBase
	{
		private readonly ECommerceContext _context;

		public ProductsController(ECommerceContext context)
		{
			this._context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
		{
			return await _context.Products.ToListAsync();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProduct(int id)
		{
			var product = await _context.Products.FindAsync(id);

			if (product == null)
			{
				return NotFound();
			}

			return product;
		}
	}
}
