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
        [Required]
        public string Name { get; set; }
        [Required]
        public string Action { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public int Sequence { get; set; }
        [Required]
        public int ParentId { get; set; }
        [Required]
        public bool Viewable { get; set; }
        [Required]
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