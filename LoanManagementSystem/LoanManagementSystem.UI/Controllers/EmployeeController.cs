using LoanManagementSystem.UI.Models;
using LoanManagementSystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Controllers
{
    // Employee Controller
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // For the Main Page of Employee
        public IActionResult Index()
        {
            return View();
        }

        // For Viewing All the Customers
        public IActionResult ViewCustomer()
        {
            try
            {
                List<Customer> customers = employeeService.ViewCustomers();
                return View(customers);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // For getting Customer By Id
        public IActionResult GetCustomer(string customerid)
        {
            try
            {
                Customer customer = employeeService.SearchCustomerById(customerid);
                return View(customer);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // For Delete Customer Loan
        public IActionResult DeleteCustomerLoan(string LoanAccNumber)
        {
            try
            {
                employeeService.DeleteCustomerById(LoanAccNumber);
                return View();
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        // For Viewing Rejected Loans of Customer
        public IActionResult DeleteRejectedLoan()
        {
            try
            {
                List<PendingCustomers> pendingcustomers = employeeService.ViewRejectedCustomers();
                return View(pendingcustomers);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        // For Viewing all the Customer where Loan Status is Pending and processing the Loan
        public IActionResult LoanProcessing()
        {
            try
            {
                List<PendingCustomers> pendingcustomers = employeeService.ViewPendingCustomers();
                return View(pendingcustomers);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }               
        /*public IActionResult GetCustomerEligibility(string customerid)
        {
            try
            {
                var status = employeeService.CheckCriteria(customerid);
                ViewData["status"] = status;
                return View();
            }
            catch (Exception)
            {
                return View("Error");
            }
        }*/
        [HttpGet]
        public IActionResult Edit(string LoanAccNumber)
        {
            LoanDetails details = employeeService.SearchCustomerByLoanAccNumber(LoanAccNumber);            
            return View(details);
        }
        /*[HttpPost]
        public IActionResult Edit(LoanDetails loanDetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    employeeService.LoanApprovalorRejection(loanDetails);
                    return RedirectToAction("LoanProcessing");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {
                return View("Error");
            }
        }*/

        // For Loan Approval or Rejection
        [HttpGet]
        public IActionResult GetCheckApproval(string customerid, string loanaccnumber)
        {
            try
            {
                employeeService.CheckApproval(customerid, loanaccnumber);
                return View();
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
