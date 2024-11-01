using System.ComponentModel.DataAnnotations;

namespace demo3.Data.Models
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }
	}
}
