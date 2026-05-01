using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WaterBodys.Models
{
    class River : WaterBody
    {
        public double FlowSpeed { get; set; }

        public River(int id,string name, double deepth, double flowSpeed)
           : base(id, name, deepth)
        {
            FlowSpeed = flowSpeed;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Çay - Ad: {Name}, Dərinlik: {Deepth}, Axın sürəti: {FlowSpeed}");
        }
    }
}
