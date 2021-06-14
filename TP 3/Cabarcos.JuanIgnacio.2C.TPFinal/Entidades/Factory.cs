using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Factory
    {
        #region Atributos
        static List<Companion> listaCompanions;
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de la clase estática Factory. Inicializa la Lista de Companions.
        /// </summary>
        static Factory()
        {
            listaCompanions = new List<Companion>();
        }

        /// <summary>
        /// Muestra el listado de todos los Companions incluidos en la Lista de Companions, independientemente de su tipo.
        /// Utiliza Generics.
        /// </summary>
        /// <typeparam name="T">Tipo de Companion. Puede ser Cook, Housekeeper, Manager o Companion (todos).</typeparam>
        /// <returns>Lista de Companions del tipo T.</returns>
        public static string MostrarListado<T>()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Companion comp in Factory.listaCompanions)
            {
                if (comp is T)
                {
                    sb.AppendLine(comp.MostrarDatos());
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Agrega un Companion a la lista, verificando primero que no se encuentre en ella.
        /// Utilizada en Unit Testing
        /// </summary>
        /// <param name="comp">Companion a agregar.</param>
        /// <returns>True si el Copmanion fue agregado. False de lo contrario.</returns>
        public static bool AgregarCompanion(Companion comp)
        {
            if (Factory.listaCompanions != comp)
            {
                Factory.listaCompanions += comp;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Elimina un Companion de la lista, verificando primero si ya se encuentra.
        /// Utilizada en Unit Testing
        /// </summary>
        /// <param name="comp">Companion a eliminar.</param>
        /// <returns>True si el Companion fue eliminado. False de lo contrario.</returns>
        public static bool EliminarCompanion(Companion comp)
        {
            if (Factory.listaCompanions == comp)
            {
                Factory.listaCompanions -= comp;
                return true;
            }
            return false;
        }
        #endregion
    }
}