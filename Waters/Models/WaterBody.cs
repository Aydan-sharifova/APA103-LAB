using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBodys.Models
{
  public abstract class WaterBody
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Deepth { get; set; }

        public WaterBody(int id ,string name, double deepth)
        {
            Id = id;
            Name = name;
            Deepth = deepth;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Id: {Id}, Ad: {Name}, Dərinlik: {Deepth}");
            Console.WriteLine("----------------------");
        }

    }
}
