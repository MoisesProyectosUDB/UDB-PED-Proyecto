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
    }
}
