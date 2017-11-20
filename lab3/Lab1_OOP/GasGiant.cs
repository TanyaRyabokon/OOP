using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    public class GasGiant : Planet
    {
        private bool spots;
        private bool rings;

        public override string Adjective
        {
            get
            {
                return $"{name} ({adjective})"; 
            }

        }
        public bool Spots
        {
            get { return spots; }
            set { spots = value; }
        }

        public bool Rings
        {
            get { return rings; }
            set { rings = value; }
        }
        private GasGiant() { this.Kind = Type.GasGiant; AstronomicalBody.AddAstBody(); }

        public GasGiant(string name, float x, float y, float z, float weight, string adjective, int satellites, float rotationPeriod, bool spots, bool rings) : base (name, x, y, z, weight, adjective, satellites, rotationPeriod)
        {
            this.Kind = Type.GasGiant;
            this.spots = spots;
            this.rings = rings;
            AstronomicalBody.AddAstBody();
        }

        override public void Title()
        {
                if (spots)
                    Console.WriteLine($"The {this.Name} have spots");
                else
                    Console.WriteLine($"The {this.Name} doesn't have spots");
        }


        public override string ToString()
        {
            return "Name: " + this.Name + "\nAdjective: " + this.Adjective + "\nKind: " + this.Kind + "\nLocation: " + this.Representation(X, Y, Z) + "\nWeight: " + this.Weight + "\nSatellites: " + this.Satellites + "\nRotation Period: " + this.RotationPeriod + "\nSpots: " + this.spots + "\nRings: " + this.rings + "\n\n";
        }
    }
}
