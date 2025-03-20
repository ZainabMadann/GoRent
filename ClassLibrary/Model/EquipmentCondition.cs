using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Equipment_Condition")]
    public partial class EquipmentCondition
    {
        public EquipmentCondition()
        {
            Equipment = new HashSet<Equipment>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("Equipment_Condition_ID")]
        public int EquipmentConditionId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; } = null!;

        [InverseProperty("EquipmentCondition")]
        public virtual ICollection<Equipment> Equipment { get; set; }
        [InverseProperty("EquipmentCondition")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
