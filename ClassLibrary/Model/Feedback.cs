using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        [Column("Feedback_ID")]
        public int FeedbackId { get; set; }
        public int Rating { get; set; }
        [Column("comment")]
        [StringLength(50)]
        [Unicode(false)]
        public string Comment { get; set; } = null!;
        [Column("User_ID")]
        public int UserId { get; set; }
        [Column("Rental_Transaction_ID")]
        public int RentalTransactionId { get; set; }
        public bool IsHidden { get; set; } = false;

        [ForeignKey("RentalTransactionId")]
        [InverseProperty("Feedbacks")]
        public virtual RentalTransaction RentalTransaction { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Feedbacks")]
        public virtual User User { get; set; } = null!;
    }
}
