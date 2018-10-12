using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class EmployeeSalary
    {
        public int ID { get; set; }
        
        public int EmployeeId { get; set; }
        
        public int SalaryTypeId { get; set; }        
        public string PeronsalNumber { get; set; }
        public decimal GratuityAmount { get; set; }
        public DateTime GratuityStartDate { get; set; }
        public DateTime GratuityEndDate { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal GrossSalary { get; set; }
        
        public int CompanyBankId { get; set; }
        
        public int CurrencyId { get; set; }

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual SalaryType SalaryType { get; set; }
        public virtual CompanyBank CompanyBank { get; set; }
        public virtual Currency Currency { get; set; }
    }
}