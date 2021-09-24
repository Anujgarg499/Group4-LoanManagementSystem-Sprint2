using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementSystem.API.Entities
{
    public class PendingCustomers
    {
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string CustomerId { get; set; }
        public decimal? LoanAccNumber { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar")]
        public string LoanStatus { get; set; }
    }
}
