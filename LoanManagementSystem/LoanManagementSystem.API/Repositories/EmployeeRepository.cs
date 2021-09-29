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

        public string CheckCriteria(string CustomerId)
        {
            string isEligible = "";
            List<LoanDetails> loanDetails = db.LoanDetails.ToList();
            var checkcriteria = (from loan in loanDetails where loan.CustomerId == CustomerId && loan.LoanStatus == "Approved" select loan).Count();
            if(checkcriteria == 1)
            {
                isEligible = "Not Eligible";
            }
            else
            {
                isEligible = "Eligible";
            }
            return isEligible;
        }

        public void DeleteCustomerById(string CustomerId, string LoanAccNumber)
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

        public void LoanApprovalorRejection(LoanDetails loanDetails)
        {
            try
            {
                /*string LoanAccNumber = loanDetails.LoanAccNumber;
                LoanDetails details = db.LoanDetails.Find(LoanAccNumber);
                if (details != null)
                {*/
                    db.LoanDetails.Update(loanDetails);
                    db.SaveChanges();
                /*}*/
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
        public LoanDetails SearchCustomerByLoanAccNumber(string LoanAccNumber)
        {
            try
            {
                LoanDetails details = db.LoanDetails.Find(LoanAccNumber);
                return details;

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
                                           LoanStatus=loan.LoanStatus,
                                           LoanAmount=loan.LoanAmount
                                       };
            foreach(var item in pendingCustomerquery)
            {
                var PendingCustomers = new PendingCustomers()
                {
                    CustomerId = item.CustomerId,
                    LoanAccNumber =item.LoanAccNumber,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    LoanStatus = item.LoanStatus,
                    LoanAmount=item.LoanAmount
                };                
                pendingCustomers.Add(PendingCustomers);
            }
            return pendingCustomers;
        }
        public List<PendingCustomers> ViewRejectedCustomers()
        {
            List<Customer> customers = db.Customers.ToList();
            List<LoanDetails> loanDetails = db.LoanDetails.ToList();
            List<PendingCustomers> rejectedCustomers = new List<PendingCustomers>();
            var rejectedCustomerquery = from customer in customers
                                        join loan in loanDetails on customer.CustomerId equals loan.CustomerId
                                        where loan.LoanStatus == "Rejected"
                                        select new
                                        {
                                            CustomerId = customer.CustomerId,
                                            LoanAccNumber = loan.LoanAccNumber,
                                            FirstName = customer.FirstName,
                                            LastName = customer.LastName,
                                            LoanStatus = loan.LoanStatus,
                                            LoanAmount = loan.LoanAmount
                                        };
            foreach (var item in rejectedCustomerquery)
            {
                var PendingCustomers = new PendingCustomers()
                {
                    CustomerId = item.CustomerId,
                    LoanAccNumber = item.LoanAccNumber,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    LoanStatus = item.LoanStatus,
                    LoanAmount = item.LoanAmount
                };
                rejectedCustomers.Add(PendingCustomers);
            }
            return rejectedCustomers;
        }
        public string CheckApproval(string CustomerId, string LoanAccNumber)
        {
            try
            {
                string status = null;
                List<LoanDetails> loanDetails = db.LoanDetails.ToList();
                int count = (from customer in loanDetails
                             where customer.CustomerId == CustomerId
                             & customer.LoanStatus == "Approved"
                             select customer).Count();
                if (count == 1)
                {
                    var customers = (from customer in loanDetails
                                     where customer.CustomerId == CustomerId
                                     & customer.LoanStatus == "Approved"
                                     select customer);
                    foreach (var item in customers)
                    {
                        status = "Rejected";
                        item.LoanStatus = "Rejected";
                        db.SaveChanges();
                    }
                }
                else
                {
                    var customers = (from customer in loanDetails
                                     where customer.CustomerId == CustomerId
                                     & customer.LoanAccNumber == LoanAccNumber
                                     select customer);
                    foreach (var item in customers)
                    {
                        status = "Approved";
                        item.LoanStatus = "Approved";
                        db.SaveChanges();
                    }
                }
                return status;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
