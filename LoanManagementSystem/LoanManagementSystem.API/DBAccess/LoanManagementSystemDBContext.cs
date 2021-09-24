using LoanManagementSystem.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystem.API.DBAccess
{
    public class LoanManagementSystemDBContext:DbContext
    {
        public LoanManagementSystemDBContext(DbContextOptions<LoanManagementSystemDBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LoanDetails> LoanDetails { get; set; }
    }
}
