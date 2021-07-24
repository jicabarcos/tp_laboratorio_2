using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InvalidCompanionNameException : Exception
    {
        public InvalidCompanionNameException(string message) : base(message)
        {
        }

        public InvalidCompanionNameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
