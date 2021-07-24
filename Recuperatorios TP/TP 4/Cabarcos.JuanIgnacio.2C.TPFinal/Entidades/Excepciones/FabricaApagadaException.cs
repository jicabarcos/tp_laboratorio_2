using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FabricaApagadaException : Exception
    {
        public FabricaApagadaException(string message) : base(message)
        {
        }

        public FabricaApagadaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
