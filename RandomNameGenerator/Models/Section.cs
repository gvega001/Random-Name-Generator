using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RandomNameGenerator.Models
{
    public class Section 
    {
        public string Section_id { get; set; }
        public string Course_id { get; set; }
      // [ForeignKey("Course_id")]
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool SectionDeleted { get; set; }
        public string Integration_id { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }


    }
}