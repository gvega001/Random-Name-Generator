using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace siscloudbookService.DataObjects
{
    public class Group : EntityData
    {
        public string Group_id { get; set; }
        public string Group_category_id { get; set; }
       //[ForeignKey("Groupd_category_id")]
        public string Account_id { get; set; }
       // [ForeignKey("Account_id")]
        public string Course_id { get; set; }
       // [ForeignKey("Course_id")]
        public string Name { get; set; }
        public bool Available { get; set; }
        public bool GroupDeleted { get; set; }
        
    }
}