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
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int DesignationId { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public decimal StartingSalary { get; set; }
        [Required]
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