namespace tata_library.Models
{
    public class OrderDetail
    {
        public int Id { get; set; } 
        public int OrderId {  get; set; }
        public int BookId {  get; set; }
        public decimal Price { get; set; }
        public int BookAmount {  get; set; }
        public Order? Order { get; set; }   
        public Book? Book { get; set; }
    }
}
