
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Data.Entities
{
    public class Cart
    {
        [Key]
        public string UserId { get; set; }
        public List<CartProduct>? Products { get; set; }
    }
}