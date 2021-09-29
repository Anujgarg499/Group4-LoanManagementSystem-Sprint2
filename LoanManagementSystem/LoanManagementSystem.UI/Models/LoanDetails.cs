using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Models
{
    // Loan Details Model and Validation
    public class LoanDetails
    {
        [DisplayName("Loan Account Number")]
        public string LoanAccNumber { get; set; }
        [Required(ErrorMessage = "Please enter LoanAmount")]
        [DisplayName("Loan Amount")]
        public decimal LoanAmount { get; set; }
        [Required(ErrorMessage = "CustomerId is required")]
        [DisplayName("Customer Username")]
        public string CustomerId { get; set; }
        //[Required(ErrorMessage = "EmpId is required")]
        [DisplayName("Employee Id")]
        public string EmpId { get; set; }
        //[Required(ErrorMessage = "Please select the type of loan")]
        [DisplayName("Loan Type")]
        public string LoanType { get; set; }
        public DateTime? LoanApprovedDate { get; set; }
        public string LoanStatus { get; set; } = "Pending";
        [DataType(DataType.Date)]
        [DisplayName("DispersalDate")]
        public DateTime? DispersalDate { get; set; }
        //[DefaultValue(10)]
        [DisplayName("Interest Rate")]
        public string InterestRate { get; set; } = "10";     
        public decimal? Tenure { get; set; }
        public DateTime? EmiStartDate { get; set; }
        public DateTime? EmiEndDate { get; set; }
        public decimal? EmiAmount { get; set; }
        public decimal? CreditLimit { get; set; }
        public DateTime? LastUpdatedCreditDate { get; set; }
        public decimal? CustomerAssetId { get; set; }        
    }
}
