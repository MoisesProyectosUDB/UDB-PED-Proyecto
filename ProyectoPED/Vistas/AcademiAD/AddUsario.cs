﻿using ProyectoPED.Model.CargarInfo;
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

        CargarCombox cmboxestadouser = new CargarCombox();
        private void AddUsario_Load(object sender, EventArgs e)
        {
            cmboxEstadoUser.DataSource = cmboxestadouser.CargarComboEstadoUser();
            cmboxEstadoUser.DisplayMember = "Descripcion";
            cmboxEstadoUser.ValueMember = "IDEstados";
        }
    }
}