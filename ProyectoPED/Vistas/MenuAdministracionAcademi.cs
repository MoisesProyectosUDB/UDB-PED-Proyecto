
using ProyectoPED.Vistas.AcademiAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED.Vistas
{
    public partial class MenuAdministracionAcademi : Form
    {
        public MenuAdministracionAcademi()
        {
            InitializeComponent();
        }

        private void MenuAdministracionAcademi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddUsario frmUser = new AddUsario();
            frmUser.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddCarreras frmCarrera = new AddCarreras();
            frmCarrera.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddMateria frmMateria = new AddMateria();
            frmMateria.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddInscripcion frmInscripcion = new AddInscripcion();
            frmInscripcion.ShowDialog();
        }
    }
}
