using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    internal class Student
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string GroupNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Score { get; set; }


        public Student(
            string username,
            string firstname,
            string lastname,
            string groupNumber,
            DateTime birthdate,
            string address,
            string phoneNumber,
            string email,
            string password,
            double score)
        {
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            GroupNumber = groupNumber;
            Birthdate = birthdate;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            Score = score;
        }


        public string GetName()
        {
            return $"{Firstname} {Lastname}";
        }

        public string GetGroup()
        {
            return GroupNumber;
        }

        public string GetStudent()
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
