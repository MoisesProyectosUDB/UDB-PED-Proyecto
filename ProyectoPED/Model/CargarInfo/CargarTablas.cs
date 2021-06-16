using ProyectoPED.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.CargarInfo
{
    public class CargarTablas
    {


        public DataTable CargarTablaUser()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargarUserTable", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarTablaMateriaCarrera()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargarMaterias", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarTablaCarreras()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargaCarreras", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarTablaInscrpcionProfesores()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargaMaestros", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarTablaInscrpcionEstudiantes()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargarEstudiantes", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }
    }
}
