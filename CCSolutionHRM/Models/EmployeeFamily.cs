using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class EmployeeFamily
    {
        public int ID { get; set; }
        
        public int EmployeeId { get; set; }
        
        public string Name { get; set; }
        
        public int RelationId { get; set; }
        
        public int GenderId { get; set; }
        
        public int MaritalStatusId { get; set; }
        
        public int QualificationId { get; set; }
        
        public int OccupationId { get; set; }
        
        public int ReligionId { get; set; }
        
        public int BloodGroupId { get; set; }
        
        public int NationalityId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM, yyyy}")]
        public DateTime DateOfBirth { get; set; }
        public string NationalIdentificationID { get; set; }
                
        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual Religion Religion { get; set; }
        public virtual Relation Relation { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Qualification Qualification { get; set; }
        public virtual Occupation Occupation { get; set; }
        public virtual BloodGroup BloodGroup { get; set; }
        public virtual Nationality Nationality { get; set; }
    }
}