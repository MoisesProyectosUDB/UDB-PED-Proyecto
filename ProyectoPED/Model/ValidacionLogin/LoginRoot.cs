using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoPED.Model.ValidacionLogin
{
    [XmlRoot("Root")]
    public class LoginRoot
    {
        public LoginRequest Request { get; set; }

        public LoginResponse Response { get; set; }
    }
}
