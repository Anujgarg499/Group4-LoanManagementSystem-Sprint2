using LoanManagementSystem.API.DBAccess;
using LoanManagementSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Repositories
{    
    public class CustomerRepository:ICustomerRepository
    {
        LoanManagementSystemDBContext db = null;
        public CustomerRepository(LoanManagementSystemDBContext db)
        {
            this.db = db;
        }

        public void AddCustomer(Customer customer)
        {
            try
            {                
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void ApplyLoan(LoanDetails loandetails)
        {
            try
            {
                db.LoanDetails.Add(loandetails);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public LoanDetails CheckLoanStatus(string CustomerId)
        {
            try
            {
                LoanDetails loanDetails = db.LoanDetails.Find(CustomerId);
                return loanDetails;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsLoginCustomer(string CustomerId, string CustomerPassword)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerById(Customer customer)
        {
            try
            {
                db.Customers.Update(customer);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Customer SearchCustomerById(string CustomerId)
        {
            try
            {
                Customer customer = db.Customers.Find(CustomerId);
                return customer;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
