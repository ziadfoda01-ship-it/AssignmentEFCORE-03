//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.ChangeTracking;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AssignmentEFCORE_03
//{
//    public class StudentCorsesConfigrition : IEntityTypeConfiguration<StudentCourses>
//    {
//        public void Configure(EntityTypeBuilder<StudentCourses> builder)
//        {
//            builder.HasKey(x => new { x.CorId, x.stdId });
//            builder.HasOne(s => s.student).WithMany(sc => sc.studentCourses).HasForeignKey(x => x.stdId);
//            builder.HasOne(s => s.courses).WithMany(sc => sc.StudentCourses).HasForeignKey(x => x.CorId);
//            builder.HasData(
//                new Courses { CoursesId = 1, CName = "C#"},
//                new Courses { CoursesId = 2 , CName = "OOP"},
//                new Courses { CoursesId = 3 , CName = "SQL database"}

//                );
//            builder.HasData(
//                new Student { SName = "Ail Ahmed" , StudentId = 1 },
//                new Student { SName = "Mona Ahmed", StudentId =2},
//                new Student { SName = "Ahmed Mohamed", StudentId =3}

//                );
//            builder.HasData(
//               new StudentCourses { stdId = 1  , CorId = 1},
//               new StudentCourses { stdId = 2  , CorId = 2},
//               new StudentCourses { stdId = 3  , CorId = 3}

//                );
//        }
//    }
//}
