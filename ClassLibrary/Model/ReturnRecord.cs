using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Return_Record")]
    public partial class ReturnRecord
    {
        [Key]
        [Column("Return_Record_ID")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ReturnRecordId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [Column("Rental_transaction_ID")]
        public int RentalTransactionId { get; set; }

        [Column("Equipment_ID")]
        public int EquipmentId { get; set; }

        [Column("User_ID")]
        public int UserId { get; set; }

        [Column("Equipment_Condition_ID")]
        public int EquipmentConditionId { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("ReturnRecords")]
        public virtual Equipment Equipment { get; set; } = null!;

        [ForeignKey("EquipmentConditionId")]
        [InverseProperty("ReturnRecords")]
        public virtual EquipmentCondition EquipmentCondition { get; set; } = null!;

        [ForeignKey("RentalTransactionId")]
        [InverseProperty("ReturnRecords")]
        public virtual RentalTransaction RentalTransaction { get; set; } = null!;

        [ForeignKey("UserId")]
        [InverseProperty("ReturnRecords")]
        public virtual User User { get; set; } = null!;
    }
}