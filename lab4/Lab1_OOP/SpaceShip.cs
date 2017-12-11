using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    public class SpaceShip
    {
        public event HitHandle HitEvent;

        protected string name;
        private float weight;
        static AstronomicalBody startLocation;

        static Random gen = new Random();
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public AstronomicalBody Start
        {
            get { return startLocation; }
            set { startLocation = value; }
        }

        public void Hit()
        {
            float power;
            string output;
            HitEventArgs hargs;
            try
            {
                Console.Write("Is asteroid bigger than ship? (y/n) : ");
                output = Console.ReadLine();

                Console.Write("Enter weight of asteriod: ");
                power = float.Parse(Console.ReadLine());
                hargs = new HitEventArgs(power, output.ToLower() == "y");
            }
            catch
            {
                hargs = new HitEventArgs();
            }

            Console.WriteLine("\nShip is in asteroid belt\n{0} hited by asteroid...\n", this.name);
            if (HitEvent != null)
                HitEvent((SpaceShip)this, hargs);

        }

        public SpaceShip()
        { }

        public SpaceShip(string name, float location, float weight, AstronomicalBody start)
        {
            this.Name = name;
            this.Weight = weight;
            this.Start = start;
        }

        // Using "Clean code" rule 
        // Исполнение лишь одной операции в функции
        public virtual void NameYourself()
        {
            if (startLocation == null)
                Console.WriteLine($"It's {this.Name} the Space Ship");
            else
                Console.WriteLine($"It's {this.Name} the Space Ship started from {this.Start.Name}");
        }
        public override string ToString()
        {
            return "Name: " + this.name + "\nWeight: " + this.weight + "\nStart from: " + this.Start.Name + "\n\n";
        }
    }
}
