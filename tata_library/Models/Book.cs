namespace tata_library.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author {  get; set; }
        public decimal Price { get; set; }
        public int CopiesAvailable { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
