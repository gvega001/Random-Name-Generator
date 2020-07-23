using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace siscloudbookService.DataObjects
{
    public class Enrollment : EntityData
    {
        public string Course_id { get; set; }
        //[ForeignKey("Course_id")]
        public string Root_account { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string User_id { get; set; }
       // [ForeignKey("User_id")]
        public string User_integration_id { get; set; }
      // [ForeignKey("User_integration_id")]
        public string Role { get; set; }
        public string Role_id { get; set; }
        public string Section_id { get; set; }
        //[ForeignKey("Section_id")]
        public bool Active { get; set; }
        public bool EnrollmentDeleted { get; set; }
        public bool EnrollmentCompleted { get; set; }
        public string Associated_user_id { get; set; }
        public Boolean Limit_section_privileges { get; set; }

    }
}