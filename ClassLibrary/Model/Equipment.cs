using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    public partial class Equipment
    {
        public Equipment()
        {
            RentalRequests = new HashSet<RentalRequest>();
            RentalTransactions = new HashSet<RentalTransaction>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("Equipment_ID")]
        public int EquipmentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal RentalRate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [Column("Category_ID")]
        public int CategoryId { get; set; }
        [Column("Equipment_Condition_ID")]
        public int EquipmentConditionId { get; set; }
        [Column("Equipment_Status_ID")]
        public int EquipmentStatusId { get; set; }
        [Column("Image_Path")]
        [StringLength(255)]
        [Unicode(false)]
        public string? ImagePath { get; set; }


        [ForeignKey("CategoryId")]
        [InverseProperty("Equipment")]
        public virtual Category Category { get; set; } = null!;
        [ForeignKey("EquipmentConditionId")]
        [InverseProperty("Equipment")]
        public virtual EquipmentCondition EquipmentCondition { get; set; } = null!;
        [ForeignKey("EquipmentStatusId")]
        [InverseProperty("Equipment")]
        public virtual EquipmentStatus EquipmentStatus { get; set; } = null!;
        [InverseProperty("Equipment")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        [InverseProperty("Equipment")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
        [InverseProperty("Equipment")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
