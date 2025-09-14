using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Models
{
    public class Product
    {
        // properties
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Title is mandatory")]
        [RegularExpression(@"^[A-Za-z0-9&\-,\s]+$", ErrorMessage = "Title Should contain: ((a-z), (A-Z), (0-9) (&) and (-)) only")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product Title is between 3 and 50 characters")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Price is mandatory")]
        [Range(0, float.MaxValue, ErrorMessage = "Product Price should be positive")]
        public float? Price { get; set; }
        [Required(ErrorMessage = "Description is mandatory")]
        [RegularExpression(@"^[A-Za-z0-9&\-,\s]+$", ErrorMessage = "Description Should contain: ((a-z), (A-Z), (0-9) (&) and (-)) only")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Product Description is between 5 and 100 characters")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Product quantity is mandatory")]
        [Range(0, int.MaxValue, ErrorMessage = "Product Price should be positive")]
        public int? Quantity { get; set; }
        [DataType(DataType.ImageUrl)]
        [Url]
        [DisplayName("Image")]
        public string? ImagePath { get; set; }
        // relationships
        [Required]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(Category))]
        [Required(ErrorMessage = "Brand is mandatory")]
        [DisplayName("Brand")]
        public int? CategoryId { get; set; }
        // methods
        public override string ToString()
        {
            return $"Product Id: {ProductId}, Title: {Title}, Price: {Price}, Description: {Description}," +
                $"Quantity: {Quantity}, Image Path: {ImagePath}";
        }
    }
}
