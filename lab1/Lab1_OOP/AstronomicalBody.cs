using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab1_OOP
{
    public class AstronomicalBody
    {
        private static int countAstBodies = 0;

        protected string name;
        private string kind;
        private float location;
        private float weight;
        public static int age = 0;
        static Random gen = new Random();
        public string Name
        {
            get { return name; }
            set
            {
                if (!Validation.rgx.IsMatch(value))
                    throw new ArgumentOutOfRangeException(this.Name + ": Name is not valid");
                else
                    name = value;
            }
        }
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        public float Location
        {
            get { return location; }
            set { location = value; }
        }
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        


        public AstronomicalBody()
        { }

        static AstronomicalBody()
        {
            age = gen.Next(1000000);
            Console.WriteLine("This is static constructor!"); }

        public AstronomicalBody (string name, float location, float weight)
        {
            this.name = name;
            this.kind = "Astronomical Body";
            this.location = location;
            this.weight = weight;
        }

        public static int AddAstBody()
        {
            return countAstBodies++;
        }

        public virtual int Count
        {
            get { return countAstBodies; }
        }

        public virtual void Title()
        {
            Console.WriteLine($"It's {this.Name} the {this.Kind}");
        }


        public override string ToString()
        {
            return "Name: " + this.name  + "\nKind: " + this.kind + "\nLocation: " + this.location + "\nWeight: " + this.weight + "\n\n";
        }
    }
}
