using System.Collections.Generic;
// using System.DateTime;
using System;

namespace UniversityRegistrar.Models
{
    public class Student
    {
        public Student()
        {
            this.JoinEntities = new HashSet<CourseStudent>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateEnrollment { get; set; }

        public virtual ICollection<CourseStudent> JoinEntities { get;}
    }
}