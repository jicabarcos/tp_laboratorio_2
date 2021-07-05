using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{// HILOS PARA HACER ESTO AL CREAR UN COMPANION EN EL FORMS
    static public class NameGenerator<T> where T : Companion
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
        
        static string CompanionName(T comp)
        {
            if(comp is Cook)
            {
                cookCount++;
                comp.Nombre += cookCount.ToString();
            }
            else if(comp is Housekeeper)
            {
                housekeeperCount++;
                comp.Nombre += housekeeperCount.ToString();
            }
            else
            {
                managerCount++;
                comp.Nombre += managerCount.ToString();
            }
            return (typeof(T))comp.Nombre;
        }
    }
}
