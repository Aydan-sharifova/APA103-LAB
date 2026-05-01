using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_task.Models
{
    class Manager : Employee
    {
        public double Salary { get; set; }
        public Manager(int id,string firstname, string lastname, int phoneNumber, string address, string email, double salary)
                : base(id, firstname, lastname, phoneNumber, address, email)
        {
            Salary = salary;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Maaş: {Salary}");
        }
    }
}
