using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab1_OOP
{
    class Validation
    {

        static public Regex rgx = new Regex(@"^[A-Z]{1}[a-z]{1,30}$");
        private Validation() { }
    }
}
