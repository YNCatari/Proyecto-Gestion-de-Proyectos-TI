using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaVeterinaria.Negocios
{
    class ClsNConexion
    {
        public string Servidor = "localhost";
        public string Basedatos = "dbveterinaria";
        public string usuario = "root";
        public string clave = "";

        public static MySqlConnection conn;
        //public static string ConBDcadena;
        public MySqlConnection conectar()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = "server=" + Servidor + ";" +
                "database=" + Basedatos +
                ";uid=" + usuario + ";" +
                "pwd= " + clave + " ;SslMode=none;";
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return conn;
        }

        public MySqlConnection cerrar()
        {
            try
            {
                conn = new MySqlConnection();
                conn.Close();
            }
            catch (MySqlException ex) { throw ex; }
            return conn;
        }
    }
}
