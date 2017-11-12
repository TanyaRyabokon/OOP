using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AstronomicalBody astBody = new AstronomicalBody("4 Vesta", 345.45F, 2.5900000000000000F);
                Planet earth = new Planet("Earth", 2342.35F, 0.000023F, "-", 1, 0.997F);
                Star sun = new Star("Sun", 1.346F, 1.988000000000000000F, "G-type main-sequence star", "Hydrogen  Helium  Oxygen  Carbon", 1.570000000F);
                RedGiant aldebaran = new RedGiant("Aldebaran", 23.56564F, 1.5F, "Hydrogen Carbon Titanium", 3910.34F, "new", false);
                GasGiant saturn = new GasGiant("Saturn", 34.245F, 5.680000000000F, "Cronian", 62, 10.55F, true, true);
                Console.WriteLine(astBody.ToString());
                Console.WriteLine(earth.ToString());
                Console.WriteLine(sun.ToString());
                Console.WriteLine(aldebaran.ToString());
                Console.WriteLine(saturn.ToString());
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
