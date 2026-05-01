using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Models
{
   public class Teacher:Base

    {
        public string DepartmentName { get; set; }
        public string Subject { get; set; }

        public string Teachers()
        {
            return FirstName + " " + LastName + " - " + DepartmentName + " - " + Subject;
        }
        public Teacher()
        {
            
        }

        public Teacher(string username, string firstname, string lastname, string email)
        {
            UserName = username;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
        }

        public string GetTeacher()
        {
            return FirstName + " " + LastName + " - " + DepartmentName + " - " + Subject;
        }
    }


}
