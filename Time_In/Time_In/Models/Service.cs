using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_In.Models
{
    public class Service
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Service Name")]
        [StringLength(100)]
        public string serviceName { get; set; }

        [Required]
        [Display(Name = "Business ID")]
        public int businessID { get; set; }

        [Required]
        [Display(Name = "Service Length")]
        public DateTime serviceLength { get; set; }
        
    }
}