using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Models
{
    public class User
    {
        // properties
        [Key]
        [DisplayName("ID")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "First Name is mandatory")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "First Name should contain letters only")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "First Name is between 2 and 20 characters")]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is mandatory")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Last Name should contain letters only")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Last Name is between 2 and 20 characters")]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Email is mandatory")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is mandatory")]
        [MinLength(6, ErrorMessage = "Password should consist of 6 characters at least")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "Pass@123";
        [NotMapped]
        [Required(ErrorMessage = "Password Confirmation is mandatory")]
        [MinLength(6, ErrorMessage = "Password should consist of 6 characters at least")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
        // methods
        public override string ToString()
        {
            return $"User Id: {UserId}, First Name: {FirstName}, Last Name: {LastName}, Email: {Email}";
        }
    }
}
