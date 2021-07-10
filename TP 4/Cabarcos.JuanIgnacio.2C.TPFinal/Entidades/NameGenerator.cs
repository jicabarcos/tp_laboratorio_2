using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{// HILOS PARA HACER ESTO AL CREAR UN COMPANION EN EL FORMS
    public static class NameGenerator<T> where T : Companion
    {
        static int cookCount;
        static int housekeeperCount;
        static int managerCount;

        static NameGenerator()
        {
            cookCount = 0;
            housekeeperCount = 0;
            managerCount = 0;
        }
        
        public static string CompanionName(T comp)
        {
            if(comp is Cook)
            {
                cookCount++;
                comp.Nombre = $"Mi nombre es C-00{cookCount}";
            }
            else if(comp is Housekeeper)
            {
                housekeeperCount++;
                comp.Nombre = $"Mi nombre es HK-00{housekeeperCount}";
            }
            else
            {
                managerCount++;
                comp.Nombre = $"Mi nombre es M-00{managerCount}";
            }
            return comp.Nombre;
        }
    }
}
