﻿namespace mantenimiento_proyecto
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVerificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearListaDeVerificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridPersonal = new System.Windows.Forms.DataGridView();
            this.nombe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textAmaterno = new System.Windows.Forms.TextBox();
            this.labelAmaterno = new System.Windows.Forms.Label();
            this.textApaterno = new System.Windows.Forms.TextBox();
            this.labelAPaterno = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarPersonal = new System.Windows.Forms.Button();
            this.btnEliminarPersonal = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.listaDeVerificaciónToolStripMenuItem,
            this.planAnualToolStripMenuItem,
            this.registrarPersonalToolStripMenuItem,
            this.registrarDepartamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 31);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // listaDeVerificaciónToolStripMenuItem
            // 
            this.listaDeVerificaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearListaDeVerificaciónToolStripMenuItem});
            this.listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            this.listaDeVerificaciónToolStripMenuItem.Size = new System.Drawing.Size(193, 27);
            this.listaDeVerificaciónToolStripMenuItem.Text = "Crear lista de verificación";
            this.listaDeVerificaciónToolStripMenuItem.Click += new System.EventHandler(this.listaDeVerificaciónToolStripMenuItem_Click);
            // 
            // crearListaDeVerificaciónToolStripMenuItem
            // 
            this.crearListaDeVerificaciónToolStripMenuItem.Name = "crearListaDeVerificaciónToolStripMenuItem";
            this.crearListaDeVerificaciónToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.crearListaDeVerificaciónToolStripMenuItem.Text = "Crear lista de verificación";
            // 
            // planAnualToolStripMenuItem
            // 
            this.planAnualToolStripMenuItem.Name = "planAnualToolStripMenuItem";
            this.planAnualToolStripMenuItem.Size = new System.Drawing.Size(178, 27);
            this.planAnualToolStripMenuItem.Text = "Crear Programa Anual";
            // 
            // registrarPersonalToolStripMenuItem
            // 
            this.registrarPersonalToolStripMenuItem.Name = "registrarPersonalToolStripMenuItem";
            this.registrarPersonalToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.registrarPersonalToolStripMenuItem.Text = "Registrar Personal";
            // 
            // registrarDepartamentoToolStripMenuItem
            // 
            this.registrarDepartamentoToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.registrarDepartamentoToolStripMenuItem.Name = "registrarDepartamentoToolStripMenuItem";
            this.registrarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.registrarDepartamentoToolStripMenuItem.Text = "Registrar área";
            this.registrarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.registrarDepartamentoToolStripMenuItem_Click);
            // 
            // gridPersonal
            // 
            this.gridPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombe,
            this.apellidoPaterno,
            this.area});
            this.gridPersonal.Location = new System.Drawing.Point(82, 397);
            this.gridPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.gridPersonal.Name = "gridPersonal";
            this.gridPersonal.RowHeadersWidth = 51;
            this.gridPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPersonal.RowTemplate.Height = 31;
            this.gridPersonal.Size = new System.Drawing.Size(821, 207);
            this.gridPersonal.TabIndex = 30;
            this.gridPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombe
            // 
            this.nombe.HeaderText = "Nombre";
            this.nombe.Name = "nombe";
            // 
            // apellidoPaterno
            // 
            this.apellidoPaterno.HeaderText = "Apellido Paterno";
            this.apellidoPaterno.Name = "apellidoPaterno";
            this.apellidoPaterno.ReadOnly = true;
            // 
            // area
            // 
            this.area.HeaderText = "Cargo";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textCargo);
            this.groupBox1.Controls.Add(this.labelCargo);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboArea);
            this.groupBox1.Controls.Add(this.labelArea);
            this.groupBox1.Controls.Add(this.textAmaterno);
            this.groupBox1.Controls.Add(this.labelAmaterno);
            this.groupBox1.Controls.Add(this.textApaterno);
            this.groupBox1.Controls.Add(this.labelAPaterno);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.btnAgregarPersonal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(82, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 267);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textCargo
            // 
            this.textCargo.Location = new System.Drawing.Point(171, 222);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(214, 25);
            this.textCargo.TabIndex = 59;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCargo.Location = new System.Drawing.Point(96, 222);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(65, 25);
            this.labelCargo.TabIndex = 58;
            this.labelCargo.Text = "Cargo:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "no",
            "si"});
            this.comboBox2.Location = new System.Drawing.Point(611, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.Text = "no";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(464, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Es jefe del área:";
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(480, 91);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(252, 25);
            this.comboArea.TabIndex = 55;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArea.Location = new System.Drawing.Point(420, 91);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(54, 25);
            this.labelArea.TabIndex = 54;
            this.labelArea.Text = "Area:";
            // 
            // textAmaterno
            // 
            this.textAmaterno.Location = new System.Drawing.Point(171, 180);
            this.textAmaterno.Name = "textAmaterno";
            this.textAmaterno.Size = new System.Drawing.Size(214, 25);
            this.textAmaterno.TabIndex = 53;
            // 
            // labelAmaterno
            // 
            this.labelAmaterno.AutoSize = true;
            this.labelAmaterno.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmaterno.Location = new System.Drawing.Point(14, 180);
            this.labelAmaterno.Name = "labelAmaterno";
            this.labelAmaterno.Size = new System.Drawing.Size(151, 25);
            this.labelAmaterno.TabIndex = 52;
            this.labelAmaterno.Text = "Apellido Materno:";
            // 
            // textApaterno
            // 
            this.textApaterno.Location = new System.Drawing.Point(167, 134);
            this.textApaterno.Name = "textApaterno";
            this.textApaterno.Size = new System.Drawing.Size(218, 25);
            this.textApaterno.TabIndex = 51;
            // 
            // labelAPaterno
            // 
            this.labelAPaterno.AutoSize = true;
            this.labelAPaterno.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAPaterno.Location = new System.Drawing.Point(14, 134);
            this.labelAPaterno.Name = "labelAPaterno";
            this.labelAPaterno.Size = new System.Drawing.Size(147, 25);
            this.labelAPaterno.TabIndex = 50;
            this.labelAPaterno.Text = "Apellido Paterno:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(167, 91);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(218, 25);
            this.textNombre.TabIndex = 49;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(62, 91);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(79, 25);
            this.labelNombre.TabIndex = 48;
            this.labelNombre.Text = "Nombre:";
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarPersonal.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPersonal.Location = new System.Drawing.Point(690, 211);
            this.btnAgregarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(97, 40);
            this.btnAgregarPersonal.TabIndex = 46;
            this.btnAgregarPersonal.Text = "Agregar ";
            this.btnAgregarPersonal.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(534, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Personal registrado";
            // 
            // btnModificarPersonal
            // 
            this.btnModificarPersonal.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarPersonal.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarPersonal.Location = new System.Drawing.Point(693, 343);
            this.btnModificarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarPersonal.Name = "btnModificarPersonal";
            this.btnModificarPersonal.Size = new System.Drawing.Size(97, 40);
            this.btnModificarPersonal.TabIndex = 60;
            this.btnModificarPersonal.Text = "Modificar";
            this.btnModificarPersonal.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPersonal
            // 
            this.btnEliminarPersonal.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarPersonal.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPersonal.Location = new System.Drawing.Point(806, 343);
            this.btnEliminarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPersonal.Name = "btnEliminarPersonal";
            this.btnEliminarPersonal.Size = new System.Drawing.Size(97, 40);
            this.btnEliminarPersonal.TabIndex = 59;
            this.btnEliminarPersonal.Text = "Eliminar ";
            this.btnEliminarPersonal.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 615);
            this.Controls.Add(this.btnModificarPersonal);
            this.Controls.Add(this.btnEliminarPersonal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPersonal);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar personal ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem listaDeVerificaciónToolStripMenuItem;
        private ToolStripMenuItem crearListaDeVerificaciónToolStripMenuItem;
        private ToolStripMenuItem planAnualToolStripMenuItem;
        private ToolStripMenuItem registrarPersonalToolStripMenuItem;
        private DataGridView gridPersonal;
        private ToolStripMenuItem registrarDepartamentoToolStripMenuItem;
        private DataGridViewTextBoxColumn nombe;
        private DataGridViewTextBoxColumn apellidoPaterno;
        private DataGridViewTextBoxColumn area;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboArea;
        private Label labelArea;
        private TextBox textAmaterno;
        private Label labelAmaterno;
        private TextBox textApaterno;
        private Label labelAPaterno;
        private TextBox textNombre;
        private Label labelNombre;
        private Button btnAgregarPersonal;
        private Label label2;
        private Button btnModificarPersonal;
        private Button btnEliminarPersonal;
        private TextBox textCargo;
        private Label labelCargo;
    }
}