using System.Collections.Generic;

namespace IdentityPractice.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public List<Enrollment>? Enrollments { get; set; }
    }
}
