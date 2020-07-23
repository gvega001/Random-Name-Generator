using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomNameGenerator.Models
{
    public class Term 
    {
        public string Term_id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool TermDeleted { get; set; }
        public string Integration_id { get; set; }
        public string Date_override_enrollement_type { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
    }
}