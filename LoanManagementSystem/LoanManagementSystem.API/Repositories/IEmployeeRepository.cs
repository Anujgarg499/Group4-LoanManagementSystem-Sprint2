using LoanManagementSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Repositories
{
    // Employee Repository Interface
    public interface IEmployeeRepository
    {
        bool IsLoginBankEmployee(string EmpId, string EmpPassword);
        List<Customer> ViewCustomers();
        Customer SearchCustomerById(string CustomerId);
        LoanDetails SearchCustomerByLoanAccNumber(string LoanAccNumber);
        void DeleteCustomerById(string LoanAccNumber);        
       /* void LoanApprovalorRejection(LoanDetails loanDetails);*/
        List<PendingCustomers> ViewPendingCustomers();
        List<PendingCustomers> ViewRejectedCustomers();
        /*string CheckCriteria(string CustomerId);*/
        public string CheckApproval(string CustomerId, string LoanAccNumber);
    }
}
