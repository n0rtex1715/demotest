using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Order
{
	[Key]
	public int OrderID { get; set; }

	[Required]
	public int ClientID { get; set; }

	[Required]
	public DateTime OrderDate { get; set; }

	public DateTime? DeliveryDate { get; set; }

	// nav props
	[ForeignKey("ClientID")]
	public Client Client { get; set; }

	public ICollection<OrderDetail> OrderDetails { get; set; }
}
