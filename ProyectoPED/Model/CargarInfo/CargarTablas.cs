using ProyectoPED.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public String  CargarMaterias(string consultaCreacionXml)
        {
            string sqlXml;
            using (SqlConnection connection = new SqlConnection(ConnectionDB.GetConnectionString()))
            {
                string procedure = "UDB_ListaMaterias";

                SqlCommand command = new SqlCommand
                {
                    CommandText = procedure,
                    CommandType = CommandType.StoredProcedure,
                    Connection = connection
                };

                command.Parameters.Add(new SqlParameter("@SolicitudXML", consultaCreacionXml));
                connection.Open();

                XmlReader reader;
                reader = command.ExecuteXmlReader();

                reader.MoveToContent();
                sqlXml = reader.ReadOuterXml();

                connection.Close();

            }

            return sqlXml;
        }
    }
}
