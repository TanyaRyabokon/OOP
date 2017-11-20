using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    class Fortuna : Asteroid
    {
        public override void Collapse(SpaceShip e, HitEventArgs hargs)
        {
            Console.WriteLine("Fortuna hit the " + e.Name);
            if (hargs.Power > 2000 && hargs.isBodySmaller)
            {
                Console.WriteLine(e.Name + " is damaged");
            }
            else
            {
                Console.WriteLine("Hited! Object intact");
            }
        }
    }
}
