using ProyectoPED.Estructuras.Grafos;
using ProyectoPED.Model.CargarInfo;
using ProyectoPED.Model.Orden;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace ProyectoPED.Vistas.ProfeAD
{
    public partial class OrdenMaterias : Form
    {
        public OrdenMaterias()
        {
            InitializeComponent();
        }
        Point coordenadas = new Point();
        private List<Vertice> Vertices = new List<Vertice>();
        private List<Arco> Arcos = new List<Arco>();
        private List<int> Ruta = new List<int>();
        private void OrdenMaterias_Load(object sender, EventArgs e)
        {
            CargarCarrera();
            coordenadas.X = 0;
            coordenadas.Y = 0;
            CargarCarrerasIniciales();
            CargarCaminoIniciales();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            Orden agregar = new Orden();
            if (cmboxCarrera.SelectedIndex==-1 || cmboxMateria.SelectedIndex==-1|| coordenadas.X==0 || coordenadas.Y ==0)
            {
                MessageBox.Show("Todos los Campos son Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                int idmateria= int.Parse(cmboxMateria.SelectedValue.ToString());
                string Resultadologin = agregar.Update(idmateria, coordenadas.X, coordenadas.Y);
                if (Resultadologin != "000000")
                {
                    if (Resultadologin == "000001") { MessageBox.Show("Ocurrio Algun Error al Intentar Conectarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (Resultadologin == "000003") { errorProvider1.SetError(button1, "Carrera ya Existe"); }
                }
                else
                {
                    MessageBox.Show("Carrera Agregada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vertices.Add(new Vertice(coordenadas, cmboxMateria.Text.Substring(1, 6), Vertices.Count));
                    DibujarVertice(Vertices.Count - 1, false);
                    cargarComboxGraficos();
                }
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            coordenadas.X = e.X;
            coordenadas.Y = e.Y;
            labelCoordenadas.Text = e.X.ToString() + ", " + e.Y.ToString();
        }


        private void CargarCarrera()
        {
            CargarCombox OpcionCargaCombox = new CargarCombox();
            cmboxCarrera.DataSource = OpcionCargaCombox.CargarCarrerasporUsario(Login.idUsuario);
            cmboxCarrera.DisplayMember = "NombreCarrera";
            cmboxCarrera.ValueMember = "IDCarrera";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarComboxGraficos();
        }

        private void cargarComboxGraficos()
        {
            CargarCombox OpcionCargaCombox = new CargarCombox();
            int idcarera = int.Parse(cmboxCarrera.SelectedValue.ToString());
            cmboxMateria.DataSource = OpcionCargaCombox.CargarMateriasporCarrera(idcarera);
            cmboxMateria.DisplayMember = "NombreMateria";
            cmboxMateria.ValueMember = "IDMateria";

            cmboxMateriaOrigen.DataSource = OpcionCargaCombox.CargarMateriasporCarreraG(idcarera);
            cmboxMateriaOrigen.DisplayMember = "NombreMateria";
            cmboxMateriaOrigen.ValueMember = "IDMateria";

            cmboxMateriaDestino.DataSource = OpcionCargaCombox.CargarMateriasporCarreraG(idcarera);
            cmboxMateriaDestino.DisplayMember = "NombreMateria";
            cmboxMateriaDestino.ValueMember = "IDMateria";

            cmboxCarreraInicio.DataSource = OpcionCargaCombox.CargarMateriasporCarreraG(idcarera);
            cmboxCarreraInicio.DisplayMember = "NombreMateria";
            cmboxCarreraInicio.ValueMember = "IDMateria";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int cantidad = (int)this.materiasTableAdapter.CountQueryPersonalizado();
            for (int i = 0; i < cantidad; i++)
            {
                DibujarVertice(i, false);
            }

            cantidad = (int)this.ordenMateriasTableAdapter.CountQuery();
            for (int i = 0; i < cantidad; i++)
            {
                DibujarArco(i, false);
            }
            for (int i = 0; i < Ruta.Count ; i++)
            {
                DibujarVertice(Ruta[i], true);
                for (int j = 0; j < Arcos.Count; j++)
                {
                    if ((Arcos[j].origen == Ruta[i]) && (Arcos[j].destino == Ruta[i + 1]))
                        DibujarArco(j, true);
                }
            }
            if (Ruta.Count > 0)
                DibujarVertice(Ruta.Count - 1, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orden agregar = new Orden();
            if (cmboxMateriaOrigen.SelectedValue == cmboxMateriaDestino.SelectedValue)
            {
                MessageBox.Show("No se puede agregar un camino hacia la misma ciudad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
                return;
            }


            //try
            //{
                int idmateriaOrigen = int.Parse(cmboxMateriaOrigen.SelectedValue.ToString());
                int idmateriaDestino = int.Parse(cmboxMateriaDestino.SelectedValue.ToString());
                int peso = (int)UVtxt.Value; 
                string Resultadologin = agregar.CrearCamino(idmateriaOrigen, idmateriaDestino, peso);
                if (Resultadologin != "000000")
                {
                    if (Resultadologin == "000001") { MessageBox.Show("Ocurrio Algun Error al Intentar Conectarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (Resultadologin == "000003") { errorProvider1.SetError(button2, "Relacion ya Existe"); }
                }else 
                {
                    int origen = Int32.Parse(cmboxMateriaOrigen.SelectedValue.ToString());
                    string sOrigen = Vertices[origen].nombre;
                    int destino = Int32.Parse(cmboxMateriaDestino.SelectedValue.ToString());
                    string sDestino = Vertices[destino].nombre;
                    int distancia = (int)UVtxt.Value;
                    Arcos.Add(new Arco(origen, destino, distancia));
                    DibujarArco(Arcos.Count - 1, false);
                }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error  en Arcos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void DibujarVertice(int vertice, bool esRuta)
        {
            Graphics g = panel1.CreateGraphics();
            Vertice p = Vertices[vertice];
            Pen lapiz = new Pen(Color.DarkGreen);
            SolidBrush brush;
            if (!esRuta)
                brush = new SolidBrush(Color.Blue);
            else
                brush = new SolidBrush(Color.HotPink);


            g.DrawRectangle(lapiz, p.p.X - 15, p.p.Y - 15, 130, 100);
            g.FillRectangle(brush, p.p.X - 15, p.p.Y - 15, 130, 100);
            g.DrawString(p.nombre, new Font("Verdana", 11, FontStyle.Bold), new SolidBrush(Color.White), p.p.X + 22, p.p.Y);
            g.Dispose();

        }
        private void DibujarArco(int arco, bool esRuta)
        {
            Graphics g = panel1.CreateGraphics();
            Arco p = Arcos[arco];
            //Vertice origen = Vertices[p.origen == 0 ? p.origen : p.origen-1]  ;
            //Vertice destino = Vertices[p.destino == 0 ? p.destino : p.destino - 1];
            Vertice origen = Vertices[p.origen];
            Vertice destino = Vertices[p.destino];
            Point pOrigen;
            Point pDestino;
            Pen pen;

            //pOrigen = new Point(origen.p.X + (origen.p.X < destino.p.X ? 2 : -2) * 1, origen.p.Y);
            //pDestino = new Point(destino.p.X + (origen.p.X < destino.p.X ? -2 : 2) * 1, destino.p.Y);
            pOrigen = origen.p;
            pDestino = destino.p;

            if (!esRuta)
                pen = new Pen(Color.Black, 4);
            else
                pen = new Pen(Color.Red, 5);

            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.ArrowAnchor;

            g.DrawString(p.distancia.ToString(), new Font("Verdana", 11, FontStyle.Bold), new SolidBrush(Color.Red), new Point((pOrigen.X + pDestino.X) / 2, (pOrigen.Y + pDestino.Y) / 2 + (pOrigen.Y < pDestino.Y ? (-30) : 15)));
            g.DrawLine(pen, origen.p, destino.p);

            g.Dispose();
        }

        private void CargarCarrerasIniciales()
        {
            int cantidad = (int)this.materiasTableAdapter.CountQueryPersonalizado();
            string nombre;
            Point c = new Point();
            for (int i = 0; i < cantidad; i++)
            {
                nombre = this.materiasTableAdapter.GetData()[i].CodigoMateria;
                c.X = this.materiasTableAdapter.GetData()[i].posicion_x;
                c.Y = this.materiasTableAdapter.GetData()[i].posicion_Y;
                Vertices.Add(new Vertice(c, nombre, i));
            }
        }

        private void CargarCaminoIniciales()
        {
            int cantidad = (int)this.ordenMateriasTableAdapter.CountQuery();
            int origen;
            int destino;
            int distancia;
            for (int i = 0; i < cantidad; i++)
            {
                origen = this.ordenMateriasTableAdapter.GetData()[i].IdMateriaOrigen;
                destino = this.ordenMateriasTableAdapter.GetData()[i].IdMateriaDestino;
                distancia = this.ordenMateriasTableAdapter.GetData()[i].Peso;
                Arcos.Add(new Arco(origen, destino, distancia));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int origen = Int32.Parse(cmboxCarreraInicio.SelectedValue.ToString());
            int destino = (int)this.materiasTableAdapter.CountQueryPersonalizado()-1;
            int[,] adyacencia = new int[Vertices.Count, Vertices.Count];            
            Ruta.Clear();
            for (int i = 0; i < Vertices.Count; i++)
            {
                for (int j = 0; j < Vertices.Count; j++)
                {
                    if (i == j)
                    {
                        adyacencia[i, j] = 0;
                    }
                    else
                    {
                        
                            adyacencia[i, j] = -1;
                        
                    }
                }
            }
            foreach (Arco arco in Arcos)
            {
                adyacencia[arco.origen, arco.destino] = arco.distancia;
            }

            Dijkstra dijkstra = new Dijkstra(adyacencia);
            dijkstra.ObtenerRutas(origen);
            // textBoxRuta.Text = dijkstra.Ruta(destino) + " --> " + destino.ToString();
            Ruta = dijkstra.Ruta(destino);

            panel1.Invalidate();
        }
    }
}
