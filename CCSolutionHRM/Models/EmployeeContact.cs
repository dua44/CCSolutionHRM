using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class EmployeeContact
    {
        public int ID { get; set; }        
        public int EmployeeId { get; set; }        
        public int ContactTypeId { get; set; }
        public string Address { get; set; }        
        public int DialingCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string City { get; set; }
        public int NationalityId { get; set; }
        public string Email { get; set; }

        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }
 


    }
}