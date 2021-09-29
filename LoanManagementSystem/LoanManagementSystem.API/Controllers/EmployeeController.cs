using LoanManagementSystem.API.Entities;
using LoanManagementSystem.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.Controllers
{
    // Employee Controller
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository repository)
        {
            this.employeeRepository = repository;
        }

        // For Viewing All the Customers
        [HttpGet]
        [Route("ViewCustomers")]
        public IActionResult GetAllCustomers()
        {
            try
            {
                List<Customer> customers = employeeRepository.ViewCustomers();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        // For getting Customer By Id
        [HttpGet]
        [Route("GetCustomer/{id}")]
        public IActionResult GetCustomerById(string id)
        {
            try
            {
                Customer customer = employeeRepository.SearchCustomerById(id);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        // For Getting Customer by Loan Account Number
        [HttpGet]
        [Route("GetCustomerLoan")]
        public IActionResult GetCustomerByLoanAccNumber(string LoanAccNumber)
        {
            try
            {
                LoanDetails details = employeeRepository.SearchCustomerByLoanAccNumber(LoanAccNumber);
                return Ok(details);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        // For Deleting Rejected Loans of Customer
        [HttpDelete]
        [Route("DeleteCustomer/{loanAccountNumber}")]
        public IActionResult DeleteCustomerById(string loanAccountNumber)
        {
            try
            {
                employeeRepository.DeleteCustomerById(loanAccountNumber);
                return Ok();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        // For Viewing all the Customer where Loan Status is Pending
        [HttpGet]
        [Route("ViewPendingCustomers")]
        public IActionResult GetPendingCustomers()
        {
            try
            {
                List<PendingCustomers> pendingcustomers = employeeRepository.ViewPendingCustomers();
                return Ok(pendingcustomers);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        //For Viewing Rejected Customers
        [HttpGet]
        [Route("ViewRejectedCustomers")]
        public IActionResult GetRejectedCustomers()
        {
            try
            {
                List<PendingCustomers> rejectedcustomers = employeeRepository.ViewRejectedCustomers();
                return Ok(rejectedcustomers);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        /*[HttpGet]
        [Route("GetCustomerEligibility/{id}")]
        public IActionResult GetCustomerEligibility(string id)
        {
            try
            {
                string status = employeeRepository.CheckCriteria(id);
                return Ok(status);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }*/
        /*[HttpPut]
        [Route("UpdateLoanStatus")]
        public IActionResult PutLoanStatus(LoanDetails loanDetails)
        {
            try
            {
                employeeRepository.LoanApprovalorRejection(loanDetails);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }*/

        // For Loan Approval or Rejection
        [HttpGet]
        [Route("GetCheckApproval/{id}/{loanAccountNumber}")]
        public IActionResult GetCheckApproval(string id, string loanAccountNumber)
        {
            try
            {
                string status = employeeRepository.CheckApproval(id, loanAccountNumber);
                return Ok(status);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
