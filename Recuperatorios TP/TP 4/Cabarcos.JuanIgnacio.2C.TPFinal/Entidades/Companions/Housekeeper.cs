using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Housekeeper : Companion, IOrdenable
    {
        #region Propiedades
        
        /// <summary>
        /// Propiedad pública de lectura y escritura. Devuelve un string con el nombre del Housekeeper.
        /// </summary>
        public override string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor público sin parámetros de la clase Housekeeper.
        /// </summary>
        public Housekeeper() : base()
        {
        }

        /// <summary>
        /// Constructor público de la clase Housekeeper. Llama al constructor de su clase base.
        /// </summary>
        /// <param name="nombre">Nombre del Housekeeper.</param>
        /// <param name="tareas">Lista de tareas que realizará el Housekeeper.</param>
        public Housekeeper(List<ETarea> tareas):base(tareas)
        {            
        }

        /// <summary>
        /// Implementación del método abstracto MostrarDatos(). Muestra los datos del Housekeeper 
        /// junto con un mensaje de presentación.
        /// </summary>
        /// <returns>String con los datos.</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Hola! Soy tu nuevo Companion encargado del orden y la limpieza.");
            sb.Append(base.ToString());
            sb.AppendLine($"Precio final: ${base.Precio}\n");
            sb.AppendLine($"-----------------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Ordena al Housekeeper que realice ciertas tareas.
        /// Implementación de la interfaz IOrdenable.
        /// </summary>
        /// <param name="tareas">Tareas a realizar.</param>
        /// <returns>String con las tareas realizadas o indicando que no ha realizado ninguna.</returns>
        public string OrdenarTareas(List<ETarea> tareas)
        {
            StringBuilder sb = new StringBuilder();
            bool aux = false;
            
            foreach (ETarea unaTarea in this.ListaTareas)
            {
                foreach (ETarea otraTarea in tareas)
                {
                    if (unaTarea == otraTarea)
                    {
                        sb.AppendLine($"Tareas de orden y limpieza a realizar: {(this.TareasRealizadas++).ToString()}");
                        aux = true;
                    }
                }
            }
            if (aux)
            {
                return sb.ToString();
            }
            else
            {
                return "Ninguna de las tareas indicadas ha sido asignada al Housekeeper.";
            }
        }
        #endregion
    }
}
