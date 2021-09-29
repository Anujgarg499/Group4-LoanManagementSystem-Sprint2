using LoanManagementSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Repositories
{
    // Customer Repository Interface
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void UpdateCustomerById(Customer customer);
        bool IsLoginCustomer(string CustomerId, string CustomerPassword);
        void ApplyLoan(LoanDetails loandetails);
        Customer SearchCustomerById(string CustomerId);
        List<LoanDetails> CheckLoanStatus(string CustomerId);        
    }
}
