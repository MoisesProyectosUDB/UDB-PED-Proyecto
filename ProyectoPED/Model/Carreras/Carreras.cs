using ProyectoPED.Database;
using ProyectoPED.Xml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.Carreras
{
   public class Carreras
    {

        string sqlXml = "";
        string procedure = "UDB_CarreraAdd";

        public string CrearCarrera(string NombreCarrera)
        {
            var CarreraRequestObj = new CarreraRoot()
            {
                Request = new  CarreraRequest()
                {
                    NombreCarrera= NombreCarrera
                },
                Response = new CarreraResponse() { },
            };

            String CarreraRequestXml = Serializer<CarreraRoot>.SerializeToString(CarreraRequestObj);
            //Console.WriteLine(UsuarioRequestXml);
            try
            {
                sqlXml = ConnectionDB.ExecuteStoredProcedure(procedure, new SqlParameter("@SolicitudXML", CarreraRequestXml));

            }
            catch (Exception e)
            {
                return "000001";
            }
            CarreraRequestObj = Serializer<CarreraRoot>.DeserializeString(sqlXml);

            if (CarreraRequestObj.Response.Resultado == "1")
            {
                return "000000";
            }
            else
            {
                if (CarreraRequestObj.Response.Resultado == "2") { return "000003"; }
                return "000002";
            }

        }


    }
}
