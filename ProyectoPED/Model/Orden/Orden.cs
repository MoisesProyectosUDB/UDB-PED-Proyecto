using ProyectoPED.Database;
using ProyectoPED.Xml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.Orden
{
    public class Orden
    {
        string sqlXml = "";


        public string Update(int IdCarrera,int x, int y)
        {
            string procedure = "UDB_MateriaUpdate";
            var OrdenRequestObj = new  OrdenRoot()
            {
                Request = new  OrdenRequest()
                {
                     IdCarrera = IdCarrera.ToString(),
                      posicion_x=x.ToString(),
                      posicion_y=y.ToString()
                },
                Response = new  OrdenResponse() { },
            };

            string OrdenRequestXml = Serializer<OrdenRoot>.SerializeToString(OrdenRequestObj);
            try
            {
                sqlXml = ConnectionDB.ExecuteStoredProcedure(procedure, new SqlParameter("@SolicitudXML", OrdenRequestXml));

            }
            catch (Exception e)
            {
                return "000001";
            }
            OrdenRequestObj = Serializer<OrdenRoot>.DeserializeString(sqlXml);

            if (OrdenRequestObj.Response.Resultado == "1")
            {
                return "000000";
            }
            else
            {
                if (OrdenRequestObj.Response.Resultado == "2") { return "000003"; }
                return "000002";
            }
        }

        public string CrearCamino(int IdMateriaOrigen, int IdMateriaDestino, int Peso)
        {
            string procedure = "UDB_OrdenADD";
            var OrdenRequestObj = new OrdenRoot()
            {
                Request = new OrdenRequest()
                {
                    IdMateriaOrigen = IdMateriaOrigen.ToString(),
                    IdMateriaDestino = IdMateriaDestino.ToString(),
                    Peso = Peso.ToString()
                },
                Response = new OrdenResponse() { },
            };
            string OrdenRequestXml = Serializer<OrdenRoot>.SerializeToString(OrdenRequestObj);
            try
            {
                sqlXml = ConnectionDB.ExecuteStoredProcedure(procedure, new SqlParameter("@SolicitudXML", OrdenRequestXml));

            }
            catch (Exception e)
            {
                return "000001";
            }
            OrdenRequestObj = Serializer<OrdenRoot>.DeserializeString(sqlXml);

            if (OrdenRequestObj.Response.Resultado == "1")
            {
                return "000000";
            }
            else
            {
                if (OrdenRequestObj.Response.Resultado == "2") { return "000003"; }
                return "000002";
            }
        }
    }
}
