using System.ComponentModel.DataAnnotations;

namespace demo3.Data.Models
{
	public class Brand
	{
		[Key]
		public int BrandID { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }
	}
}
