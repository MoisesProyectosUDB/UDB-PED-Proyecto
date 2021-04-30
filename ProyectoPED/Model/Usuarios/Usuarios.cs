using ProyectoPED.Database;
using ProyectoPED.Xml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.Usuarios
{
   public class Usuarios
    {
        string sqlXml = "";
        string procedure = "UDB_UserAdd";


        public string CrearUsuario(string NombreCompleto, string Correo,string Contra, int Estado, int Rol, string Carnet) 
        {
            var UsuarioRequestObj = new UsuarioRoot()
            {
                Request = new UsuarioRequest()
                {
                     NombreCompleto=NombreCompleto,
                     Correo=Correo,
                     Contra=Contra,
                     Estado=Estado.ToString(),
                     Rol=Rol.ToString(),
                     Carnet=Carnet
                },
                Response = new UsuarioResponse() { },
            };

            String UsuarioRequestXml = Serializer<UsuarioRoot>.SerializeToString(UsuarioRequestObj);
            //Console.WriteLine(UsuarioRequestXml);
            try
            {
                sqlXml = ConnectionDB.ExecuteStoredProcedure(procedure, new SqlParameter("@SolicitudXML", UsuarioRequestXml));

            }
            catch (Exception e)
            {
                return "000001";
            }
            UsuarioRequestObj = Serializer<UsuarioRoot>.DeserializeString(sqlXml);

            if (UsuarioRequestObj.Response.Resultado == "1")
            {
                return "000000";
            }
            else { 
                if(UsuarioRequestObj.Response.Resultado == "2") { return "000003"; }
                return "000002"; 
            }

        }
    }
}
