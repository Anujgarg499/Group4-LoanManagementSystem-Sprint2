using LoanManagementSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Repositories
{
    public interface IEmployeeRepository
    {
        bool IsLoginBankEmployee(string EmpId, string EmpPassword);
        List<Customer> ViewCustomers();
        Customer SearchCustomerById(string CustomerId);
        void DeleteCustomerById(string CustomerId, decimal LoanAccNumber);
        void LoanApproval(string CustomerId, string EmpId);
        void LoanRejection(string CustomerId, string EmpId, decimal LoanAccNumber);
        List<PendingCustomers> ViewPendingCustomers();        
        bool CheckCriteria(string CustomerId);
    }
}
