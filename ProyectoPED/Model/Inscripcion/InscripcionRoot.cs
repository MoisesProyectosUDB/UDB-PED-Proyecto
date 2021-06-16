
using System.Xml.Serialization;

namespace ProyectoPED.Model.Inscripcion
{
    [XmlRoot("Root")]
    public  class InscripcionRoot
    {
        public InscripcionRequest Request { get; set; }

        public InscripcionResponse Response { get; set; }
    }
}
