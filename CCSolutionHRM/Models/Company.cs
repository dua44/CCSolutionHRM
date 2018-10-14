using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Url { get; set; }
        public int DialingCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

 
    }
}