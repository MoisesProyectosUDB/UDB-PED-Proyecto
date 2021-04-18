using ProyectoPED.Model.ValidacionLogin;
using ProyectoPED.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidaCredenciales Vallogin = new ValidaCredenciales();

            if(string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else 
            {

                string Resultadologin = Vallogin.validarCredenciales(textBox1.Text, textBox2.Text);
                if (Resultadologin != "000000")
                {
                    if (Resultadologin == "000001") { MessageBox.Show("Ocurrio Algun Error al Intentar Conectarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (Resultadologin == "000002") { errorProvider1.SetError(button1, "Credenciales Invalidas"); }
                }
                else
                {
                    this.Hide();
                    MenuAdministracionAcademi FrmAcedemi = new MenuAdministracionAcademi();
                    FrmAcedemi.Show();
                }
            }

            

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                Application.Exit();
            
        }
    }
}
