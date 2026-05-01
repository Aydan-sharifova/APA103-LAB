using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBodys.Models
{
    public class Sea : WaterBody
    {
        public double SaltLevel { get; set; }

        public Sea(int id,string name, double deepth, double saltLevel)
            : base(id, name, deepth)
        {
            SaltLevel = saltLevel;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Dəniz - Ad: {Name}, Dərinlik: {Deepth}, Duzluluq səviyyəsi: {SaltLevel}");
        }
    }
}
