using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    internal class Teacher
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string DepartmentName { get; set; }
        public string Subject { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Teacher(
            string username,
            string firstname,
            string lastname,
            string departmentName,
            string subject,
            DateTime birthdate,
            string address,
            string phoneNumber,
            string email,
            string password)
        {
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            DepartmentName = departmentName;
            Subject = subject;
            Birthdate = birthdate;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
        }




        public string GetName()
        {
            return $"{Firstname} {Lastname}";
        }

        public string GetSubject()
        {
            return Subject;
        }

        public string GetTeacher()
        {
            return $"Firstname: {Firstname}, Lastname: {Lastname}, Email: {Email}, Username: {Username}";
        }

        public string GetEmail()
        {
            return Email;
        }

        public DateTime GetBirthdate()
        {
            return Birthdate;
        }

        public string GetContact()
        {
            return $"Phone: {PhoneNumber}, Email: {Email}";
        }
    }
}
