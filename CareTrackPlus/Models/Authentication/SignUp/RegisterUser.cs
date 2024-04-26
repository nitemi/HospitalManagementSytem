 using System.ComponentModel.DataAnnotations;


namespace CareTrackPlus.Api.Models.Authentication.SignUp
{
    public class RegisterUser 
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string? Password { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }

    }
}
