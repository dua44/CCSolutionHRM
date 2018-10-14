using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CCSolutionHRM.Models
{
    public class EmployeeDocument
    {
        public int ID { get; set; }
        
        public int EmployeeId { get; set; }
        
        public int DocumentId { get; set; }
        
        public string DocumentNumber { get; set; }
        
        public int NationalityId { get; set; }
        
        public string IssuancePlace { get; set; }
        public string Comments { get; set; }
        
        public DateTime IssueDate { get; set; }
        
        public DateTime ExpiryDate { get; set; }        
        public string SoftCopyPath { get; set; }

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

 
    }
}