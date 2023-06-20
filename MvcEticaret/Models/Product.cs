namespace MvcEticaret.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string StartCount { get; set; }
        public string OldPrice { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSale { get; set; }
    }
}
