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
    // Employee Service for Connecting UI to API using HTTPCLient
    public class EmployeeService : IEmployeeService
    {
        /*public string CheckCriteria(string CustomerId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Employee/GetCustomerEligibility/" + CustomerId).Result;
                var status = JsonConvert.DeserializeObject<string>(response.Content.ReadAsStringAsync().Result);
                return status;
            }
        }*/


        public void DeleteCustomerById(string LoanAccNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/");
                HttpResponseMessage response = client.DeleteAsync("api/Employee/DeleteCustomer/" + LoanAccNumber).Result;

            }
        }

        public bool IsLoginBankEmployee(string EmpId, string EmpPassword)
        {
            throw new NotImplementedException();
        }
        /*public void LoanApprovalorRejection(LoanDetails loanDetails)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/");
                var contentData = new StringContent(JsonConvert.SerializeObject(loanDetails),
                System.Text.Encoding.UTF8, "application/json"); //convert Item into Json type.
                HttpResponseMessage response = client.PutAsync("api/Customer/UpdateCustomer", contentData).Result;
            }
        }*/

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
        public LoanDetails SearchCustomerByLoanAccNumber(string LoanAccNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Employee/GetCustomer/" + LoanAccNumber).Result;
                LoanDetails details = JsonConvert.DeserializeObject<LoanDetails>(response.Content.ReadAsStringAsync().Result);
                return details;
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

        public List<PendingCustomers> ViewPendingCustomers()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Employee/ViewPendingCustomers").Result;
                List<PendingCustomers> pendingcustomers = JsonConvert.DeserializeObject<List<PendingCustomers>>(response.Content.ReadAsStringAsync().Result);
                return pendingcustomers;
            }
        }
        public List<PendingCustomers> ViewRejectedCustomers()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Employee/ViewRejectedCustomers").Result;
                List<PendingCustomers> pendingcustomers = JsonConvert.DeserializeObject<List<PendingCustomers>>(response.Content.ReadAsStringAsync().Result);
                return pendingcustomers;
            }
        }
        public string CheckApproval(string CustomerId, string LoanAccNumber)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:25813/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Employee/GetCheckApproval/" + CustomerId + "/" + LoanAccNumber).Result;
                string status = JsonConvert.DeserializeObject<string>(response.Content.ReadAsStringAsync().Result);
                return status;
            }
        }
    }
}
