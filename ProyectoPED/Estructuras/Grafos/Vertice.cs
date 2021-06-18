using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Estructuras.Grafos
{
    class Vertice
    {
        public Point p { get; private set; }
        public string nombre { get; private set; }
        public int index { get; set; }

        public Vertice(Point p, string nombre, int index)
        {
            this.p = p;
            this.nombre = nombre;
            this.index = index;
        }
    }
}
