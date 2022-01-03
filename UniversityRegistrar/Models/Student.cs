using System.Collections.Generic;

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
        public string DateEnrollment { get; set; }

        public virtual ICollection<CourseStudent> JoinEntities { get;}
    }
}