using System.ComponentModel.DataAnnotations;

namespace FluentAPIDemo.Models
{
    public class Category
    {
        public Category()
        {
         //   Products = new HashSet<Product>();
        }
        [Key]
        public byte CategoryId { get; set; }
        [Required]
        [StringLength(20)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
