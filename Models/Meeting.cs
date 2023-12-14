using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesSacrament.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Conducting Leader")]
        [StringLength(50, MinimumLength = 1)]
        public string ConductingLeader { get; set; }
        [Display(Name = "Opening Prayer")]
        [StringLength(50, MinimumLength = 1)]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Closing Prayer")]
        [StringLength(50, MinimumLength = 1)]
        public string ClosingPrayer { get; set; }

        [StringLength(50, MinimumLength = 3)]

        public string Topic { get; set; }

        [Display(Name = "Opening Speaker")]
        [StringLength(50, MinimumLength = 1)]
        public string Speaker1 { get; set; }
        [Display(Name = "Intermediate Speaker")]
        [StringLength(50, MinimumLength = 1)]
        public string Speaker2 { get; set; }
        [Display(Name = "Closing Speaker")]
        [StringLength(50, MinimumLength = 1)]
        public string Speaker3 { get; set; }
        [Display(Name = "Opening Hymn")]
        [StringLength(50, MinimumLength = 1)]
        public string OpeningHymn { get; set; }
        [Display(Name = "Closing Hymn")]
        [StringLength(50, MinimumLength = 1)]
        public string ClosingHymn { get; set; }
        [Display(Name = "Intermediate Hymn")]
        [StringLength(50, MinimumLength = 1)]
        public string IntermediateHymn { get; set; }
    }
}
