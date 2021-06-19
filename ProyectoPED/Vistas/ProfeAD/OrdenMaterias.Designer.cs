
namespace ProyectoPED.Vistas.ProfeAD
{
    partial class OrdenMaterias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboxMateria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCoordenadas = new System.Windows.Forms.Label();
            this.cmboxCarrera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmboxMateriaDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboxMateriaOrigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.UVtxt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmboxCarreraInicio = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.materiasTableAdapter = new ProyectoPED.Vistas.ProfeAD.DonBosco_PEDTableAdapters.MateriasTableAdapter();
            this.ordenMateriasTableAdapter = new ProyectoPED.Vistas.ProfeAD.DonBosco_PEDTableAdapters.OrdenMateriasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UVtxt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboxMateria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelCoordenadas);
            this.groupBox1.Controls.Add(this.cmboxCarrera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Materias";
            // 
            // cmboxMateria
            // 
            this.cmboxMateria.FormattingEnabled = true;
            this.cmboxMateria.Location = new System.Drawing.Point(122, 96);
            this.cmboxMateria.Name = "cmboxMateria";
            this.cmboxMateria.Size = new System.Drawing.Size(331, 28);
            this.cmboxMateria.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materias:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coordenadas";
            // 
            // labelCoordenadas
            // 
            this.labelCoordenadas.AutoSize = true;
            this.labelCoordenadas.Location = new System.Drawing.Point(292, 127);
            this.labelCoordenadas.Name = "labelCoordenadas";
            this.labelCoordenadas.Size = new System.Drawing.Size(38, 20);
            this.labelCoordenadas.TabIndex = 2;
            this.labelCoordenadas.Text = "X,Y";
            // 
            // cmboxCarrera
            // 
            this.cmboxCarrera.FormattingEnabled = true;
            this.cmboxCarrera.Location = new System.Drawing.Point(122, 37);
            this.cmboxCarrera.Name = "cmboxCarrera";
            this.cmboxCarrera.Size = new System.Drawing.Size(331, 28);
            this.cmboxCarrera.TabIndex = 1;
            this.cmboxCarrera.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carreras:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(501, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 458);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UVtxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cmboxMateriaDestino);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmboxMateriaOrigen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asociacion";
            // 
            // cmboxMateriaDestino
            // 
            this.cmboxMateriaDestino.FormattingEnabled = true;
            this.cmboxMateriaDestino.Location = new System.Drawing.Point(10, 116);
            this.cmboxMateriaDestino.Name = "cmboxMateriaDestino";
            this.cmboxMateriaDestino.Size = new System.Drawing.Size(320, 28);
            this.cmboxMateriaDestino.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Materia Destino";
            // 
            // cmboxMateriaOrigen
            // 
            this.cmboxMateriaOrigen.FormattingEnabled = true;
            this.cmboxMateriaOrigen.Location = new System.Drawing.Point(10, 58);
            this.cmboxMateriaOrigen.Name = "cmboxMateriaOrigen";
            this.cmboxMateriaOrigen.Size = new System.Drawing.Size(320, 28);
            this.cmboxMateriaOrigen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Materia Origen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "UV";
            // 
            // UVtxt
            // 
            this.UVtxt.Location = new System.Drawing.Point(14, 186);
            this.UVtxt.Name = "UVtxt";
            this.UVtxt.Size = new System.Drawing.Size(120, 26);
            this.UVtxt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(517, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Materia Origen";
            // 
            // cmboxCarreraInicio
            // 
            this.cmboxCarreraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxCarreraInicio.FormattingEnabled = true;
            this.cmboxCarreraInicio.Location = new System.Drawing.Point(662, 48);
            this.cmboxCarreraInicio.Name = "cmboxCarreraInicio";
            this.cmboxCarreraInicio.Size = new System.Drawing.Size(424, 28);
            this.cmboxCarreraInicio.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(1104, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Encontrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // ordenMateriasTableAdapter
            // 
            this.ordenMateriasTableAdapter.ClearBeforeFill = true;
            // 
            // OrdenMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 573);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmboxCarreraInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrdenMaterias";
            this.Text = "OrdenMaterias";
            this.Load += new System.EventHandler(this.OrdenMaterias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UVtxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCoordenadas;
        private System.Windows.Forms.ComboBox cmboxCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmboxMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DonBosco_PEDTableAdapters.MateriasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmboxMateriaDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboxMateriaOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UVtxt;
        private System.Windows.Forms.ComboBox cmboxCarreraInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private DonBosco_PEDTableAdapters.OrdenMateriasTableAdapter ordenMateriasTableAdapter;
    }
}