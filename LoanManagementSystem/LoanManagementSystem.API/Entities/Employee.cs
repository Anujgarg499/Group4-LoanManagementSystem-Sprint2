using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementSystem.API.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar")]
        public string EmpId { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string EmpName { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string EmpPassword { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string ContactNumber { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string EmpType { get; set; }
    }
}
