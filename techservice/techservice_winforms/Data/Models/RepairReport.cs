using System.ComponentModel.DataAnnotations;

namespace techservice_winforms.Data.Models
{
	public class RepairReport
	{
		[Key]
		public int Id { get; set; }
		// FK RepairRequestId
		public int RepairRequestId { get; set; }
		public RepairRequest RepairRequest { get; set; } = null!;
		// FK ClientId
		public int? ClientId { get; set; }
		public Client Client { get; set; } = null!;
		// FK EmployeeId
		public int? EmployeeId { get; set; }
		public Employee Employee { get; set; } = null!;
		// FK SparePartRequestId
		public int? SparePartRequestId { get; set; }
		public SparePartRequest SparePartRequest { get; set; } = null!;
		// Other
		public string Description { get; set; } = string.Empty;
		public DateTime TimeSpent { get; set; }
		public DateTime ReportDate { get; set; }
	}
}
