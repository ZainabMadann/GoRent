using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class PaymentViewModel
    {
        [Required]
        public int RentalRequestId { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string ExpiryDate { get; set; }

        [Required]
        public string CVV { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
