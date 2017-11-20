﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab1_OOP
{
    public class AstronomicalBody: ICoordinates<AstronomicalBody>, ICharacteristic<AstronomicalBody>
    {

        //fields

        private static int countAstBodies = 0;

        protected string name;
        private string kind;
        private float location;
        private float weight;
        private float rotation;
        private float diameter;
        private float x = 0;
        private float y = 0;
        private float z = 0;
        public static int age = 0;
        static Random gen = new Random();

        //properties

        public string Name
        {
            get { return name; }
            set
            {
                if (!Validation.rgx.IsMatch(value))
                    throw new InvalidAstBodyNameException("Name is not valid");
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
        public float Rotate
        {
            get { return rotation; }
            set { rotation = value; }
        }
        public float Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public float X
        {
            get { return x; }
            set { x = value;  }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public float Z
        {
            get { return z; }
            set { z = value; }
        }
        //constructors
        public AstronomicalBody()
        { }

        static AstronomicalBody()
        {
            age = gen.Next(1000000);
        }

        public AstronomicalBody (string name, float x, float y, float z, float weight)
        {
            this.Name = name;
            this.kind = "Astronomical Body";
            this.location = location;
            this.weight = weight;
        }

        //methods
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

        //ICharacteristic
        public float Rotation(AstronomicalBody astBody)
        {
            return astBody.Rotate;
        }

        public float Diametr(AstronomicalBody astBody)
        {
            return astBody.Diameter;
        }
        public string CompareCharacteristic(AstronomicalBody astBody)
        {
            if (astBody.Rotate > Rotate && astBody.Diameter > Diameter)
            {
                return "Values of characteristics of " + astBody.Name + " is higher";
            }
            else
            {
                return "Values of characteristics of " + Name + " is higher";
            }
        }

        //ICoordinates
        public string Representation(float x, float y, float z)
        {
            return String.Format("( {0} ; {1}; {2} )", x, y, z);
        }
        public override string ToString()
        {
            return "Name: " + this.name  + "\nKind: " + this.kind + "\nLocation: " + this.location + "\nWeight: " + this.weight + "\n\n";
        }
    }
}
