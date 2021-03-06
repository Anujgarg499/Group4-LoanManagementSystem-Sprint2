using LoanManagementSystem.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Services
{
    // Customer Service Interface
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void UpdateCustomerById(Customer customer);
        Customer SearchCustomerById(string CustomerId);
        bool IsLoginCustomer(string CustomerId, string CustomerPassword);
        void ApplyLoan(LoanDetails loandetails);
        List<LoanDetails> CheckLoanStatus(string CustomerId);
    }
}
