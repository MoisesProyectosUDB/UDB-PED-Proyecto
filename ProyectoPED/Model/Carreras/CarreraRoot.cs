
using System.Xml.Serialization;

namespace ProyectoPED.Model.Carreras
{
    [XmlRoot("Root")]
    public class CarreraRoot
    {
        public CarreraRequest Request { get; set; }

        public CarreraResponse Response { get; set; }
    }
}
