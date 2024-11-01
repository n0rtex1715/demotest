using demo3.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class FavoriteProduct
{
	[Key]
	public int FavoriteProductID { get; set; }

	[Required]
	public int ClientID { get; set; }

	[Required]
	public int ProductID { get; set; }

	// nav props
	[ForeignKey("ClientID")]
	public Client Client { get; set; }

	[ForeignKey("ProductID")]
	public Product Product { get; set; }
}