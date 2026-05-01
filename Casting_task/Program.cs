using Casting_task.Models;

namespace Casting_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            //  Developers
            employees.Add(new Developer(001,"Aydan", "Sharifova", 0501111111, "Baku", "aydan1@gmail.com", 3, "Frontend"));
            employees.Add(new Developer(002,"Kamran", "Aliyev", 0502222222, "Ganja", "kamran@gmail.com", 5, "Backend"));
            employees.Add(new Developer(003,"Leyla", "Hasanova", 0503333333, "Sumqayit", "leyla@gmail.com", 2, "Fullstack"));

            //  Managers
            employees.Add(new Manager(101,"Murad", "Mammadov", 0504444444, "Baku", "murad@gmail.com", 2000));
            employees.Add(new Manager(102,"Nigar", "Quliyeva", 0505555555, "Shaki", "nigar@gmail.com", 2500));

            //  SMM Managers
            employees.Add(new SMMManager(201,"Sabina", "Rzayeva", 0506666666, "Baku", "sabina@gmail.com", 8));
            employees.Add(new SMMManager(202,"Aysel", "Karimova", 0507777777, "Mingachevir", "aysel@gmail.com", 9));
            employees.Add(new SMMManager(203,"Laman", "Ismayilova", 0508888888, "Barda", "laman@gmail.com", 7));
            employees.Add(new SMMManager(204,"Gunel", "Huseynova", 0509999999, "Quba", "gunel@gmail.com", 6));

            //  Salers
            employees.Add(new Saler(301,"Rashad", "Aliyev", 0511111111, "Baku", "rashad@gmail.com", 1200, 200));
            employees.Add(new Saler(302,"Elvin", "Mammadli", 0512222222, "Ganja", "elvin@gmail.com", 1300, 250));
            employees.Add(new Saler(303,"Turan", "Hasanov", 0513333333, "Lankaran", "turan@gmail.com", 1250, 220));
            employees.Add(new Saler(304,"Kanan", "Jafarov", 0514444444, "Shusha", "kanan@gmail.com", 1400, 300));
            employees.Add(new Saler(305,"Orxan", "Rahimov", 051555555, "Nakhchivan", "orxan@gmail.com", 1350, 270));
            employees.Add(new Saler(306,"Fidan", "Asadova", 0516666666, "Baku", "fidan@gmail.com", 1280, 210));
           
         
          foreach (Employee emp in employees)
           {
               if (emp is Saler saler)
                {
                    saler.Salary += saler.Salary * 0.10;
                }
            }

           
            int smmCount = 0;
            foreach (Employee emp in employees)
            {
                if (emp is SMMManager smm)
                {
                    smmCount++;
                    if (smmCount == 2)
                    {
                        smm.WorkHours -= 3;
                        break;
                    }
                }
            }

            
            foreach (Employee emp in employees)
            {
                if (emp is Developer developer)
                {
                    developer.ProjectCount += 2;
                }
            }

            
            foreach (Employee emp in employees)
            {
                if (emp is Manager manager)
                {
                    manager.Salary += manager.Salary * 0.30;
                }
            }

            
            foreach (Employee emp in employees)
            {
                emp.ShowInfo();
            }
        }
    }
}
        