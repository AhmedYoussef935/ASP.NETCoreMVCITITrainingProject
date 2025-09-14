using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Category
    {
        // properties
        [Key]
        [DisplayName("ID")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Brand Name is mandatory")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Brand Name is between 2 and 20 characters")]
        [RegularExpression(@"^[A-Za-z0-9&,\s]+$", ErrorMessage = "Description Should contain: (a-z, A-Z, 0-9 and &) only")]
        [DisplayName("Name")]
        public string? CategoryName { get; set; }
        [Required(ErrorMessage = "Brand Description is mandatory")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Brand Description is between 5 and 100 characters")]
        [RegularExpression(@"^[A-Za-z0-9&,\s]+$", ErrorMessage = "Description Should contain: (a-z, A-Z, 0-9 and &) only")]
        [DisplayName("Description")]
        public string? CategoryDescription { get; set; }
        // relationships
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        // methods
        public override string ToString()
        {
            return $"Category Id: {CategoryId}, Name: {CategoryName}, Description: {CategoryDescription}";
        }
    }
}
