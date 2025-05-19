using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class PaymentViewModel
    {
        [Required]
        public int RentalRequestId { get; set; }

        [Required]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Card number must be 16 digits")]
        public string CardNumber { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/\d{2}$", ErrorMessage = "Use MM/YY format")]
        public string ExpiryDate { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "CVV must be 3 digits")]
        public string CVV { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
