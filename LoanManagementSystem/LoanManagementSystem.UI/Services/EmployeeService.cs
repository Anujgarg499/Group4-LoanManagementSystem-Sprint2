using LoanManagementSystem.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LoanManagementSystem.UI.Services
{
    public class EmployeeService : IEmployeeService
    {
        public bool CheckCriteria(string CustomerId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerById(string CustomerId, decimal LoanAccNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/");
                HttpResponseMessage response = client.DeleteAsync("api/Employee/DeleteCustomer/" + CustomerId+"?"+LoanAccNumber).Result;

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
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Employee/GetCustomer/" + CustomerId).Result;
                Customer customer = JsonConvert.DeserializeObject<Customer>(response.Content.ReadAsStringAsync().Result);
                return customer;
            }
        }

        public List<Customer> ViewCustomers()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Employee/ViewCustomers").Result;
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(response.Content.ReadAsStringAsync().Result);
                return customers;
            }
        }

        public List<LoanDetails> ViewPendingCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
