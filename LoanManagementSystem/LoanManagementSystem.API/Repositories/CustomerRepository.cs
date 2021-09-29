using LoanManagementSystem.API.DBAccess;
using LoanManagementSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Repositories
{    
    // Customer Repository implementing Customer Repository Interface
    public class CustomerRepository:ICustomerRepository
    {
        LoanManagementSystemDBContext db = null;
        public CustomerRepository(LoanManagementSystemDBContext db)
        {
            this.db = db;
        }

        // For Regestering the Customer to the Customer Table in the Database
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

        // For Applying the Loan and entering the Details to the LoanDetails Table in the Database
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

        // For Checking the loan status 
        public List<LoanDetails> CheckLoanStatus(string CustomerId)
        {
            try
            {
                List<LoanDetails> details = new List<LoanDetails>();
                var query= db.LoanDetails.Where(l => l.CustomerId == CustomerId);
                foreach(var status in query)
                {
                    var loanDetails = new LoanDetails()
                    {
                        CustomerId=status.CustomerId,
                        LoanAccNumber=status.LoanAccNumber,
                        LoanAmount=status.LoanAmount,
                        LoanStatus=status.LoanStatus,
                        LoanType=status.LoanType
                    };
                    details.Add(loanDetails);
                }
                return details;
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

        // For Updating Customer By Id into the Database
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

        // For Searching Customer By Id from the Database
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
