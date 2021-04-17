
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace ProyectoPED.Database
{
    class ConnectionDB
    {

        public static string GetConnectionString()
        {
            return new SqlConnectionStringBuilder()
            {

                DataSource = ConfigurationManager.AppSettings["DataSource"],
                InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"],
                PersistSecurityInfo = true,
                UserID = ConfigurationManager.AppSettings["UserID"],
                Password = ConfigurationManager.AppSettings["Password"],
                MultipleActiveResultSets = true,
                Pooling = true,
            }.ToString();
        }

        public static string ExecuteStoredProcedure(string nameProcedure, SqlParameter sqlParameter)
        {
            try
            {
                string answer = "";
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    // string procedure = "SPU_SQLConsultaCreacionDeSolicitud";

                    SqlCommand command = new SqlCommand
                    {
                        CommandText = nameProcedure,
                        CommandType = CommandType.StoredProcedure,
                        Connection = connection
                    };

                    command.Parameters.Add(sqlParameter);
                    connection.Open();

                    XmlReader reader;
                    reader = command.ExecuteXmlReader();

                    reader.MoveToContent();
                    answer = reader.ReadOuterXml();

                    connection.Close();
                }
                return answer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
