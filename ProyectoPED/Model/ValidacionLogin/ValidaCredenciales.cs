using ProyectoPED.Database;
using ProyectoPED.Xml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.ValidacionLogin
{
    public class ValidaCredenciales
    {

        string sqlXml = "";
        string procedure = "UDB_ValidacionLogin";


        public  string validarCredenciales (string user,string pass) 
        {
            var loginRequestObj = new LoginRoot()
            {
                Request = new LoginRequest()
                {
                    Usuario = user,//datos previenen del FORM LOGIN
                    Passwordd = pass //datos previenen del FORM LOGIN
                },
                Response = new LoginResponse(){ },
            };

            String LoginRequestXml = Serializer<LoginRoot>.SerializeToString(loginRequestObj);
            //Console.WriteLine(LoginRequestXml);
            try 
            {
                sqlXml = ConnectionDB.ExecuteStoredProcedure(procedure, new SqlParameter("@SolicitudXML", LoginRequestXml));
                
            }
            catch (Exception e)
            {
                return "000001";
            }
            loginRequestObj  = Serializer<LoginRoot>.DeserializeString(sqlXml);

            if (loginRequestObj.Response.Resultado == "1")
            {
                return "000000";
            }
            else { return "000002"; }
            

        }
        

    }
}
