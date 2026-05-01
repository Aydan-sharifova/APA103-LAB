using Kurs.Models;
using System;
using System.Collections.Generic;

namespace Kurs.Actions
{
    public static class Register
    {
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();

        public static void RegisterStudent(Student student)
        {
            students.Add(student);

            Console.WriteLine("Registered students:");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} ");
            }

            Console.WriteLine();
        }
        public static void RegisterTeacher(Teacher teacher)
        {
            teachers.Add(teacher);

            Console.WriteLine("Registered teachers:");
            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} ");
            }

            Console.WriteLine();
        }

        
            public static void Login(string savedUsername, string savedPassword)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (username == savedUsername && password == savedPassword)
                {
                    Console.WriteLine("Xoş gəldin.");
                }
                else
                {
                    Console.WriteLine("Məlumatlar yanlışdır.");
                }
            }
        }
    }
