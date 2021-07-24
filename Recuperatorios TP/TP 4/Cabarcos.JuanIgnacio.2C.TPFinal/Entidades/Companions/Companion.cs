using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Cook))]
    [XmlInclude(typeof(Housekeeper))]
    [XmlInclude(typeof(Manager))]
    public abstract class Companion
    {
        #region Atributos
        protected string nombre;
        private List<ETarea> listaTareas;
        private double precio;
        private double tareasRealizadas;
        private bool selloFabricacion;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad abstracta relacionada con el atributo nombre del Companion.
        /// </summary>
        public abstract string Nombre { get; set; }

        /// <summary>
        /// Propiedad pública de lectura y escritura. Devuelve un string con la lista de tareas del Companion.
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

            set
            {
                this.listaTareas = new List<ETarea>() { };
            }
        }

        /// <summary>
        /// Propiedad pública de sólo lectura. Calcula el precio del Companion en base a la cantidad de tareas
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

            set
            {
                this.precio = value;
            }
        }

        /// <summary>
        /// Propiedad pública de lectura y escritura. Obtiene la información o setea el valor de las tareas
        /// que fueron realizadas por el Companion.
        /// </summary>
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

        /// <summary>
        /// Propiedad pública de lectura y escritura. Indica si el companion ya pasó por su proceso
        /// de fabricación o no.
        /// </summary>
        public bool SelloFabricacion
        {
            get
            {
                return this.selloFabricacion;
            }
            set
            {
                this.selloFabricacion = value;
            }
        }

        #region Metodos
        /// <summary>
        /// Constructor público de la clase Companion. Inicializa la lista de tareas.
        /// </summary>
        public Companion()
        {
            this.listaTareas = new List<ETarea>();
            this.tareasRealizadas = 0;
            this.nombre = NameGenerator<Companion>.CompanionName(this);
            this.selloFabricacion = false;
        }

        /// <summary>
        /// Constructor público de la clase Companion. Asigna los parámetros a sus correspondientes atributos.
        /// Llama al constructor privado.
        /// </summary>
        /// <param name="nombre">Nombre del Companion</param>
        /// <param name="tareas">Lista de tareas que podrá realizar</param>
        public Companion(List<ETarea> tareas) : this()
        {
            if(tareas.Count == 0)
            {
                if(this is Cook)
                {
                    this.listaTareas = new List<ETarea>(){ ETarea.Cocinar };
                }
                else if(this is Housekeeper)
                {
                    this.listaTareas = new List<ETarea>() { ETarea.Limpiar };
                }
                else
                {
                    this.listaTareas = new List<ETarea>() { ETarea.OrganizarGastos };
                }
            }
            else
            {
                this.listaTareas = tareas;
            }
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
        /// <param name="listaCompanions">Lista de Companions a recorrer.</param>
        /// <param name="unCompanion">Companion a agregar.</param>
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

            sb.AppendLine($"Mi nombre es {this.Nombre}\n");
            sb.AppendLine($"Tareas: \n{this.ListaTareas}");

            return sb.ToString();
        }

        /// <summary>
        /// Método virtual para mostrar datos del Companion.
        /// </summary>
        /// <returns>String con los datos del Companion.</returns>
        public virtual string MostrarDatos()
        {
            return "";
        }
        #endregion
    }
}