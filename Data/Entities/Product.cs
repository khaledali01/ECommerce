namespace ECommerce.Data.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string Color { get; set; }
        public string Brand { get; set; }
        public string ImageURL { get; set; }
    }
}