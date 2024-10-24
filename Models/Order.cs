namespace webapp_sample.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }  // Navigation property to Customer
    }
}