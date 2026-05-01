using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Actions
{
    internal class LoginSystem
    {
        private Teacher[] teachers;
        private Student[] students;

        public LoginSystem(Teacher[] teachers, Student[] students)
        {
            this.teachers = teachers;
            this.students = students;
        }

        public bool TeacherLogin(string username, string password)
        {
            foreach (Teacher teacher in teachers)
            {
                if (teacher != null &&
                    teacher.Username == username &&
                    teacher.Password == password)
                {
                    Console.WriteLine($"Teacher login successful: {teacher.GetName()}");
                    return true;
                }
            }

            Console.WriteLine("Teacher username or password is incorrect.");
            return false;
        }

        public bool StudentLogin(string username, string password)
        {
            foreach (Student student in students)
            {
                if (student != null &&
                    student.Username == username &&
                    student.Password == password)
                {
                    Console.WriteLine($"Student login successful: {student.GetName()}");
                    return true;
                }
            }

            Console.WriteLine("Student username or password is incorrect.");
            return false;
        }
    }
}
