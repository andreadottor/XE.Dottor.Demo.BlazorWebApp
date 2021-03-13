namespace XE.Dottor.BlazorWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {

        [Required]
        public string Username { get; set; } = "";
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";
    }
}
