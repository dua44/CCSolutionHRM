using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class EmployeeWorkExperience
    {
        public int ID { get; set; }
        public int EmployeeId { get; set; }
        public int DesignationId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string CompanyName { get; set; }
        public decimal StartingSalary { get; set; }
        public decimal LastSalary { get; set; }
        public string Comments { get; set; }
        public string ReasonforLeave { get; set; }
        public string ContactNumber { get; set; }

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }
 
    }
}