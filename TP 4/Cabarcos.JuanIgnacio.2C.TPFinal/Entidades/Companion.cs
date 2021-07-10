using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Companion
    {
        #region Atributos
        protected string nombre;      // marcado de numero de serie - generador de nombres
        private List<ETarea> listaTareas;
        private double precio;
        private double tareasRealizadas;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad protegida de sólo lectura. Devuelve el nombre asignado al Companion, junto con una presentación.
        /// </summary>
        public abstract string Nombre { get; set; }

        /// <summary>
        /// Propiedad privada de sólo lectura. Devuelve un string con la lista de tareas del Companion.
        /// </summary>
        public string ListaTareas
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach(ETarea tarea in this.listaTareas)
                {
                    sb.AppendLine(tarea.ToString());
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// Propiedad privada de sólo lectura. Calcula el precio del Companion en base a la cantidad de tareas
        /// que tiene asignadas.
        /// </summary>
        public double Precio
        {
            get
            {
                this.precio = 0;
                foreach(ETarea tarea in this.listaTareas)
                {
                    precio += 300;
                }
                return this.precio;
            }
        }

        public double TareasRealizadas
        {
            get
            {
                return this.tareasRealizadas;
            }
            set
            {
                this.tareasRealizadas = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor privado de la clase Companion. Inicializa la lista de tareas.
        /// </summary>
        private Companion()
        {
            this.listaTareas = new List<ETarea>();
            this.tareasRealizadas = 0;
        }

        /// <summary>
        /// Constructor público de la clase Companion. Asigna los parámetros a sus correspondientes atributos.
        /// Llama al constructor privado.
        /// </summary>
        /// <param name="nombre">Nombre del Companion</param>
        /// <param name="tareas">Lista de tareas que podrá realizar</param>
        public Companion(List<ETarea> tareas) : this()
        {
            this.listaTareas = tareas;
        }

        /// <summary>
        /// Sobrecarga del operador '=='. Evalúa si un Companion está dentro de una lista de Companions.
        /// </summary>
        /// <param name="listaCompanions">Lista en la que se busca.</param>
        /// <param name="unCompanion">Companion a buscar.</param>
        /// <returns>True si el Companion se encuentra en la lista. False de lo contrario.</returns>
        public static bool operator ==(List<Companion> listaCompanions, Companion unCompanion)
        {
            foreach (Companion comp in listaCompanions)
            {
                if ((comp.nombre == unCompanion.nombre) && (comp.GetType() == unCompanion.GetType()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador '!='. Evalúa si un Companion NO está dentro de una lista de Companions.
        /// </summary>
        /// <param name="listaCompanions">Lista en la que se busca.</param>
        /// <param name="unCompanion">Companion a buscar.</param>
        /// <returns>True si el Companion no está en la lista. False de lo contrario.</returns>
        public static bool operator !=(List<Companion> listaCompanions, Companion unCompanion)
        {
            return !(listaCompanions == unCompanion);
        }

        /// <summary>
        /// Sobrecarga del operador '+'. Si el Copmanion no está en la Lista de Copmanions, lo agrega.
        /// </summary>
        /// <param name="listaPersonajes">Lista de Companions a recorrer.</param>
        /// <param name="personaje">Companion a agregar.</param>
        /// <returns>Lista de Companions, haya sido agregado el Companion o no.</returns>
        public static List<Companion> operator +(List<Companion> listaCompanions, Companion unCompanion)
        {
            if (listaCompanions != unCompanion)
            {
                listaCompanions.Add(unCompanion);
            }
            return listaCompanions;
        }

        /// <summary>
        /// Sobrecarga del operador '-'. Si el Companion está en la Lista de Companions, lo elimina.
        /// </summary>
        /// <param name="listaCompanions">Lista de Companions a recorrer.</param>
        /// <param name="unCompanion">Companion a eliminar.</param>
        /// <returns>Lista de Companions, haya sido eliminado el Companion o no.</returns>
        public static List<Companion> operator -(List<Companion> listaCompanions, Companion unCompanion)
        {
            if (listaCompanions == unCompanion)
            {
                listaCompanions.Remove(unCompanion);
            }
            return listaCompanions;
        }

        /// <summary>
        /// Sobrescritura del método ToString() para la clase Companion.
        /// </summary>
        /// <returns>Información acerca del Companion en forma de string.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Nombre}\n");
            sb.AppendLine($"Tareas: \n{this.ListaTareas}");

            return sb.ToString();
        }

        /// <summary>
        /// Método abstracto para mostrar datos del companion.
        /// </summary>
        /// <returns></returns>
        public abstract string MostrarDatos();
        #endregion
    }
}