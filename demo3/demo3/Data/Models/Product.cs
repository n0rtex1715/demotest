using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo3.Data.Models
{
    public class Product
    {
        [Key]
        [MaxLength(255)]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public int CategoryID { get; set; }

		[ForeignKey("CategoryID")]
		public Category Category { get; set; }

		[Required]
        public int BrandID { get; set; }

		[ForeignKey("BrandID")]
        public Brand Brand { get; set; }

        [Required]
        public int AnimalID { get; set; }

        [ForeignKey("AnimalID")]
        public Animal Animal { get; set; }

        public string Description { get; set; }
        public string Composition { get; set; }

        [Required]
        [MaxLength(50)]
        public string Unit { get; set; }

        public int Stock { get; set; }

		// [Column(TypeName = "decimal(10, 2)")]
		[Column(TypeName = "money")]
		[Required]
        public decimal Price { get; set; }

        // nav props
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<FavoriteProduct> FavoriteProducts { get; set; }

    }
}
