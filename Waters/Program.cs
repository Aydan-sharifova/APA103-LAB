using WaterBodys.Models;

namespace Waters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<WaterBody> waterBodies = new List<WaterBody>()
            {
                new Ocean(101,"Sakit Okean", 11000, true),
                new Ocean(102,"Atlantik Okean", 8500, true),
                new Ocean(103,"Hind Okeanı", 7800, false),
                new Ocean(104,"Arktika Okeanı", 5400, false),
                new Ocean(105,"Cənub Okeanı", 7200, true),

                new Sea(201,"Xəzər Dənizi", 1025, 12),
                new Sea(202,"Qara Dəniz", 2212, 18),
                new Sea(203,"Aralıq Dənizi", 1500, 38),
                new Sea(204,"Qırmızı Dəniz", 3000, 40),

                new River(301,"Kür", 12, 6.5),
                new River(301,"Araz", 10, 5.8),
                new River(301,"Volqa", 20, 7.2),

                new WaterFall(401,"Yeddi Gözəl", 5, 30),
                new WaterFall(402,"Afurca", 7, 45)
            };


            foreach (var item in waterBodies)
            {
                if (item is River river && river.Name == "Kür")
                {
                    river.Name = "Kür Çayı";
                    break;
                }
            }


            foreach (var item in waterBodies)
            {
                if (item is Ocean ocean && ocean.Name == "Atlantik Okean")
                {
                    ocean.Deepth += 500;
                    break;
                }
            }


            foreach (var item in waterBodies)
            {
                if (item is Sea sea)
                {
                    sea.SaltLevel = sea.SaltLevel * 0.85;
                }
            }


            int waterfallCount = 0;
            foreach (var item in waterBodies)
            {
                if (item is WaterFall waterfall)
                {
                    waterfallCount++;
                    if (waterfallCount == 2)
                    {
                        waterfall.Height += 12;
                    }
                }
            }


            Console.WriteLine("Su hövzələri haqqında məlumatlar:\n");
            foreach (var item in waterBodies)
            {
                item.GetInfo();
            }
        }
    }
}
    

