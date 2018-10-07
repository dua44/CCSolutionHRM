using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class AllowanceDesignationMapping
    {
        public int ID { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public int DesignationId { get; set; }
        [Required]
        public int EmployementTypeId { get; set; }
        [Required]
        public int AllowanceId { get; set; }
        public decimal Amount { get; set; }

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual EmployementType EmployementType { get; set; }
        public virtual Allownace Allownace { get; set; }
    }
}