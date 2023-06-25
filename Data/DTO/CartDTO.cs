
using ECommerce.Data.Entities;

namespace ECommerce.Data.DTO
{
    public class CartDTO
    {
        public string UserId { get; set; }
        public Product Product { get; set; }

    }
}