using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace first_web_api_dot_net.Models
{
    public class RoleName
    {
        [Key]
        public int RId { get; set; }
        public string Role { get; set; } = string.Empty;
    }
}
