
using ECommerce.Data.Entities;

namespace ECommerce.Data.DTO
{
    public class CartDTO
    {
        public string Id { get; set; }
        public Product[] Products { get; set; }

    }
}