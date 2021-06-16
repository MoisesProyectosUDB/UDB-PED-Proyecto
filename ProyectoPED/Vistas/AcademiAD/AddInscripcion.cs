using ProyectoPED.Model.CargarInfo;
using ProyectoPED.Model.Inscripcion;
using System;

using System.Windows.Forms;

namespace ProyectoPED.Vistas.AcademiAD
{
    public partial class AddInscripcion : Form
    {
        public AddInscripcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         Inscripcion inscripcion = new Inscripcion();
        if (comboBox1.SelectedIndex==-1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los Campos son Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }else
            {
                string Resultadologin = inscripcion.CrearInscripcion((int)comboBox1.SelectedValue, (int)comboBox2.SelectedValue, (int)comboBox3.SelectedValue);
                if (Resultadologin != "000000")
                {
                    if (Resultadologin == "000001") { MessageBox.Show("Ocurrio Algun Error al Intentar Conectarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (Resultadologin == "000003") { errorProvider1.SetError(button1, "La relacion de datos Existentes"); }
                }
                else
                {
                    MessageBox.Show("Usuario Agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarEstudiantes();
                    ListarMestros();
                }
            }
        }
       
        private void AddInscripcion_Load(object sender, EventArgs e)
        {
            ListarEstudiantes();
            ListarMestros();
            ListarUusuariosAll();
            ListarCarreras();
        }

        private void ListarEstudiantes()
        {
            CargarTablas OpcionCargaTablas = new CargarTablas();
            dataGridView1.DataSource = OpcionCargaTablas.CargarTablaInscrpcionEstudiantes();

        }
        private void ListarMestros()
        {
            CargarTablas OpcionCargaTablas = new CargarTablas();
            dataGridView2.DataSource = OpcionCargaTablas.CargarTablaInscrpcionProfesores();

        }

        private void ListarUusuariosAll()
        {
            CargarCombox OpcionCargaCombox = new CargarCombox();
            comboBox1.DataSource = OpcionCargaCombox.CargarAllUser();
            comboBox1.DisplayMember = "NombreCompleto";
            comboBox1.ValueMember = "IDUsuario";

        }

        private void ListarCarreras()
        {
            CargarCombox OpcionCargaCombox = new CargarCombox();
            comboBox2.DataSource = OpcionCargaCombox.CargarCarreras();
            comboBox2.DisplayMember = "NombreCarrera";
            comboBox2.ValueMember = "IDCarrera";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCombox OpcionCargaCombox = new CargarCombox();
            int idcarera = int.Parse(comboBox2.SelectedValue.ToString());
            comboBox3.DataSource = OpcionCargaCombox.CargarMateriasporCarrera(idcarera);
            comboBox3.DisplayMember = "NombreMateria";
            comboBox3.ValueMember = "IDMateria";
        }

        public void limpiarCampos()
        {
            comboBox1.SelectedIndex=-1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;             
            errorProvider1.Clear();
        }
    }
}
