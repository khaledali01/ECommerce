namespace ECommerce.Data.Entities
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int UserID { get; set; }
        public int OrderID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionStatus { get; set; }
    }
}