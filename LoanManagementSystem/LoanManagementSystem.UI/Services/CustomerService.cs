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
    public class CustomerService:ICustomerService
    {
        public void AddCustomer(Customer customer)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/");
                var contentData = new StringContent(JsonConvert.SerializeObject(customer),
                    System.Text.Encoding.UTF8, "application/json"); //convert Item into Json type.
                HttpResponseMessage response = client.PostAsync("api/Customer/AddCustomer", contentData).Result;
            }
        }
        public void ApplyLoan(LoanDetails loandetails)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/");
                var contentData = new StringContent(JsonConvert.SerializeObject(loandetails),
                    System.Text.Encoding.UTF8, "application/json"); //convert Item into Json type.
                HttpResponseMessage response = client.PostAsync("api/Customer/ApplyLoan", contentData).Result;
            }
        }
        public LoanDetails CheckLoanStatus(string CustomerId)
        {
            throw new NotImplementedException();
        }
        public bool IsLoginCustomer(string CustomerId, string CustomerPassword)
        {
            throw new NotImplementedException();
        }
        public void UpdateCustomerById(Customer customer)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/");
                var contentData = new StringContent(JsonConvert.SerializeObject(customer),
                System.Text.Encoding.UTF8, "application/json"); //convert Item into Json type.
                HttpResponseMessage response = client.PutAsync("api/Customer/UpdateCustomer", contentData).Result;
            }
        }
        public Customer SearchCustomerById(string CustomerId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Customer/GetCustomer/" + CustomerId).Result;
                Customer customer = JsonConvert.DeserializeObject<Customer>(response.Content.ReadAsStringAsync().Result);
                return customer;
            }
        }
    }
}
