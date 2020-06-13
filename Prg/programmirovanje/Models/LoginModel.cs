using System;
using System.ComponentModel.DataAnnotations;

namespace programmirovanje.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}