using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace first_web_api_dot_net.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        // Navigation property for the related roles
        public List<Role> Roles { get; set; } = new List<Role>();



    }
}
