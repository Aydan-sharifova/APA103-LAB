using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_task.Models
{
    class SMMManager: Employee
    {
        public int WorkHours { get; set; }
        public SMMManager(int id,string firstname, string lastname, int phoneNumber, string address, string email, int workHours)
                : base(id, firstname, lastname, phoneNumber, address, email)
        {
            WorkHours = workHours;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"İş saatı: {WorkHours}");
        }
    }
}
