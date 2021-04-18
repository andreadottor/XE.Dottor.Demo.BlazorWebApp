namespace Dottor.ItalianCoders.Demo.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegistrationModel
    {

        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
