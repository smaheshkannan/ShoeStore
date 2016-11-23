using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShoeStore.Models
{
    public class IssueViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string title { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        [Display(Name = "Severity")]
        public string Severity { get; set; }
    }

    public class SeverityViewModel
    {
        public static List<string> Severity;
        static SeverityViewModel()
        {
            Severity = new List<string>();
            foreach( var val in Enum.GetNames(typeof(ShoeStore.Models.Severity)) )
                Severity.Add(val);
        }
    }

}