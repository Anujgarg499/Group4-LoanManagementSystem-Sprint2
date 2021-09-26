using LoanManagementSystem.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Services
{
    public interface IEmployeeService
    {
        bool IsLoginBankEmployee(string EmpId, string EmpPassword);
        List<Customer> ViewCustomers();
        Customer SearchCustomerById(string CustomerId);
        void DeleteCustomerById(string CustomerId, decimal LoanAccNumber);
        void LoanApproval(string CustomerId, string EmpId);
        void LoanRejection(string CustomerId, string EmpId, decimal LoanAccNumber);
        List<LoanDetails> ViewPendingCustomers();
        bool CheckCriteria(string CustomerId);
    }
}
