using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RandomNameGenerator.Models
{
    public class GroupCategory 
    {
        public string Group_category_id { get; set; }
        public string Account_id { get; set; }
       //[ForeignKey("Account_id")]
        public string Course_id { get; set; }
       // [ForeignKey("Course_id")]
        public string Catetory_name { get; set; }
        public bool Active { get; set; }
    }
}