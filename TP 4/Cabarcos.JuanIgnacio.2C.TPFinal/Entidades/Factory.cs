using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades.Excepciones;

namespace Entidades
{
    public delegate bool CrearDelegate();

    public static class Factory
    {
        #region Atributos
        static List<Companion> listaCompanions;
        static bool estado = false;
        public static event CrearDelegate GuardarCompanionTxt;
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de la clase estática Factory. Inicializa la Lista de Companions.
        /// </summary>
        static Factory()
        {
            listaCompanions = new List<Companion>();
        }

        public static List<Companion> ListaCompanions
        {
            get
            {
                return Factory.listaCompanions;
            }
        }

        public static bool Estado
        {
            get
            {
                return Factory.estado;
            }
        }

        /// <summary>
        /// Muestra el listado de todos los Companions incluidos en la Lista de Companions, independientemente de su tipo.
        /// Utiliza Generics.
        /// </summary>
        /// <typeparam name="T">Tipo de Companion. Puede ser Cook, Housekeeper, Manager o Companion (todos).</typeparam>
        /// <returns>Lista de Companions del tipo T.</returns>
        public static string MostrarListado<T>()
        {
            if (Factory.estado == true)
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
            return "Fábrica apagada.";
        }

        /// <summary>
        /// Agrega un Companion a la lista, verificando primero que no se encuentre en ella.
        /// Utilizado en FrmAgregarCompanion
        /// </summary>
        /// <param name="comp">Companion a agregar.</param>
        /// <returns>True si el Copmanion fue agregado. False de lo contrario.</returns>
        public static bool AgregarCompanionForm(Companion comp)
        {
            if (Factory.estado == true)
            {
                if (Factory.listaCompanions != comp)
                {
                    Factory.listaCompanions += comp;
                    if (!(Thread.CurrentThread is null))
                    {
                        Factory.GuardarCompanionTxt.Invoke();
                    }
                    return true;
                }
            }
            else
            {
                throw new FabricaApagadaException("Debe iniciar la fábrica antes de poder realizar cualquier tarea.");
            }
            return false;
        }

        /// <summary>
        /// Agrega un Companion a la lista, verificando primero que no se encuentre en ella.
        /// Utilizada en Unit Testing y en PruebaConsola
        /// </summary>
        /// <param name="comp">Companion a agregar.</param>
        /// <returns>True si el Copmanion fue agregado. False de lo contrario.</returns>
        public static bool AgregarCompanionConsola(Companion comp)
        {
            if (Factory.estado == true)
            {
                if (Factory.listaCompanions != comp)
                {
                    Factory.listaCompanions += comp;
                    return true;
                }
            }
            else
            {
                throw new FabricaApagadaException("Debe iniciar la fábrica antes de poder realizar cualquier tarea.");
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
            if (Factory.estado == true)
            {
                if (Factory.listaCompanions == comp)
                {
                    Factory.listaCompanions -= comp;
                    return true;
                }
            }
            return false;
        }

        public static void EncenderFabrica(this bool estado)
        {
            Factory.estado = estado;
        }
        #endregion
    }
}