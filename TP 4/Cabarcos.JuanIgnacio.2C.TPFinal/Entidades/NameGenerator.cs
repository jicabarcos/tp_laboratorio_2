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

        static NameGenerator()
        {
            cookCount = 0;
            housekeeperCount = 0;
            managerCount = 0;
        }

        public static int CookCount
        {
            set
            {
                NameGenerator<T>.cookCount = value;
            }
        }

        public static int HousekeeperCount
        {
            set
            {
                NameGenerator<T>.housekeeperCount = value;
            }
        }

        public static int ManagerCount
        {
            set
            {
                NameGenerator<T>.managerCount = value;
            }
        }

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
