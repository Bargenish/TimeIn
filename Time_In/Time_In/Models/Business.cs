using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Time_In.Models
{
    public class Business
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Google User")]
        [StringLength(100)]
        public string googleUser { get; set; }

        [Required]
        [Display(Name = "Business Name")]
        public string businessName { get; set; }

        [Display(Name = "Demand Approval")]
        public Boolean demandApproval { get; set; }
        
        [Display(Name = "Begining Hour")]
        public DateTime beginHour { get; set; }

        [Display(Name = "Ending Hour")]
        public DateTime endHour { get; set; }

    }
}