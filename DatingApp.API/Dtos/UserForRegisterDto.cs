using System.ComponentModel.DataAnnotations;

namespace MyProjects_V2.Git.DatingApp.DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        
        public string Password { get; set; }
    }
}