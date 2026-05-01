using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_task.Models
{
    class Saler : Employee
    {
        public double Salary { get; set; }
        public double  Benefit { get; set; }
        public Saler(int id,string firstname, string lastname, int phoneNumber, string address, string email, double salary, double benefit)
               : base(id, firstname, lastname, phoneNumber, address, email)
        {
            Salary = salary;
            Benefit = benefit;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Maaş: {Salary}");
            Console.WriteLine($"Benefit: {Benefit}");
        }
    }
}
