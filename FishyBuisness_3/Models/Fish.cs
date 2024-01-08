using System.ComponentModel.DataAnnotations;

namespace FishyBuisness_3.Models
{
	public class Fish
	{
		public int FishId { get; set; }

		[Required]
		[MaxLength(60, ErrorMessage = "Max Length length should not be more than 30 characters" )]
		[MinLength(3, ErrorMessage = "Product name should be at least 3 characters")]
		public string FishName { get; set; }

        [MaxLength(60, ErrorMessage = "Max Length length should not be more than 30 characters")]
        [MinLength(3, ErrorMessage = "Product name should be at least 3 characters")]
        public string FishDescription { get; set; }
		public string Spieces { get; set; }
		public string Habitat { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Can not be less than 0.1 and more than 100")]
        public double Lenght { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Can not be less than 0.1 and more than 1000")]
        public double Weight { get; set; }

		[Required]
		[Range(0, 100000, ErrorMessage = "Can not be less than 0.1 and more than 100000")]
		public double Price { get; set; }

	}
}
