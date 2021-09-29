using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Models
{
    // Pending Customer Model and Validation
    public class PendingCustomers
    {
        [DisplayName("Customer Username")]
        public string CustomerId { get; set; }
        [DisplayName("Loan Account Number")]
        public string LoanAccNumber { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Loan Status")]
        public string LoanStatus { get; set; }
        [DisplayName("Loan Amount")]
        public string LoanAmount { get; set; }
    }
}
