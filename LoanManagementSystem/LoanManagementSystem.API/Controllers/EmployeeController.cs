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
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository repository)
        {
            this.employeeRepository = repository;
        }
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
        [HttpDelete]
        [Route("DeleteCustomer/{id}/{loanAccountNumber}")]
        public IActionResult DeleteCustomerById(string id, decimal loanAccountNumber)
        {
            try
            {
                employeeRepository.DeleteCustomerById(id, loanAccountNumber);
                return Ok();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
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
    }
}
