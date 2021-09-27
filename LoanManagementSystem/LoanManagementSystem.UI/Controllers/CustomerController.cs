using LoanManagementSystem.UI.Models;
using LoanManagementSystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService service)
        {
            this.customerService = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
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
        [HttpGet]
        public IActionResult Apply()
        {
            /*string loanAccNumber = Guid.NewGuid().ToString();
            ViewData["loanAccNumber"] = loanAccNumber;*/
            return View();
        }
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
        [HttpGet]
        public IActionResult Edit(string id)
        {
            Customer customer = customerService.SearchCustomerById(id);
            return View(customer);
        }
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
    }
}
