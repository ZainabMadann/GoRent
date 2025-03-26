using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Document")]
    public partial class Document
    {
        [Key]
        [Column("Document_ID")]
        public int DocumentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FileName { get; set; } = null!;
        [StringLength(50)]
        public string FileType { get; set; } = null!;
        [Column("FileURL")]
        public string FileUrl { get; set; } = null!;
        [Column("Rental_transaction_ID")]
        public int RentalTransactionId { get; set; }

        [ForeignKey("RentalTransactionId")]
        [InverseProperty("Documents")]
        public virtual RentalTransaction RentalTransaction { get; set; } = null!;
    }
}
