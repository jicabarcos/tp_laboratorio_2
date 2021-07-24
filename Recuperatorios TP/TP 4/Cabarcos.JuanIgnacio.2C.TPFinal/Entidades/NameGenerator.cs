using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class NameGenerator<T> where T : Companion
    {
        static int cookCount;
        static int housekeeperCount;
        static int managerCount;

        /// <summary>
        /// Constructor estático de la clase NameGenerator.
        /// </summary>
        static NameGenerator()
        {
            cookCount = 0;
            housekeeperCount = 0;
            managerCount = 0;
        }

        /// <summary>
        /// Establece el nombre del Companion a crear.
        /// </summary>
        /// <param name="comp">Companion que recibirá un nombre.</param>
        /// <returns>Nombre del Companion en cuestión.</returns>
        public static string CompanionName(T comp)
        {
            if(comp is Cook)
            {
                cookCount++;
                comp.Nombre = $"C-00{cookCount}";
            }
            else if(comp is Housekeeper)
            {
                housekeeperCount++;
                comp.Nombre = $"HK-00{housekeeperCount}";
            }
            else
            {
                managerCount++;
                comp.Nombre = $"M-00{managerCount}";
            }
            return comp.Nombre;
        }
    }
}
