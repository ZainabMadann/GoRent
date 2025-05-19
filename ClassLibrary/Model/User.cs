using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            Logs = new HashSet<Log>();
            Notifications = new HashSet<Notification>();
            RentalRequests = new HashSet<RentalRequest>();
            RentalTransactions = new HashSet<RentalTransaction>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("User_ID")]
        public int UserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Role { get; set; } = null!;

        [InverseProperty("User")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Log> Logs { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
