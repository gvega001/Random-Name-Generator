using System;


namespace siscloudbookService.DataObjects
{
    public class Enrollment 
    {
        public string Course_id { get;  }
        public string Root_account { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string User_id { get; }
        public string User_integration_id { get; set; }
        public string Role { get; set; }
        public string Role_id { get; set; }
        public string Section_id { get; set; }
        public bool Active { get; set; }
        public bool EnrollmentDeleted { get; set; }
        public bool EnrollmentCompleted { get; set; }
        public string Associated_user_id { get; set; }
        public Boolean Limit_section_privileges { get; set; }

    }
}