using System.ComponentModel.DataAnnotations;

namespace SimpleEmailApp.DtoS
{
	public class WelcomeRequestDto
	{
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
