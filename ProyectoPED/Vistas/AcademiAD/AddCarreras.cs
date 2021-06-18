using ProyectoPED.Model.CargarInfo;
using ProyectoPED.Model.Carreras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED.Vistas.AcademiAD
{
    public partial class AddCarreras : Form
    {
        public AddCarreras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carreras carrera = new Carreras();
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Todos los Campos son Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                string Resultadologin = carrera.CrearCarrera(textBox1.Text);
                if (Resultadologin != "000000")
                {
                    if (Resultadologin == "000001") { MessageBox.Show("Ocurrio Algun Error al Intentar Conectarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (Resultadologin == "000003") { errorProvider1.SetError(button1, "Error al Intentar Actualizar los Puntos"); }
                }
                else
                {
                    MessageBox.Show("Carrera Agregada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                ListarCarreras();
            }

        }


        public void limpiarCampos()
        {
            textBox1.Clear();
            errorProvider1.Clear();
            
        }

        private void ListarCarreras()
        {
            CargarTablas OpcionCargaTablas = new CargarTablas();
            dataGridView1.DataSource = OpcionCargaTablas.CargarTablaCarreras();

        }

        private void AddCarreras_Load(object sender, EventArgs e)
        {
            ListarCarreras();
        }
    }
}
