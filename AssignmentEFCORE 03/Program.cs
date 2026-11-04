//using Microsoft.EntityFrameworkCore;

//namespace AssignmentEFCORE_03
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            using var Context = new AbbDb1context();
//            var Student = new Student { SName = "Ahmed Ail" };
//            Context.students.Add(Student);
//            Context.SaveChanges();
//            Console.WriteLine("Student added Successfully");
//            var NewStudent = new Student { SName = "Mostafa Mohamed " };
//            Context.students.Add(NewStudent);
//            Context.SaveChanges();
//            Console.WriteLine($"[Create]Student Added Successfully Whth Id :{NewStudent.SName}");
//            Console.WriteLine($"\n-- [Read] All Student List");
//            var StudentList = Context.students.ToList();
//            foreach (var item in StudentList)
//            {
//                Console.WriteLine($"Id {item.StudentId} Name {item.SName}");
//            }
//            Console.WriteLine("\n--- [Query] Searching for a Course ---");
//            var targetCourse = Context.courses.FirstOrDefault(c => c.CoursesId == 1);
//            if (targetCourse != null)
//            {
//                Console.WriteLine($"Found Course: {targetCourse.CName}, Price: ");
//            }
//            else
//            {
//                Console.WriteLine("Course not found!");
//            }


//            // 4. Update: تعديل بيانات كورس أو طالب
//            Console.WriteLine("\n--- [Update] Updating Student Name ---");
//            var studentToUpdate = Context.students.FirstOrDefault(s => s.StudentId == NewStudent.StudentId);
//            if (studentToUpdate != null)
//            {
//                studentToUpdate.SName = "Mostafa Updated";
//                Context.SaveChanges();
//                Console.WriteLine("Student name updated successfully.");
//            }
//        }
//    }
//}
