using Login.Actions;
using Login.Models;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teachers = new Teacher[2];
            Student[] students = new Student[2];

            teachers[0] = new Teacher(
                "teacher1",
                "Rasim",
                "Mammadov",
                "IT",
                "Programming",
                new DateTime(1987, 4, 15),
                "Baku",
                "0501112233",
                "rasim@gmail.com",
                "teach123"
            );

            students[0] = new Student(
                "student1",
                "Ayla",
                "Aliyeva",
                "642A",
                new DateTime(2005, 8, 10),
                "Sumqayit",
                "0507778899",
                "ayla@gmail.com",
                "stud123",
                91.2
            );

            students[1] = new Student(
                "murad123",
                "Murad",
                "Karimov",
                "643B",
                new DateTime(2004, 11, 25),
                "Ganja",
                "0558889900",
                "murad@gmail.com",
                "student2",
                79.5


            );

            LoginSystem loginSystem = new LoginSystem(teachers, students);

            Console.WriteLine("=== Teacher Login ===");
            loginSystem.TeacherLogin("teacher1", "teach123");

            Console.WriteLine();

            Console.WriteLine("=== Student Login ===");
            loginSystem.StudentLogin("student1", "stud123");

            Console.WriteLine();

            Console.WriteLine("=== Teacher Info ===");
            Console.WriteLine(teachers[0].GetName());
            Console.WriteLine(teachers[0].GetSubject());
            Console.WriteLine(teachers[0].GetTeacher());
            Console.WriteLine(teachers[0].GetContact());

            Console.WriteLine();

            Console.WriteLine("=== Student Info ===");
            Console.WriteLine(students[0].GetName());
            Console.WriteLine(students[0].GetGroup());
            Console.WriteLine(students[0].GetStudent());
            Console.WriteLine(students[0].GetContact());
        }
    }


}
    }
}
