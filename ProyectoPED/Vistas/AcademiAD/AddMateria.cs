using ProyectoPED.Model.CargarInfo;
using ProyectoPED.Model.Materias;
using System;

using System.Windows.Forms;

namespace ProyectoPED.Vistas.AcademiAD
{
    public partial class AddMateria : Form
    {
        public AddMateria()
        {
            InitializeComponent();
        }
        CargarCombox OpcionCargaCombox = new CargarCombox();
        private void AddMateria_Load(object sender, EventArgs e)
        {
            //se llena combo de Carreras

            cmboxCarreras.DataSource = OpcionCargaCombox.CargarCarreras();

            cmboxCarreras.DisplayMember = "NombreCarrera";
            cmboxCarreras.ValueMember = "IDCarrera";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Materias materia = new Materias();
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("Todos los Campos son Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Resultadologin = materia.CrearMateria(textBox1.Text,textBox2.Text,(int)cmboxCarreras.SelectedValue);
                if (Resultadologin != "000000")
                {
                    if (Resultadologin == "000001") { MessageBox.Show("Ocurrio Algun Error al Intentar Conectarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (Resultadologin == "000003") { errorProvider1.SetError(button1, "Materia ya Existe"); }
                }
                else
                {
                    MessageBox.Show("Materia Agregada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
            }
        }


        public void limpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            errorProvider1.Clear();

        }


    }
}
