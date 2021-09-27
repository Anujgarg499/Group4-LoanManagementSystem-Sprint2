using LoanManagementSystem.API.DBAccess;
using LoanManagementSystem.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        LoanManagementSystemDBContext db = null;
        public EmployeeRepository(LoanManagementSystemDBContext db)
        {
            this.db = db;
        }

        public bool CheckCriteria(string CustomerId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerById(string CustomerId, decimal LoanAccNumber)
        {
            try
            {
                //Customer customer = db.Customers.Find(CustomerId,LoanAccNumber);
                LoanDetails loanDetails = db.LoanDetails.Find(CustomerId, LoanAccNumber);                
                    db.LoanDetails.Remove(loanDetails);
                    //db.Customers.Remove(customer);
                    db.SaveChanges();                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsLoginBankEmployee(string EmpId, string EmpPassword)
        {
            throw new NotImplementedException();
        }

        public void LoanApproval(string CustomerId, string EmpId)
        {
            throw new NotImplementedException();
        }

        public void LoanRejection(string CustomerId, string EmpId, decimal LoanAccNumber)
        {
            throw new NotImplementedException();
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

        public List<Customer> ViewCustomers()
        {
            try
            {
                List<Customer> customers= db.Customers.ToList();
                return customers;                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<PendingCustomers> ViewPendingCustomers()
        {
            /*List<PendingCustomers> pendingCustomers = db.PendingCustomers.FromSqlRaw("ViewPendingCustomers").ToList();
            return pendingCustomers;*/
            List<Customer> customers = db.Customers.ToList();
            List<LoanDetails> loanDetails = db.LoanDetails.ToList();
            List<PendingCustomers> pendingCustomers = new List<PendingCustomers>();
            var pendingCustomerquery = from customer in customers
                                       join loan in loanDetails on customer.CustomerId equals loan.CustomerId
                                       where loan.LoanStatus == "Pending"
                                       select new
                                       {
                                           CustomerId=customer.CustomerId,
                                           LoanAccNumber=loan.LoanAccNumber,
                                           FirstName=customer.FirstName,
                                           LastName=customer.LastName,
                                           LoanStatus=loan.LoanStatus
                                       };
            foreach(var item in pendingCustomerquery)
            {
                var PendingCustomers = new PendingCustomers()
                {
                    CustomerId = item.CustomerId,
                    LoanAccNumber =decimal.Parse(item.LoanAccNumber),
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    LoanStatus = item.LoanStatus
                };                
                pendingCustomers.Add(PendingCustomers);
            }
            return pendingCustomers;
        }
    }
}
