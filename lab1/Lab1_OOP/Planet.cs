using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab1_OOP
{
    public class Planet: AstronomicalBody
    {
        protected string adjective;
        private int satellites;
        private float rotationPeriod;

        
        public virtual string Adjective
        {
            get { return adjective; }
            set
            {
                if (!Validation.rgx.IsMatch(value))
                    throw new ArgumentOutOfRangeException(this.Name + ": Adjective is not valid");
                else
                    adjective = value;
            }
        }

        public int Satellites
        {
            get { return satellites; }
            set { satellites = value; }
        }

        public float RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }
        public Planet()
        {
            this.Kind = "Planet";
            AstronomicalBody.AddAstBody();
        }

        public Planet(string name,  float location, float weight, string adjective, int satellites, float rotationPeriod) : base (name, location, weight)
        {
            this.Kind = "Planet";
            this.adjective = adjective;
            this.satellites = satellites;
            this.rotationPeriod = rotationPeriod;
            AstronomicalBody.AddAstBody();
        }
        public override string ToString()
        {
            return "Name: " + this.Name + "\nAdjective: "+ this.adjective + "\nKind: " +  this.Kind + "\nLocation: " + this.Location + "\nWeight: " + this.Weight + "\nSatellites: " + this.satellites + "\nRotation Period: " + this.rotationPeriod + "\n\n";
        }
    }
}
