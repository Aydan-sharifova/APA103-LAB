using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_task.Models
{
    class Developer : Employee
    {
        public int ProjectCount { get; set; }
        public string Speciality { get; set; }


        public Developer(int id,string firstname, string lastname, int phoneNumber, string address, string email, int projectCount, string speciality)
                : base(id,firstname, lastname, phoneNumber, address, email)
        {
            ProjectCount = projectCount;
            Speciality = speciality;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Layihə sayı: {ProjectCount}");
            Console.WriteLine($"İxtisas: {Speciality}");
        }
    }
}
