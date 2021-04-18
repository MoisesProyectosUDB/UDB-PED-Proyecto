using ProyectoPED.Database;
using ProyectoPED.Xml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.Materias
{
   public class Materias
    {

        string sqlXml = "";
        string procedure = "UDB_MateriaAdd";

        public string CrearMateria(string NombreMateria,string codMateria, int idCarrera)
        {
            var UsuarioRequestObj = new MateriaRoot()
            {
                Request = new MateriaRequest()
                {
                     NombreMateria=NombreMateria,
                     CodigoMateria= codMateria,
                     IdCarrera= idCarrera.ToString()
                },
                Response = new MateriaResponse() { },
            };

            String MateriaRequestXml = Serializer<MateriaRoot>.SerializeToString(UsuarioRequestObj);
            //Console.WriteLine(UsuarioRequestXml);
            try
            {
                sqlXml = ConnectionDB.ExecuteStoredProcedure(procedure, new SqlParameter("@SolicitudXML", MateriaRequestXml));

            }
            catch (Exception e)
            {
                return "000001";
            }
            UsuarioRequestObj = Serializer<MateriaRoot>.DeserializeString(sqlXml);

            if (UsuarioRequestObj.Response.Resultado == "1")
            {
                return "000000";
            }
            else
            {
                if (UsuarioRequestObj.Response.Resultado == "2") { return "000003"; }
                return "000002";
            }

        }
    }
}
