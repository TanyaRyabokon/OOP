using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    class AsteroidBelt
    {
        Asteroid[] asteroids;

        public AsteroidBelt(SpaceShip ship)
        {
            asteroids = new Asteroid[2];
            asteroids[0] = new Ceres();
            asteroids[1] = new Fortuna();

            foreach (Asteroid ast in asteroids)
                ship.HitEvent += new HitHandle(ast.Collapse);
        }
    }
}
