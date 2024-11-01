using System.ComponentModel.DataAnnotations;

namespace techservice_winforms.Data.Models
{
	public class RepairRequest
	{
		[Key]
		public int Id { get; set; }
		// FK EquipmentId
		public int EquipmentId { get; set; }
		public Equipment Equipment { get; set; } = null!;
		// FK ClientId
		public int ClientId { get; set; }
		public Client Client { get; set; } = null!;
		// Other
		public string Description { get; set; } = string.Empty;
		public string Status { get; set; } = string.Empty; // Queued | InProgess | Completed
		public string Priority { get; set; } = string.Empty; // S | A | B | C | D | E | F
		public DateTime CreatedAt { get; set; }
		public DateTime ProcessedAt { get; set; }
		public DateTime CompletedAt { get; set; }

		// FK
		public IEnumerable<RepairReport> RepairReports { get; set; } = null!;
	}
}
