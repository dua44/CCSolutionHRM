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
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int DocumentId { get; set; }
        [Required]
        public string DocumentNumber { get; set; }
        [Required]
        public int NationalityId { get; set; }
        [Required]
        public string IssuancePlace { get; set; }
        public string Comments { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }        
        public string SoftCopyPath { get; set; }

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Document Document { get; set; }
        public virtual Nationality Nationality { get; set; }
    }
}