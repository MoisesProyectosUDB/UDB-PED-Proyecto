using ProyectoPED.Vistas.ProfeAD;
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
    public partial class MenuAdministracionProfe : Form
    {
        public MenuAdministracionProfe()
        {
            InitializeComponent();
        }

        private void MenuAdministracionProfe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuAdministracionProfe_Load(object sender, EventArgs e)
        {
            
            label2.Text = Login.idUsuario;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddActividades frmActi= new AddActividades();
            frmActi.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OrdenMaterias frmActi = new OrdenMaterias();
            frmActi.ShowDialog();
        }
    }
}
