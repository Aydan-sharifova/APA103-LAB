using Kurs.Actions;
using Kurs.Models;
using System.Dynamic;
using static Kurs.Actions.Register;


namespace Kurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Models.Student> students = new List<Models.Student>();
            List<Models.Teacher> teachers = new List<Models.Teacher>();

            Teacher teacher1 = new Teacher();
            teacher1.UserName = "ali770";
            teacher1.FirstName = "Ali";
            teacher1.LastName = "Mammadov";
            teacher1.DepartmentName = "IT";
            teacher1.Subject = "Programming";
            teacher1.BirthDate = new DateOnly(1990, 5, 10);
            teacher1.Address = "Baku";
            teacher1.PhoneNumber = "0501112233";
            teacher1.Email = "ali@mail.com";
            teacher1.Password = "12345";
            

            teachers.Add(teacher1);

            Student student1 = new Student();

            student1.UserName = "nadya";
            student1.FirstName = "Aydan";
            student1.LastName = "Sharifova";
            student1.GroupNumber = 221;
            student1.BirthDate = new DateOnly(2006, 3, 3);
            student1.PhoneNumber = "0509998877";
            student1.Score = 95;
            student1.Address = "Baku";
            student1.Email = "aydan@mail.com";
            student1.Password = "12345";


            students.Add(student1);

            string savedUsername = student1.UserName ;
            string savedPassword = "1234";


            Register.RegisterStudent(student1);
            Register.RegisterTeacher(teacher1);

            Register.Login(savedUsername, savedPassword);

        }
    }
}