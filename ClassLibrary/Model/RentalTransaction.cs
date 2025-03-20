using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Rental_Transaction")]
    public partial class RentalTransaction
    {
        public RentalTransaction()
        {
            Documents = new HashSet<Document>();
            Feedbacks = new HashSet<Feedback>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("Rental_transaction_ID")]
        public int RentalTransactionId { get; set; }
        [Column(TypeName = "date")]
        public DateTime RentalStartDate { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalCost { get; set; }
        [Column(TypeName = "date")]
        public DateTime RentalEndDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentStatus { get; set; } = null!;
        [Column("Rental_Request_ID")]
        public int RentalRequestId { get; set; }
        [Column("Equipment_ID")]
        public int EquipmentId { get; set; }
        [Column("User_ID")]
        public int UserId { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("RentalTransactions")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("RentalRequestId")]
        [InverseProperty("RentalTransactions")]
        public virtual RentalRequest RentalRequest { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("RentalTransactions")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("RentalTransaction")]
        public virtual ICollection<Document> Documents { get; set; }
        [InverseProperty("RentalTransaction")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [InverseProperty("RentalTransaction")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
