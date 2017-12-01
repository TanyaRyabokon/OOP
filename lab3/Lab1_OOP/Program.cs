using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab1_OOP
{
    class Program
    {
        delegate void del(AstronomicalBody i);
        static void Main(string[] args)
        {
            try
            {
                //create a star
                Star star = new Star("Sun", 334.45567F, 345.5F, 456.2F, 2354436456.234435F, "Star", "He", 34546456.24F);
                //create new system
                PlanetarySystem<AstronomicalBody> system = new PlanetarySystem<AstronomicalBody>(star);
                //planet
                AstronomicalBody astBody = new AstronomicalBody("Kepler", 345.45F, 23.5F, 321.5F, 2.5900000000000000F);

                //asteroids
                AstronomicalBody ceres = new AstronomicalBody("Ceres", 3345.4F, 789.4F, 347.83F, 7.3600000000000000F);
                AstronomicalBody fortuna = new AstronomicalBody("Fortuna", 795.67F, 41.3F, 78.4F, 9.3400000000000000F);

                del Add = x => system.Add(x);

                //system forming 
                Add(astBody);
                Add(ceres);
                Add(fortuna);

                //show the new system
                Console.WriteLine("New System forms\n");
                int i = 0;
                while (i < system.Count)
                {
                    Console.WriteLine("{0}\n", system[i]);
                    i++;
                }

                //get the biggest body
                AstronomicalBody biggest = system.getBiggestBody();
                Console.WriteLine("Biggest body in system " + biggest.Name);

                Thread t1 = new Thread
                  (delegate ()
                  {
                      //save to file 
                      Console.WriteLine("\n\nSave to file\n\n");
                      Serialization fileManager = new Serialization();
                      fileManager.WriteToFileFromClass(system.Bodies, @"D:\КПИ\ООП\OOP\lab3\Lab1_OOP\data\out.json");
                      Serialization.XmlSerialization(system);
                      PlanetarySystem<AstronomicalBody> system1 = new PlanetarySystem<AstronomicalBody>(star);
                      Serialization.XmlDeserialization(system1);
                  });
                t1.Start();
                //space ship
                SpaceShip ship = new SpaceShip("Millenium falcon", 23.5645F, 19945645.45F, astBody);

                Console.WriteLine("\nShip {0} started from {1}\n", ship.Name, ship.Start.Name);

                //asteroid belt
                AsteroidBelt sp = new AsteroidBelt(ship);

                Thread.Sleep(2000);

                Console.WriteLine("Ship hit the asteroid belt\n");
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
