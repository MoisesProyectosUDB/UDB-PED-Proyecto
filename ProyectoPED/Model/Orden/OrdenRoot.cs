 
using System.Xml.Serialization;

namespace ProyectoPED.Model.Orden
{
    [XmlRoot("Root")]
    public class OrdenRoot
    {

        public OrdenRequest Request { get; set; }

        public OrdenResponse Response { get; set; }
    }
}
