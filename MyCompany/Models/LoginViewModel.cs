using System.ComponentModel.DataAnnotations;

namespace MyCompany.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Haslo")]
        public string Password { get; set; }

        [Display(Name = "Zapamietac mnie?")]
        public bool RememberMe { get; set; }
    }
}
