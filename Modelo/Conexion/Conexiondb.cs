using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    public class Conexiondb
    {
        private static string servidor = "LAB03-DS-EQ25\\SQLEXPRESS";
        public static string database = "InscripcionCursos";


        public static SqlConnection conectar()
        {
            string cadena = $"Data Source = {servidor};Initial Catalog = {database}; Integrated security = true;";

            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;

        }


    }
}
