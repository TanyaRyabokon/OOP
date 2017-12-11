using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1_OOP
{
    class InvalidAstBodyNameException : System.Exception
    {
        public InvalidAstBodyNameException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
