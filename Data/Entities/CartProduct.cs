
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Data.Entities
{
    public class CartProduct
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public Cart? Cart { get; set; }

        public bool IsOrdered { get; set; }
        
    }
}