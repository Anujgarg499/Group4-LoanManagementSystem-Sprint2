using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementSystem.API.Entities
{
    [Table("Customer")]
    public class Customer
    {
        // Getting and Setting Customer Entities Details
        [Key]
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string CustomerId { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string CustomerPassword { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string PanNumber { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string AadharNumber { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ContactNumber { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string DOB { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? CreditLimit { get; set; }
        public DateTime? LastUpdatedCreditDate { get; set; }
    }
}
