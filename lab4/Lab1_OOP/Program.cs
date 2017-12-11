using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab1_OOP
{
    //Рефакторинг
    //1.В вашей программе нет очень длинных методов/функций код занимает не  больше 2-3 десятков строк 
    //2.Нет дублирования кода
    //3.Генерализация типов
    //4.Инкапсуляция полей классов
    //5.Выделение интерфейса 
    class Program
    {
        public static WeakReference WR()
        {
            return new WeakReference(new AstronomicalBody("Kepler", 345.45F, 23.5F, 321.5F, 2.5900000000000000F));
        }
        delegate void del(AstronomicalBody i);
        static void Main(string[] args)
        {
            try
            {
                //create a star
                Star star = new Star("Sun", 334.45567F, 345.5F, 456.2F, 2354436456.234435F, "Star", "He", 34546456.24F);
                
                //planet
                AstronomicalBody astBody = new AstronomicalBody("Kepler", 345.45F, 23.5F, 321.5F, 2.5900000000000000F);

                //asteroids
                AstronomicalBody ceres = new AstronomicalBody("Ceres", 3345.4F, 789.4F, 347.83F, 7.3600000000000000F);
                AstronomicalBody fortuna = new AstronomicalBody("Fortuna", 795.67F, 41.3F, 78.4F, 9.3400000000000000F);

                Console.WriteLine("Start of the test: {0}", GC.GetTotalMemory(true));

                //create new system
                PlanetarySystem<AstronomicalBody> system = new PlanetarySystem<AstronomicalBody>(star);

                del Add = x => system.Add(x);

                //system forming 
                Add(astBody);
                Add(ceres);
                Add(fortuna);

                Console.WriteLine("Сreating an object: {0}", GC.GetTotalMemory(true));

                GC.Collect();
                GC.WaitForPendingFinalizers();

                WeakReference wr = WR();
                Console.WriteLine("Is first object alive : " + wr.IsAlive.ToString());

                GC.Collect(2, GCCollectionMode.Forced);

                Console.WriteLine("Is first object alive : " + wr.IsAlive.ToString());

                system.Dispose();
                Console.WriteLine("System does not exist: " + (system.astBodies == null));// Ccилка  на список null 
                Console.WriteLine(system.ToString());


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
