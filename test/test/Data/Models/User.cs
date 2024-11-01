using System.ComponentModel.DataAnnotations;

namespace test.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Login { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
