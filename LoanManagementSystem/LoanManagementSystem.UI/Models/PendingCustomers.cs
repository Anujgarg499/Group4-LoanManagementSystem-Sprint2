using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Models
{
    public class PendingCustomers
    {        
        public string CustomerId { get; set; }
        public string LoanAccNumber { get; set; }        
        public string FirstName { get; set; }        
        public string LastName { get; set; }        
        public string LoanStatus { get; set; }
        public string LoanAmount { get; set; }
    }
}
