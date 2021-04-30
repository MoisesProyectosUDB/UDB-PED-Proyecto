using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoPED.Model.Materias
{
    [XmlRoot("Root")]
    public class MateriaRoot
    {
        public MateriaRequest Request { get; set; }

        public MateriaResponse Response { get; set; }
    }
}
