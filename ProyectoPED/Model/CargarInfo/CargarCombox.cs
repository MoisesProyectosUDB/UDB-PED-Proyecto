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
  public   class CargarCombox
    {
        public DataTable CargarComboEstadoUser()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargaEstadosUsuarios", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;


        }

        public DataTable CargarRoles()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargaRoles", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarCarreras()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargaCarreras", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarCarrerasporUsario(string valor)
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargarCarrerasPorUsuario", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarMateriasporCarreraUsuario(string carnet,int idCarrera)
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargarMateriasPorCarreraUsuario", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Carnet", SqlDbType.VarChar).Value = carnet;
            da.SelectCommand.Parameters.Add("@idCarrera", SqlDbType.VarChar).Value = idCarrera;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarTipoActividades()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargaTipoActividades", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarAllUser()
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargaUsuariosAll", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }

        public DataTable CargarMateriasporCarrera(int idCarrera)
        {
            SqlDataAdapter da = new SqlDataAdapter("UDB_CargarMateriasPorCarrera", ConnectionDB.GetConnectionString());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idCarrera", SqlDbType.VarChar).Value = idCarrera;
            DataTable Data = new DataTable();
            da.Fill(Data);
            return Data;
        }
    }
}
