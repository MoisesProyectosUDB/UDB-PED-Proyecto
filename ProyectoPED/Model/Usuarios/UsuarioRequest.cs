using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Model.Usuarios
{
   public class UsuarioRequest
    {
        public string NombreCompleto { get; set; }

        public string Correo { get; set; }

        public string Contra { get; set; }
        public string Estado { get; set; }
        public string Rol { get; set; }
        public string Carnet { get; set; }
    }
}
