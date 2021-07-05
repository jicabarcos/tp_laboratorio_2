﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Housekeeper : Companion
    {
        #region Propiedades
        public override string Nombre
        {
            get
            {
                return base.Nombre + "HK-00";
            }
            set
            {
                base.Nombre = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor público de la clase Housekeeper. Llama al constructor de su clase base.
        /// </summary>
        /// <param name="nombre">Nombre del Housekeeper.</param>
        /// <param name="tareas">Lista de tareas que realizará el Housekeeper.</param>
        public Housekeeper(string nombre, List<ETarea> tareas):base(nombre, tareas)
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
