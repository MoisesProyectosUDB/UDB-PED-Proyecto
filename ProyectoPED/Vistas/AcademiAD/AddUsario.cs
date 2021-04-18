using ProyectoPED.Model.CargarInfo;
using ProyectoPED.Model.Usuarios;
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
    public partial class AddUsario : Form
    {
        public AddUsario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        CargarCombox OpcionCargaCombox= new CargarCombox();
        private void AddUsario_Load(object sender, EventArgs e)
        {
            //se llena combo de estados
            
            cmboxEstadoUser.DataSource = OpcionCargaCombox.CargarComboEstadoUser();
        
            cmboxEstadoUser.DisplayMember = "Descripcion";
            cmboxEstadoUser.ValueMember = "IDEstados";
           
            //se llena combo de Roles
            cmboxRoles.DataSource = OpcionCargaCombox.CargarRoles();
            cmboxRoles.DisplayMember = "Descripcion";
            cmboxRoles.ValueMember = "IDRol";
         



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Usuarios usuer = new Usuarios();
            
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrEmpty(textBox2.Text.Trim()) || string.IsNullOrEmpty(textBox3.Text.Trim()) || string.IsNullOrEmpty(textBox4.Text.Trim())) 
            {
                MessageBox.Show("Todos los Campos son Requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else 
            {

                string Resultadologin = usuer.CrearUsuario(textBox1.Text, textBox2.Text, textBox4.Text, (int)cmboxEstadoUser.SelectedValue, (int)cmboxRoles.SelectedValue, textBox3.Text);
                if (Resultadologin != "000000")
                {
                    if (Resultadologin == "000001") { MessageBox.Show("Ocurrio Algun Error al Intentar Conectarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (Resultadologin == "000003") { errorProvider1.SetError(button1, "Correo o Carnet ya Exisen"); }
                }
                else
                {
                    MessageBox.Show("Usuario Agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
            }



        }


        public void limpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            errorProvider1.Clear();
        }
    }
}
