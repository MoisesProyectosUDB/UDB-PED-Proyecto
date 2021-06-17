using ProyectoPED.Model.CargarInfo;
using ProyectoPED.Model.Orden;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPED.Vistas.ProfeAD
{
    public partial class OrdenMaterias : Form
    {
        public OrdenMaterias()
        {
            InitializeComponent();
        }
        Point coordenadas = new Point();
        private void OrdenMaterias_Load(object sender, EventArgs e)
        {
            CargarCarrera();
            coordenadas.X = 0;
            coordenadas.Y = 0;
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
            CargarCombox OpcionCargaCombox = new CargarCombox();
            int idcarera = int.Parse(cmboxCarrera.SelectedValue.ToString());
            cmboxMateria.DataSource = OpcionCargaCombox.CargarMateriasporCarreraUsuario(Login.idUsuario, idcarera);
            cmboxMateria.DisplayMember = "NombreMateria";
            cmboxMateria.ValueMember = "IDMateria";
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
                     
                }
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            coordenadas.X = e.X;
            coordenadas.Y = e.Y;
            labelCoordenadas.Text = e.X.ToString() + ", " + e.Y.ToString();
        }
    }
}
