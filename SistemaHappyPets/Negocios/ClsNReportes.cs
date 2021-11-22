using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinaria.Entidades;
namespace SistemaVeterinaria.Negocios
{
    class ClsNReportes
    {
        public DataTable MtdBuscarVacuna(ClsEReportes Obj)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_SumarServicioFecha";
            command.Parameters.Add(new MySqlParameter("pfecini", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pfecfin", MySqlDbType.VarChar));
            command.Parameters["pfecini"].Value = Obj.FechaI;
            command.Parameters["pfecfin"].Value = Obj.FechaF;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
        public DataTable MtdBuscarMantenimiento(ClsEReportes Obj)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_SumarMantenimientoFecha";
            command.Parameters.Add(new MySqlParameter("pfecini", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pfecfin", MySqlDbType.VarChar));     
            command.Parameters["pfecini"].Value = Obj.FechaI;     
            command.Parameters["pfecfin"].Value = Obj.FechaF;           
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
        public DataTable MtdBuscarTratamiento(ClsEReportes Obj)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_SumarTratamientoFecha";
            command.Parameters.Add(new MySqlParameter("pfecini", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pfecfin", MySqlDbType.VarChar));
            command.Parameters["pfecini"].Value = Obj.FechaI;
            command.Parameters["pfecfin"].Value = Obj.FechaF;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
    }
}
