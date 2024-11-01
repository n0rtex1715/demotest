using System.ComponentModel.DataAnnotations;

public class Client
{
	[Key]
	public int ClientID { get; set; }

	[Required]
	[MaxLength(255)]
	public string Name { get; set; }

	[MaxLength(20)]
	public string Phone { get; set; }

	[MaxLength(255)]
	public string Address { get; set; }

	[Required]
	[MaxLength(50)]
	public string Login { get; set; }

	[Required]
	[MaxLength(50)]
	public string Password { get; set; }

	// nav props
	public ICollection<Order> Orders { get; set; }
	public ICollection<FavoriteProduct> FavoriteProducts { get; set; }
}