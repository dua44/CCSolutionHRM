using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class EmployeeReference
    {
        public int ID { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DialingCode { get; set; }
        public string PhoneNumber { get; set; }
        public int RelationId { get; set; }
        public string Address { get; set; }
        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual Relation Relation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Nationality Nationality { get; set; }
    }
}