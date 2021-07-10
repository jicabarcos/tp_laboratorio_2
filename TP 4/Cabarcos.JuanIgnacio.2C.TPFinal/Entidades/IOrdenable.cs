using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IOrdenable
    {
        string OrdenarTareas(List<ETarea> tareas);
    }
}
