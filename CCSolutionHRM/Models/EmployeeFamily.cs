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
        [Required]
        public int EmployeeId { get; set; }        
        [Required]
        public int RelationId { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public int MaritalStatusId { get; set; }
        [Required]
        public int QualificationId { get; set; }
        [Required]
        public int OccupationId { get; set; }
        [Required]
        public int ReligionId { get; set; }
        [Required]
        public int BloodGroupId { get; set; }
        [Required]
        public int NationalityId { get; set; }
        [Required]
        public string Name { get; set; }
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

 
    }
}