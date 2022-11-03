using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FEU21_Backend_2.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        public int ArticleNr { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual CategoryEntity Category { get; set; }
    }
}
