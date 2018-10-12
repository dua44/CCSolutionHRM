using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class EmployeeDeduction
    {
        public int ID { get; set; }
        
        public int EmployeeId { get; set; }
        
        public int DeductionTypeId { get; set; }
        public string Comments { get; set; }
        public decimal Amount { get; set; }
        public DateTime DeductionDate { get; set; }

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual DeductionType DeductionType { get; set; }
    }
}