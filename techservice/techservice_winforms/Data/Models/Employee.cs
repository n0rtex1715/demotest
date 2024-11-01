using System.ComponentModel.DataAnnotations;

namespace techservice_winforms.Data.Models
{
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Role { get; set; } = string.Empty;
		public string ContactInfo { get; set; } = string.Empty;

		// FK
		public IEnumerable<RepairReport> RepairReports { get; set; } = null!;
	}
}
