using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    class Program
    {
        public static WeakReference WR()
        {
            return new WeakReference(new Ceres());
        }
        static void Main(string[] args)
        {
            try
            {
                //planet
                AstronomicalBody astBody = new AstronomicalBody("Kepler", 345.45F, 23.5F, 321.5F, 2.5900000000000000F);

                //asteroids
                AstronomicalBody ceres = new AstronomicalBody("Ceres", 3345.4F, 789.4F, 347.83F, 7.3600000000000000F);
                AstronomicalBody fortuna = new AstronomicalBody("Fortuna", 795.67F, 41.3F, 78.4F, 9.3400000000000000F);

                //space ship
                SpaceShip ship = new SpaceShip("Millenium falcon", 23.5645F, 19945645.45F, astBody);

                //asteroid belt
                AsteroidBelt sp = new AsteroidBelt(ship);

                ship.Hit();


                Console.ReadKey();
            }
            catch (InvalidAstBodyNameException e)
            {
                Console.WriteLine("Custom exception " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
