using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class CategoryViewModel
    {
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
    }

}
