using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WpfApplication1
{
    class InvalidAstBodyNameException : Exception
    {
        public InvalidAstBodyNameException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
