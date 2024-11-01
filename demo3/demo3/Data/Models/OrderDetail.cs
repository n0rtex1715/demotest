using demo3.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class OrderDetail
{
	[Key]
	public int OrderDetailID { get; set; }

	[Required]
	public int OrderID { get; set; }

	[Required]
	[MaxLength(50)]
	public int ProductID { get; set; }

	[Required]
	public int Quantity { get; set; }

	// nav props
	[ForeignKey("OrderID")]
	public Order Order { get; set; }

	[ForeignKey("ProductID")]
	public Product Product { get; set; }
}