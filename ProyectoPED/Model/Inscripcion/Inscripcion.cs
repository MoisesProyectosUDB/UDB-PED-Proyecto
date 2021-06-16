using ProyectoPED.Database;
using ProyectoPED.Xml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.Inscripcion
{
  public  class Inscripcion
    {
        string sqlXml = "";
        string procedure = "UDB_InscripcionAdd";


        public string CrearInscripcion( int Usuario, int Carrera, int Materia)
        {
            var InscripcionRequestObj = new InscripcionRoot()
            {
                Request = new  InscripcionRequest()
                {
                    Carrera = new Carrera()
                    {
                        IdUsuario= Usuario.ToString(),
                        IdCarrera= Carrera.ToString(),
                        IdEstado="1",
                        Avance="0"
                    },
                    Materia= new Materia() 
                    {
                        IdMateria= Materia.ToString(),
                        IdCiclo="1",
                        IdEstado="1"
                    },
                },
                Response = new  InscripcionResponse() { },
            };

         String InscripcionRequestXml = Serializer<InscripcionRoot>.SerializeToString(InscripcionRequestObj);
            Console.WriteLine(InscripcionRequestXml);
            try
            {
                sqlXml = ConnectionDB.ExecuteStoredProcedure(procedure, new SqlParameter("@SolicitudXML", InscripcionRequestXml));

            }
            catch (Exception e)
            {
                return "000001";
            }
            InscripcionRequestObj = Serializer<InscripcionRoot>.DeserializeString(sqlXml);

            if (InscripcionRequestObj.Response.Resultado == "1")
            {
                return "000000";
            }
            else
            {
                if (InscripcionRequestObj.Response.Resultado == "2") { return "000003"; }
                return "000002";
            }
        }
    }
}
