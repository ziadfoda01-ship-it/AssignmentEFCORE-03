using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AssignmentEFCORE_03
{
    public class StudentCourses
    {
        [ForeignKey(nameof(Student))]
        public int stdId { get; set; }
        public Student student { get; set; } = null!;
        [ForeignKey(nameof(Courses))]
        public int CorId { get; set; }
        public Courses courses { get; set; } = null!;
        public int Grade { get; set; }
    }
}
