using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "EmpId is required")]
        public string EmpId { get; set; }
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Give Name in Alphabets Only")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Please enter the Password")]
        [RegularExpression(@"^([a-zA-Z][0-9][~!@#$%^&*]){8,10}+$", ErrorMessage = "Please enter a valid password")]
        public string EmpPassword { get; set; }
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please enter the correct PhoneNumber")]
        public string ContactNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(25, ErrorMessage = "Maximum of 25 characters allowed")]
        public string Email { get; set; }
        public string EmpType { get; set; }
    }
}
