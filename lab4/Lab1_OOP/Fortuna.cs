using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    class Fortuna : Asteroid, IDisposable
    {
        // Using "Clean code" rule 
        // Замена "волшебных чисел" именоваными константами
        private const int MIN_POWER = 2000;
        public override void Collapse(SpaceShip e, HitEventArgs hargs)
        {
            Console.WriteLine("Fortuna hit the " + e.Name);
            if (hargs.Power > MIN_POWER && hargs.isBodySmaller)
            {
                Console.WriteLine(e.Name + " is damaged");
            }
            else
            {
                Console.WriteLine("Hited! Object intact");
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
