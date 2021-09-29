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
    // Customer Controller
    [Route("api/[controller]")]
    [ApiController]
        public class CustomerController : ControllerBase
        {
            private readonly ICustomerRepository customerRepository;

            public CustomerController(ICustomerRepository repository)
            {
                this.customerRepository = repository;
            }

        // For Regestring Customer 
            [HttpPost]
            [Route("AddCustomer")]
            public IActionResult PostCustomer(Customer customer)
            {
                try
                {
                    customerRepository.AddCustomer(customer);
                    return Ok();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        // For Applying Loan By Customer
            [HttpPost]
            [Route("ApplyLoan")]
            public IActionResult PostLoan(LoanDetails loanDetails)
            {
                try
                {
                    customerRepository.ApplyLoan(loanDetails);
                    return Ok();
                }
                catch (Exception ex)
                {

                    return Content(ex.Message);
                }
            }

        // For Checking Loan Status of Customer
            [HttpGet]
            [Route("GetStatus/{id}")]
            public IActionResult GetStatus(string id)
            {
                try
                {
                    List<LoanDetails> loanDetails = customerRepository.CheckLoanStatus(id);
                    return Ok(loanDetails);
                }
                catch (Exception ex)
                {

                    return Content(ex.Message);
                }
            }

        // For Updating Customer By Id
            [HttpPut]
            [Route("UpdateCustomer")]
            public IActionResult PutCustomer(Customer customer)
            {
                try
                {
                    customerRepository.UpdateCustomerById(customer);
                    return Ok();
                }
                catch (Exception ex)
                {

                    return Content(ex.Message);
                }
            }

        // For Searching Customer By Id 
        [HttpGet]
        [Route("GetCustomer/{id}")]
        public IActionResult GetCustomerById(string id)
        {
            try
            {
                Customer customer = customerRepository.SearchCustomerById(id);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}

