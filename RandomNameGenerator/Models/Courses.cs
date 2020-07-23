using System;


namespace RandomNameGenerator.Models
{
    public class Courses
    {
        public Guid courseId{ get; private set; } = Guid.NewGuid();
        public string Short_name { get; set; }
        public string Long_name { get; set; }
        public string Account_id { get; set; }

        public string Term_id { get; set; }
        public bool Active { get; set; }
        public bool CourseDeleted { get; set; }
        public bool Completed { get; set; }
        public string Integration_id { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public Enum Course_format { get; set; }
        public string Blueprint_course_id { get; set; }

    }
}
