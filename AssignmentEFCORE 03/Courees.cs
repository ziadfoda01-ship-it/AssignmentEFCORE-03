using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentEFCORE_03
{
    public class Courses
    {
        public int CoursesId { get; set; }
        public string CName { get; set; }
        public ICollection<StudentCourses> StudentCourses = new HashSet<StudentCourses>();
       
    }
}
