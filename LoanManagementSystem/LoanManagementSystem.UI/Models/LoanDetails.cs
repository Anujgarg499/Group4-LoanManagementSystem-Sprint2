using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Models
{
    public class LoanDetails
    {
        public decimal LoanAccNumber { get; set; }
        [Required(ErrorMessage = "Please enter LoanAmount")]
        public decimal LoanAmount { get; set; }
        [Required(ErrorMessage = "CustomerId is required")]
        [DisplayName("Customer Username")]
        public string CustomerId { get; set; }
        [Required(ErrorMessage = "EmpId is required")]
        public string EmpId { get; set; }
        [Required(ErrorMessage = "Please select the type of loan")]
        public string LoanType { get; set; }
        public DateTime? LoanApprovedDate { get; set; }
        public string LoanStatus { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("DispersalDate")]
        public DateTime? DispersalDate { get; set; }
        public decimal InterestRate { get; set; }
        [Required(ErrorMessage = "Please enter the Tenure")]
        public decimal? Tenure { get; set; }
        public DateTime? EmiStartDate { get; set; }
        public DateTime? EmiEndDate { get; set; }
        public decimal? EmiAmount { get; set; }
        public decimal? CreditLimit { get; set; }
        public DateTime? LastUpdatedCreditDate { get; set; }
        public decimal? CustomerAssetId { get; set; }
    }
}
