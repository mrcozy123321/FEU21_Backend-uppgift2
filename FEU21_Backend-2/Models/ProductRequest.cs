namespace FEU21_Backend_2.Models
{
    public class ProductRequest
    {
        public int ArticleNr { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

    }
}
