using System.ComponentModel.DataAnnotations;

namespace techservice_winforms.Data.Models
{
	public class Equipment
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string SerialNumber { get; set; } = string.Empty;
		public string Type { get; set; } = string.Empty;
		public string Manufacturer { get; set; } = string.Empty;

		// FK
		public IEnumerable<RepairRequest> RepairRequests { get; set; } = null!;
	}
}
