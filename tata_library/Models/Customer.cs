namespace tata_library.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Fname { get; set; }    
        public string Lname { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
