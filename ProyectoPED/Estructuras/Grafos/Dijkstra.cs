using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED.Estructuras.Grafos
{
    class Dijkstra
    {
        public int origen;
        public int[] dist;
        public int[] rutas;
        public int[,] matriz;
        private List<int> queue = new List<int>();
        private List<int> ruta = new List<int>();

        public Dijkstra(int[,] matriz)
        {
            this.matriz = matriz;
            int cant = matriz.GetLength(0);
            dist = new int[cant];
            rutas = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                dist[i] = Int32.MaxValue;
                rutas[i] = -1;
                queue.Add(i);
            }
        }

        public void ObtenerRutas(int origen)
        {
            this.origen = origen;
            dist[origen] = 0;
            rutas[origen] = -1;
            int cant = matriz.GetLength(0);

            while (queue.Count > 0)
            {
                int u = SiguienteVertice();

                for (int v = 0; v < cant; v++)
                {
                    if (matriz[u, v] > 0)
                    {
                        if (dist[v] > dist[u] + matriz[u, v])
                        {
                            dist[v] = dist[u] + matriz[u, v];
                            rutas[v] = u;
                        }
                    }
                }
            }
        }

        private int SiguienteVertice()
        {
            int min = Int32.MaxValue;
            int vertice = -1;

            foreach (int j in queue)
            {
                if (dist[j] <= min)
                {
                    min = dist[j];
                    vertice = j;
                }
            }

            queue.Remove(vertice);
            return vertice;
        }

        //public string Ruta(int destino)
        //{
        //    int intermedio = rutas[destino];
        //    if (intermedio == -1)
        //        return " ";
        //    else
        //        return Ruta(intermedio) + " " + intermedio.ToString();
        //}

        public List<int> Ruta(int destino)
        {
            ruta.Clear();
            int vertice = destino;
            while (vertice != origen)
            {
                ruta.Add(vertice);
                vertice = rutas[vertice];
            }
            ruta.Add(origen);
            ruta.Reverse();
            return ruta;
        }
    }
}
