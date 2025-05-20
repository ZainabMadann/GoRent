using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Log")]
    public partial class Log
    {
        [Key]
        [Column("Log_ID")]
        public int LogId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Action { get; set; } = null!;
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        [Column("User_ID")]
        public int UserId { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string CurrentValue { get; set; } = null!;
        [StringLength(1000)]
        [Unicode(false)]
        public string OriginalValue { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string EntityChanged { get; set; } = null!;

        [ForeignKey("UserId")]
        [InverseProperty("Logs")]
        public virtual User User { get; set; } = null!;
    }
}
