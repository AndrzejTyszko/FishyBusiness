using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FishyBuisness_3.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "The First Name field is required.")]
        [StringLength(50, ErrorMessage = "The First Name field must be at most 50 characters.")]
        public string FistName { get; set; }

        [Required(ErrorMessage = "The First Name field is required.")]
        [StringLength(50, ErrorMessage = "The Last Name field must be at most 50 characters.")]
        public string LastName { get; set; }
    }
}

