using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementSystem.API.Entities
{
    // Getting and Setting Pending Customer Entities Details
    public class PendingCustomers
    {
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string CustomerId { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LoanAccNumber { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar")]
        public string LoanStatus { get; set; }        
        [Column(TypeName = "numeric")]
        public decimal LoanAmount { get; set; }
    }
}
