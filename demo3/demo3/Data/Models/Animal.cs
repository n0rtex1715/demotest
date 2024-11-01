using System.ComponentModel.DataAnnotations;

namespace demo3.Data.Models
{
	public class Animal
	{
		[Key]
		public int AnimalID { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }
	}
}
