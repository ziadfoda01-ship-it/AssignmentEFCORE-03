using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentEFCORE_03
{
    public class Student
    {
        public int StudentId { get; set; }
        public string SName { get; set; }
        public ICollection<StudentCourses> studentCourses = new HashSet<StudentCourses>();
    }
}
