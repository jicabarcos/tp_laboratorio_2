using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manager : Companion, IOrdenable
    {
        #region Atributos
        private string nivelDeAcceso;
        #endregion

        #region Propiedades
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
        /// Constructor publico de la clase Manager. Llama al constructor de su clase base. Valida que el
        /// parámetro "acceso" sea uno de los tres permitidos, si no lo es, lo setea en "Bajo".
        /// </summary>
        /// <param name="nombre">Nombre del Manager.</param>
        /// <param name="tareas">Tareas que podrá realizar el Manager.</param>
        /// <param name="acceso">Nivel de acceso a los datos del usuario.</param>
        public Manager(List<ETarea> tareas, string acceso) : base(tareas)
        {
            if(acceso != "Alto" && acceso != "Medio" && acceso != "Bajo")
            {
                acceso = "Bajo";
            }
            this.nivelDeAcceso = acceso;
        }

        /// <summary>
        /// Implementación del método abstracto MostrarDatos(). Muestra los datos del Cook 
        /// junto con un mensaje de presentación.
        /// </summary>
        /// <returns>String con los datos.</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Hola! Soy tu nuevo Companion encargado de administrar y organizar.");
            sb.Append(base.ToString());
            sb.AppendLine($"Nivel de acceso a datos del usuario: {this.nivelDeAcceso}\n");
            sb.AppendLine($"Precio final: ${base.Precio}\n");
            sb.AppendLine($"-----------------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Ordena al Manager que realice ciertas tareas.
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
                        sb.AppendLine($"Tareas de administración a realizar: {(this.TareasRealizadas++).ToString()}");
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
                return "Ninguna de las tareas indicadas ha sido asignada al Manager.";
            }

        }
        #endregion
    }
}
