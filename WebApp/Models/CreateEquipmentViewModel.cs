using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class CreateEquipmentViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal RentalRate { get; set; }

        [Required]
        public int Category_ID { get; set; }

        [Required]
        public int Equipment_Status_ID { get; set; }

        public IFormFile? EquipmentImage { get; set; }

        public string? Specifications { get; set; }
    }
}
