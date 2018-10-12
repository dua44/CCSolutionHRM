using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class Menu
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Action { get; set; }
        
        public string Url { get; set; }
        
        public int Sequence { get; set; }
        
        public int ParentId { get; set; }
        
        public bool Viewable { get; set; }
        
        public string MenuClass { get; set; }
        public bool Delete { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }
        
    }
}