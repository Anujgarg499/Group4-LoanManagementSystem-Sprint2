using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementSystem.API.Entities
{
    [Table("LoanDetails")]
    public class LoanDetails
    {
        [Key]        
        public decimal LoanAccNumber { get; set; }
        [Required]        
        public decimal LoanAmount { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public Employee Employee { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LoanType { get; set; }
        [Required]
        [StringLength(30)]
        public DateTime? LoanApprovedDate { get; set; }
        [Column(TypeName = "varchar")]
        public string LoanStatus { get; set; }
        [Required]
        public DateTime? DispersalDate { get; set; }
        [Required]
        public decimal InteresrRate { get; set; }
        public decimal? Tenure { get; set; }            
        public DateTime? EmiStartDate { get; set; }
        public DateTime? EmiEndDate { get; set; }
        public decimal? EmiAmount { get; set; }
        public decimal? CreditLimit { get; set; }
        public DateTime? LastUpdatedCreditDate { get; set; }
        public decimal? CustomerAssetId { get; set; }


    }
}
