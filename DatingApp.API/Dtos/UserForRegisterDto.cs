using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Username requires minimum 3 characters!")]
        [MaxLength(100, ErrorMessage = "Username takes a maximum of 100 characters!")]
        public string Username { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password requires a minimum of 5 characters!")]
        [MaxLength(100, ErrorMessage = "Password takes a maximum of 100 characters!")]
        public string Password { get; set; }
    }
}