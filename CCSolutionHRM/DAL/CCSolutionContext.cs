using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CCSolutionHRM.Models;

namespace CCSolutionHRM.DAL
{
    public class CCSolutionContext : DbContext
    {
        public CCSolutionContext() : base("CCSolutionModel")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Nationality> Nationalitys { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Users> Userss { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       
    }
}