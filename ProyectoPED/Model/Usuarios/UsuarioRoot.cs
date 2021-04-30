
using System.Xml.Serialization;

namespace ProyectoPED.Model.Usuarios
{
    [XmlRoot("Root")]
   public class UsuarioRoot
    {
        public UsuarioRequest Request { get; set; }

        public UsuarioResponse Response { get; set; }
    }
}
