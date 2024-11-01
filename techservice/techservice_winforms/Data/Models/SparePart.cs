using System.ComponentModel.DataAnnotations;

namespace techservice_winforms.Data.Models
{
	public class SparePart
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Manufacturer { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public int Stock { get; set; }

		// FK
		public IEnumerable<SparePartRequest> SparePartRequests { get; set; } = null!;
	}
}
