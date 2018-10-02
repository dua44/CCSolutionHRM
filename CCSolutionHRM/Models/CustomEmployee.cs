using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class CustomEmployee
    {
        public int ID { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM, yyyy}")]
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public int NationalityId { get; set; }
        public int DialingCode1 { get; set; }
        public string PhoneNumber1 { get; set; }
        public int DialingCode2 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string CurrentAddress { get; set; }
        public string PermenantAddress { get; set; }        
        public bool Delete { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM, yyyy hh:mm:ss}")]
        public DateTime CreationDate { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Company { get; set; }

    }
}