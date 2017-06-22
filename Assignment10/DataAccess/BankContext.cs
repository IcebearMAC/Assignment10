using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Assignment10.Models;

namespace Assignment10.DataAccess
{
    public class BankContext : DbContext
    {
        public BankContext() : base("DefaultConnection") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<History> History  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().MapToStoredProcedures();

        }

    }
}