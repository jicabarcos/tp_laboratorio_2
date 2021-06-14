using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cook : Companion, IOrdenable
    {
        #region Atributos
        protected List<EUtensilio> listaUtensilios;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad privada de sólo lectura. Devuelve un string con la Lista de Utensilios que usará el Cook.
        /// </summary>
        private string ListaUtensilios
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (EUtensilio utensilio in this.listaUtensilios)
                {
                    sb.AppendLine(utensilio.ToString());
                }

                return sb.ToString();
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor publico de la clase Cook. Asigna la lista de utensilios pasada por parámetro a su
        /// correspondiente atributo. Llama al constructor de su clase base.
        /// </summary>
        /// <param name="nombre">Nombre del Cook.</param>
        /// <param name="tareas">Tareas que podrá realizar el Cook.</param>
        /// <param name="utensilios">Utensilios que tendrá a su disposición el Cook.</param>
        public Cook(string nombre, List<ETarea> tareas, List<EUtensilio> utensilios):base(nombre, tareas)
        {
            this.listaUtensilios = utensilios;
        }

        /// <summary>
        /// Implementación del método abstracto MostrarDatos(). Muestra los datos del Cook 
        /// junto con un mensaje de presentación.
        /// </summary>
        /// <returns>String con los datos.</returns>
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Hola! Soy tu nuevo Companion encargado de la cocina.");
            sb.Append(base.ToString());
            sb.AppendLine($"Utensilios:\n{this.ListaUtensilios}");
            sb.AppendLine($"Precio final: ${base.Precio}\n");
            sb.AppendLine($"-----------------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Ordena al Cook que realice ciertas tareas.
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
                foreach(ETarea otraTarea in tareas)
                {
                    if(unaTarea.ToString() == otraTarea.ToString())
                    {
                        sb.AppendLine($"Tareas de cocina a realizar: {(this.TareasRealizadas++).ToString()}");
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
                return "Ninguna de las tareas indicadas ha sido asignada al Cook.";
            }
        }
        #endregion
    }
}
