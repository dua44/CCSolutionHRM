using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class EmployeeQualification
    {
        public int ID { get; set; }
        
        public int EmployeeId { get; set; }
        
        public int QualificationId { get; set; }
        
        public DateTime QualifiactionDate { get; set; }
        
        public string InstituteName { get; set; }
        

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

 
    }
}