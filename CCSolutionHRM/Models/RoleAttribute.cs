using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CCSolutionHRM.Models
{
    public class RoleAttribute
    {
        public int ID { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int AttributeId { get; set; }
        public bool Delete { get; set; }
        public bool IgnoreMenu { get; set; }
        public bool IgnoreClient { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreationIP { get; set; }
        public int CreationBy { get; set; }
        public DateTime UpdationDate { get; set; }
        public string UpdationIP { get; set; }
        public int UpdationBy { get; set; }
    }
}