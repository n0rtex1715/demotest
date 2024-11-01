using System.ComponentModel.DataAnnotations;

namespace techservice_winforms.Data.Models
{
	public class SparePartRequest
	{
		[Key]
		public int Id { get; set; }
		// FK RepairRequestId
		public int EmployeeId { get; set; }
		public Employee Employee { get; set; } = null!;
		// FK SparePartId
		public int SparePartId { get; set; }
		public SparePart SparePart { get; set; } = null!;
		// Other
		public int Quantity { get; set; }
		public string Status { get; set; } = string.Empty; // Queued | InProgress | Completed
	}
}
