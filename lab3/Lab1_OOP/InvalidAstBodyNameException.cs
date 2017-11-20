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
        public InvalidAstBodyNameException()
        {
        }

        public InvalidAstBodyNameException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public InvalidAstBodyNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAstBodyNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
