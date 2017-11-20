using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    public delegate void HitHandle(SpaceShip e, HitEventArgs hargs);

    public class HitEventArgs : EventArgs
    {
        private float power;
        private bool size;

        public float Power
        {
            get { return power; }
            set { power = value; }
        }

        public bool isBodySmaller
        {
            get { return size; }
            set { size = value; }
        }

        public HitEventArgs(float power, bool size)
        {
            this.power = power;
            this.size = size;
        }

        public HitEventArgs() : this(0, true) { }
    }
}
