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

        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeContact> EmployeeContacts { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }
        public DbSet<EmployementStatus> EmployementStatuss { get; set; }
        public DbSet<EmployementType> EmployementTypes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MaritalStatus> MaritalStatuss { get; set; }
        public DbSet<Nationality> Nationalitys { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAttribute> RoleAttributes { get; set; }
        public DbSet<RoleCompany> RoleCompanys { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<RoleUsers> RoleUserss { get; set; }
        public DbSet<Users> Userss { get; set; }
        public DbSet<WorkSite> WorkSites { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}