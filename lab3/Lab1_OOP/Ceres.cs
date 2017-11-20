using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    class Ceres : Asteroid
    {
        public override void Collapse(SpaceShip e, HitEventArgs hargs)
        {
            Console.WriteLine("Ceres hit the ship " + e.Name);
            if (hargs.Power > 10000 && hargs.isBodySmaller)
            {
                Console.WriteLine(e.Name + " is damaged");
            }
            else
            {
                Console.WriteLine("Hited! Object intact ");
            }
        }
    }
}
