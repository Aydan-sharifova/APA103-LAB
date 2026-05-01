using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBodys.Models
{
    public class Ocean: WaterBody
    {
        public bool HasCoralReefs { get; set; }

        public Ocean(int id,string name, double deepth, bool hasCoralReefs)
            : base(id,name, deepth)
        {
            HasCoralReefs = hasCoralReefs;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Okean - Ad: {Name}, Dərinlik: {Deepth}, Mərcan rifləri: {HasCoralReefs}");
        }
    }
}
