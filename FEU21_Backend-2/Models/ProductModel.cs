using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace FEU21_Backend_2.Models
{
    public class ProductModel
    {
        [Key]
        [JsonProperty("id")]
        public Guid Id { get; set; }
        public int ArticleNr { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public string PartitionKey { get; set; } = null!;
    }
}
