﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class DBManagement
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        static DBManagement()
        {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=Companions;Integrated Security=True;");
            comando = new SqlCommand();
        }
        
        public static Dictionary<string, string> ImportFromDB()
        {
            SqlDataReader reader;
            Dictionary<string, string> dictCompanions = new Dictionary<string, string>();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT Nombre, Fecha FROM Companions";
            conexion.Open();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                dictCompanions.Add(reader["Nombre"].ToString(), reader["Fecha"].ToString());
            }
            conexion.Close();

            return dictCompanions;
        }

        public static int ExportToDB(List<Companion> listaComps)
        {
            int filasAgregadas = 0;
            DBManagement.comando.Connection = DBManagement.conexion;
            DBManagement.comando.CommandType = CommandType.Text;
            DBManagement.comando.CommandText = "INSERT INTO Companions VALUES(@Nombre,@Tipo,@Tareas,@Utensilios,@NivelAcceso,@Fecha)";

            foreach(Companion comp in listaComps)
            {
                DBManagement.comando.Parameters.Clear();
                DBManagement.comando.Parameters.Add(new SqlParameter("@Nombre", comp.Nombre));
                DBManagement.comando.Parameters.Add(new SqlParameter("@Tareas", comp.ListaTareas));
                DBManagement.comando.Parameters.Add(new SqlParameter("@Fecha", DateTime.Now.ToString()));
                
                if(comp is Cook)
                {
                    Cook aux = (Cook)comp;
                    DBManagement.comando.Parameters.Add(new SqlParameter("@Tipo", "Cook"));
                    DBManagement.comando.Parameters.Add(new SqlParameter("@Utensilios", aux.ListaUtensilios));
                    DBManagement.comando.Parameters.Add(new SqlParameter("@NivelAcceso", ""));

                }
                else if(comp is Housekeeper)
                {
                    Housekeeper aux = (Housekeeper)comp;
                    DBManagement.comando.Parameters.Add(new SqlParameter("@Tipo", "Housekeeper"));
                    DBManagement.comando.Parameters.Add(new SqlParameter("@Utensilios", ""));
                    DBManagement.comando.Parameters.Add(new SqlParameter("@NivelAcceso", ""));
                }
                else
                {
                    Manager aux = (Manager)comp;
                    DBManagement.comando.Parameters.Add(new SqlParameter("@Tipo", "Manager"));
                    DBManagement.comando.Parameters.Add(new SqlParameter("@NivelAcceso", aux.NivelDeAcceso));
                    DBManagement.comando.Parameters.Add(new SqlParameter("@Utensilios", ""));
                }
                DBManagement.conexion.Open();
                filasAgregadas += DBManagement.comando.ExecuteNonQuery();
                DBManagement.conexion.Close();
            }
            return filasAgregadas;
        }
    }
}
