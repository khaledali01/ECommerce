namespace ECommerce.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public List<CartProduct> Products { get; set; }

    }
}