using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InvalidAccessLevelException : Exception
    {
        public InvalidAccessLevelException(string message) : base(message)
        {
        }

        public InvalidAccessLevelException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
