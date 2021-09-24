﻿using LoanManagementSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Repositories
{
    interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void UpdateCustomerById(Customer customer);
        bool IsLoginCustomer(string CustomerId, string CustomerPassword);
        void ApplyLoan(LoanDetails loandetails);
        string CheckLoanStatus(string CustomerId);
    }
}