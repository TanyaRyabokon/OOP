using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab1_OOP
{
    public class Star : AstronomicalBody
    {
        private string type;
        private string composition;
        private float temperature;
        
        public string Type
        {
            get { return type; }
            set
            {
                if (!Validation.rgx.IsMatch(value))
                    throw new ArgumentOutOfRangeException(this.Name + ": Type is not valid");
                else
                    type = value;
            }
        }

        public string Composition
        {
            get { return composition; }
            set { composition = value; }
        }

        public float Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public Star()
        {
            this.Kind = Lab1_OOP.Type.Star;
            AstronomicalBody.AddAstBody();
        }

        public Star(string name, float x, float y, float z, float weight, string type, string composition, float temperature) : base (name,  x, y, z, weight)
        {
            this.Kind = Lab1_OOP.Type.Star;
            this.type = type;
            this.composition = composition;
            this.temperature = temperature;
            AstronomicalBody.AddAstBody();
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nKind: " + this.Kind + "\nLocation: " + this.Representation(X,Y,Z) + "\nWeight: " + this.Weight + "\nType of star: " + this.type + "\nComposition: " + this.composition + "\nTemperature: " + this.temperature + "\n\n";
        }
    }
}
