using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_task.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }



        public Employee(int id,string firstname, string lastname, int phoneNumber, string address, string email)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
        }

    public virtual void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Ad: {FirstName}");
            Console.WriteLine($"Soyad: {LastName}");
            Console.WriteLine($"Telefon: {PhoneNumber}");
            Console.WriteLine($"Ünvan: {Address}");
            Console.WriteLine($"Email: {Email}");
        }
    } }
