using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    class RedGiant : Star
    {
        private string ageCategory;
        private bool instability;

        public string AgeCategory
        {
            get { return ageCategory; }
            set
            {
                StringBuilder ageStr = new StringBuilder(ageCategory);
                ageStr[0] = Char.ToUpper(ageStr[0]);
                if (ageCategory.Equals("New") || ageCategory.Equals("Old"))
                    ageCategory = value;
                else
                    throw new ArgumentOutOfRangeException(this.Name + ": Age Category is not valid");
            }
        }

        public bool Instability
        {
            get { return instability; }
            set { instability = value; }
        }

        public RedGiant () { this.Kind = Lab1_OOP.Type.RedGiant; }

        public RedGiant(string name, float x, float y, float z, float weight,  string composition, float temperature, string ageCategory, bool instability) : base (name, x, y, z, weight, "RedGiant", composition, temperature)
        {
            this.ageCategory = ageCategory;
            this.instability = instability;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nKind: " + this.Kind + "\nLocation: " + this.Representation(X, Y, Z) + "\nWeight: " + this.Weight + "\nType of star: " + this.Type + "\nComposition: " + this.Composition + "\nTemperature: " + this.Temperature + "\nAge Category: " + this.ageCategory + "\nInstability: " + this.instability + "\n\n";
        }
    }
}
