using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Equipment_Status")]
    public partial class EquipmentStatus
    {
        public EquipmentStatus()
        {
            Equipment = new HashSet<Equipment>();
        }

        [Key]
        [Column("Equipment_Status_ID")]
        public int EquipmentStatusId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [InverseProperty("EquipmentStatus")]
        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
