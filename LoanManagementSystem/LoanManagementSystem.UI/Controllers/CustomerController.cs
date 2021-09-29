using LoanManagementSystem.UI.Models;
using LoanManagementSystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Controllers
{
    // Customer Controller
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService service)
        {
            this.customerService = service;
        }

        // For Main Menu Page of Customer
        public IActionResult Index()
        {
            return View();
        }

        // For Regestring Customer
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        // Posting the data filled to the API
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    customerService.AddCustomer(customer);
                    return RedirectToAction("Index");
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
        }

        // For Applying the Loan
        [HttpGet]
        public IActionResult Apply()
        {
            /*string loanAccNumber = Guid.NewGuid().ToString();
            ViewData["loanAccNumber"] = loanAccNumber;*/
            return View();
        }
        // Posting the data to the API
        [HttpPost]
        public IActionResult Apply(LoanDetails loanDetails)
        {
            try
            {
                /*loanDetails.LoanAccNumber = Guid.NewGuid().ToString();
                loanDetails.EmpId = "Admin123";*/
                if (ModelState.IsValid)
                {
                    //loanDetails.EmpId = null;                    
                    customerService.ApplyLoan(loanDetails);
                    return RedirectToAction("Index");
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
        }

        // For Updating the Customer Details
        [HttpGet]
        public IActionResult Edit(string id)
        {
            Customer customer = customerService.SearchCustomerById(id);
            return View(customer);
        }
        // Posting back the Updated data to the Api
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            try
            {                 
                if (ModelState.IsValid)
                {
                    customerService.UpdateCustomerById(customer);
                    return RedirectToAction("Index");
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
        }
        
        // For Checking Loan Status of Customer
        [HttpGet]
        public IActionResult GetStatus(string CustomerId)
        {
            try
            {
                List<LoanDetails> loanDetails = customerService.CheckLoanStatus(CustomerId); 
                return View(loanDetails);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
