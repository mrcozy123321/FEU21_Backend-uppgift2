using System.ComponentModel.DataAnnotations;

namespace FEU21_Backend_2.Models.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}
