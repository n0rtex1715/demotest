using System.ComponentModel.DataAnnotations;

namespace techservice_winforms.Data.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public bool isEmployee { get; set; }
		public bool isAdmin { get; set; }
	}
}
