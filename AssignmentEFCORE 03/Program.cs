namespace AssignmentEFCORE_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var Context = new AbbDb1context();
            var Student = new Student { SName = "Ahmed Ail" };
            Context.students.Add(Student);
            Context.SaveChanges();
            Console.WriteLine("Student added Successfully");
            var NewStudent = new Student { SName = "Mostafa Mohamed " };
            Context.students.Add(NewStudent);
            Context.SaveChanges();
            Console.WriteLine($"[Create]Student Added Successfully Whth Id :{NewStudent.SName}");
            Console.WriteLine($"\n-- [Read] All Student List");
            var StudentList = Context.students.ToList();
            foreach (var item in StudentList)
            {
                Console.WriteLine($"Id {S}");
            }
        }
    }
}
