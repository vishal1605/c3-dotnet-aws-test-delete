using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace first_web_api_dot_net.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string RoleName { get; set; } = string.Empty;

        // Foreign key to the User table
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        // Navigation property to the related user
        [JsonIgnore]
        public User User { get; set; }


    }
}
