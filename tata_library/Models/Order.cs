namespace tata_library.Models
{
    public class Order
    {
        public int OrderId {  get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<OrderDetail> Details { get; set; }   
    }

    public class OrderDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int BookAmount {  get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

    }
}
