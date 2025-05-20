using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Notification")]
    public partial class Notification
    {
        [Key]
        [Column("Notification_ID")]
        public int NotificationId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Massege { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("User_ID")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Notifications")]

        [Column("Is_Read")]
        public bool IsRead { get; set; } = false;

        public virtual User User { get; set; } = null!;
    }
}
