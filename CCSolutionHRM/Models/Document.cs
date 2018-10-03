﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }

        
        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }

        public virtual ICollection<EmployeeDocument> EmployeeDocuments { get; set; }
    }
}