using LoanManagementSystem.UI.Models;
using LoanManagementSystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }
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
        public IActionResult DeleteCustomerLoan(string CustomerId, decimal LoanAccNumber)
        {
            try
            {
                employeeService.DeleteCustomerById(CustomerId,LoanAccNumber);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
