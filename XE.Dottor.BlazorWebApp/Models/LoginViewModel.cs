namespace XE.Dottor.BlazorWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

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
