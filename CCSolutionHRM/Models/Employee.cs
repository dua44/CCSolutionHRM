using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class Employee
    {
        public int ID { get; set; }
        
        public int CompanyId { get; set; }
        
        public string Title { get; set; }
        
        public string Name { get; set; }
        
        public int EmploymentTypeId { get; set; }
        
        public int EmploymentStatusId { get; set; }
        
        public int WorkSiteId { get; set; }
        
        public int DesignationId { get; set; }
        
        public int ReligionId { get; set; }
        
        public int MaritalStatusId { get; set; }
        
        public int DepartmentId { get; set; }
        
        public int BloodGroupId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM, yyyy}")]
        public DateTime DateOfBirth { get; set; }
        
        public int GenderId { get; set; }
        
        public int NationalityId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM, yyyy hh:mm:ss}")]
        public DateTime HireDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM, yyyy hh:mm:ss}")]
        public string NationalIdentificationID { get; set; }
        public DateTime NationalIdentificationExpiryDate { get; set; }
        public DateTime ResignationDate { get; set; }

        public bool Delete { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM, yyyy hh:mm:ss}")]
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual Company Company { get; set; }
        public virtual EmployementType Document { get; set; }
        public virtual EmployementStatus EmployementStatus { get; set; }
        public virtual WorkSite WorkSite { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Department Department { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
    }
}