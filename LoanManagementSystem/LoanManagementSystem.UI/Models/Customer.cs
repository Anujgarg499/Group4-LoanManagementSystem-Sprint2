using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace LoanManagementSystem.UI.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "CustomerId is required")]
        [DisplayName("Customer Username")]
        public string CustomerId { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        [RegularExpression(@"^[a-zA-Z].{3,20}$", ErrorMessage = "Give Name in Alphabets Only")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        [RegularExpression(@"^[a-zA-Z].{3,20}$", ErrorMessage = "Give Name in Alphabets Only")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the Password")]
        [DataType(DataType.Password)]
        /*[RegularExpression(@"^([a-zA-Z][0-9][~!@#$%^&*]).{8,20}$", ErrorMessage = "Please enter a valid password")]*/
        public string CustomerPassword { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please provide the PanNumber")]
        [RegularExpression(@"^[a-zA-Z]{5}[0-9]{4}[a-zA-Z]{1}$", ErrorMessage = "Please enter the correct PanNumber Ex: ASDFG1234H")]
        public string PanNumber { get; set; }
        [Required(ErrorMessage = "Please provide the AadharNumber")]
        [RegularExpression(@"^[0-9]{12}$", ErrorMessage = "Please enter the correct AadharNumber")]
        public string AadharNumber { get; set; }
        [Required(ErrorMessage = "Please enter the PhoneNumber")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please enter the correct PhoneNumber")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Please enter the Email Address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25, ErrorMessage = "Maximum of 25 characters allowed")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DisplayName("Date of Birth")]
        public string DOB { get; set; }
        public decimal? CreditLimit { get; set; }
        public DateTime? LastUpdatedCreditDate { get; set; }
    }
}
