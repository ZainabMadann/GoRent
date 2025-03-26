using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Rental_Request")]
    public partial class RentalRequest
    {
        public RentalRequest()
        {
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        [Column("Rental_Request_ID")]
        public int RentalRequestId { get; set; }
        [Column(TypeName = "date")]
        public DateTime RequestDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }
        [Column("Equipment_ID")]
        public int EquipmentId { get; set; }
        [Column("User_ID")]
        public int UserId { get; set; }
        [Column("Request_Status_ID")]
        public int RequestStatusId { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("RentalRequests")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("RequestStatusId")]
        [InverseProperty("RentalRequests")]
        public virtual RequestStatus RequestStatus { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("RentalRequests")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("RentalRequest")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
