using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBodys.Models
{
    public class WaterFall : WaterBody
    {
        public double Height { get; set; }

        public WaterFall(int id, string name, double deepth, double height)
            : base(id, name, deepth)
        {
            Height = height;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Şəlalə - Ad: {Name}, Dərinlik: {Deepth}, Hündürlük: {Height}");
        }
    }
}
