using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace LoanManagementSystem.API.Entities
{
    // Getting and Setting LoanDetails Entities Details
    [Table("LoanDetails")]
    public class LoanDetails
    {
        [Key]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LoanAccNumber { get; set; }
        [Required]
        [Column(TypeName = "numeric")]
        public decimal LoanAmount { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        //[Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        [ForeignKey("Employee")]
        public string EmpId { get; set; }
        public Employee Employee { get; set; }
       //[Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LoanType { get; set; }              
        public DateTime? LoanApprovedDate { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LoanStatus { get; set; }        
        public DateTime? DispersalDate { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string InteresrRate { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Tenure { get; set; }            
        public DateTime? EmiStartDate { get; set; }
        public DateTime? EmiEndDate { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? EmiAmount { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? CreditLimit { get; set; }
        public DateTime? LastUpdatedCreditDate { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? CustomerAssetId { get; set; }


    }
}
