using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Model
{
    [Table("Request_Status")]
    public partial class RequestStatus
    {
        public RequestStatus()
        {
            RentalRequests = new HashSet<RentalRequest>();
        }

        [Key]
        [Column("Request_Status_ID")]
        public int RequestStatusId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; } = null!;

        [InverseProperty("RequestStatus")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
    }
}
