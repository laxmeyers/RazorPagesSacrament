using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace RazorPagesSacrament.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string ConductingLeader { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public string Speaker1 { get; set; }
        public string Speaker2 { get; set; }
        public string Speaker3 { get; set; }

        public string OpeningHymn { get; set; }
        public string ClosingHymn { get; set; }
        public string IntermediateHymn { get; set; }
    }
}
