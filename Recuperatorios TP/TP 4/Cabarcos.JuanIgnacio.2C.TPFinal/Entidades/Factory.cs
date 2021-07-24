using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades.Excepciones;

namespace Entidades
{
    public delegate void CrearDelegate();

    public static class Factory
    {
        #region Atributos
        static List<Companion> listaCompanions;
        static bool estado;
        public static event CrearDelegate GuardarCompanionTxt;
        static Queue<Companion> colaFabricacion;
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de la clase estática Factory. Inicializa sus atributos.
        /// </summary>
        static Factory()
        {
            Factory.estado = false;
            Factory.listaCompanions = new List<Companion>();
            Factory.colaFabricacion = new Queue<Companion>();
        }

        /// <summary>
        /// Propiedad pública de sólo lectura. Obtiene la lista de Companions de la fábrica.
        /// </summary>
        public static List<Companion> ListaCompanions
        {
            get
            {
                return Factory.listaCompanions;
            }
        }

        /// <summary>
        /// Propiedad pública de sólo lectura. Obtiene el estado de la fábrica.
        /// </summary>
        public static bool Estado
        {
            get
            {
                return Factory.estado;
            }
        }

        /// <summary>
        /// Propiedad pública de sólo lectura. Obtiene la lista de Companions en cola para ser fabricados.
        /// </summary>
        public static Queue<Companion> ColaFabricacion
        {
            get
            {
                return Factory.colaFabricacion;
            }
        }

        /// <summary>
        /// Muestra el listado de todos los Companions incluidos en la Lista de Companions que hayan sido fabricados.
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
                    if (comp is T && comp.SelloFabricacion == true)
                    {
                        if(comp is Cook)
                        {
                            Cook aux = (Cook)comp;
                            sb.AppendLine(aux.MostrarDatos());
                        }
                        else if(comp is Housekeeper)
                        {
                            Housekeeper aux = (Housekeeper)comp;
                            sb.AppendLine(aux.MostrarDatos());
                        }
                        else
                        {
                            Manager aux = (Manager)comp;
                            sb.AppendLine(aux.MostrarDatos());
                        }
                    }
                }
                return sb.ToString();
            }
            return "Fábrica apagada.";
        }

        /// <summary>
        /// Agrega un Companion a la lista, verificando primero que no se encuentre en ella.
        /// </summary>
        /// <param name="comp">Companion a agregar.</param>
        /// <returns>True si el Copmanion fue agregado. False de lo contrario.</returns>
        public static bool AgregarCompanion(Companion comp)
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

        /// <summary>
        /// Setea el estado de la fábtrica en encendido o apagado.
        /// </summary>
        /// <param name="estado">Estado a establecer.</param>
        public static void EncenderFabrica(this bool estado)
        {
            Factory.estado = estado;
        }

        /// <summary>
        /// Pone en cola de fabricación los Companions de la lista listaCompanions.
        /// </summary>
        /// <returns>True si la lista tiene uno o más Companions, false de lo contrario.</returns>
        public static bool PonerEnCola()
        {
            if(Factory.listaCompanions.Count > 0)
            {
                foreach (Companion item in Factory.listaCompanions)
                {
                    if (item.SelloFabricacion == false)
                    {
                        Factory.colaFabricacion.Enqueue(item);
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Fabrica los Companions de la cola colaFabricacion.
        /// </summary>
        /// <returns>True si la cola tiene uno o más Companions, false de lo contrario.</returns>
        public static int Fabricar()
        {
            int retorno = 0;

            if(Factory.colaFabricacion.Count > 0)
            {
                foreach (Companion item in Factory.colaFabricacion)
                {
                    item.SelloFabricacion = true;
                    retorno++;                    
                }
            }
            return retorno;
        }
        #endregion
    }
}