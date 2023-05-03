namespace mantenimiento_proyecto
{
    partial class FormProgramaAnual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgramaAnual));
            labelPeriodo = new Label();
            comboPeriodos = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            labelServicio = new Label();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            listaDeVerificaciónToolStripMenuItem = new ToolStripMenuItem();
            planAnualToolStripMenuItem = new ToolStripMenuItem();
            registrarPersonalToolStripMenuItem = new ToolStripMenuItem();
            numericAnio = new NumericUpDown();
            fechaElaboracion = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            fechaAprobacion = new DateTimePicker();
            comboAreas = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnCargarServicio = new Button();
            btnGenerar = new Button();
            textElaboro = new TextBox();
            textAprobo = new TextBox();
            pictureBox1 = new PictureBox();
            registrarDepartamentoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPeriodo.Location = new Point(538, 95);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(73, 25);
            labelPeriodo.TabIndex = 2;
            labelPeriodo.Text = "Periodo";
            labelPeriodo.Click += label1_Click;
            // 
            // comboPeriodos
            // 
            comboPeriodos.AutoCompleteCustomSource.AddRange(new string[] { "ene-jun", "ago-dic" });
            comboPeriodos.DisplayMember = "enero-junio";
            comboPeriodos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPeriodos.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboPeriodos.FormattingEnabled = true;
            comboPeriodos.Items.AddRange(new object[] { "enero-junio", "agosto-diciembre" });
            comboPeriodos.Location = new Point(632, 95);
            comboPeriodos.Name = "comboPeriodos";
            comboPeriodos.Size = new Size(177, 30);
            comboPeriodos.TabIndex = 3;
            comboPeriodos.Tag = "enero-junio";
            comboPeriodos.ValueMember = "enero-junio";
            comboPeriodos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(41, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(421, 29);
            label2.TabIndex = 5;
            label2.Text = "Elaborar Programa anual de mantenimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(851, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 26);
            label3.TabIndex = 6;
            label3.Text = "Año";
            label3.Click += label3_Click;
            // 
            // labelServicio
            // 
            labelServicio.AutoSize = true;
            labelServicio.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelServicio.Location = new Point(791, 354);
            labelServicio.Name = "labelServicio";
            labelServicio.Size = new Size(89, 25);
            labelServicio.TabIndex = 10;
            labelServicio.Text = "Servicios:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, registrarDepartamentoToolStripMenuItem, listaDeVerificaciónToolStripMenuItem, planAnualToolStripMenuItem, registrarPersonalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1083, 31);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Image = (Image)resources.GetObject("inicioToolStripMenuItem.Image");
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(77, 27);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click_1;
            // 
            // listaDeVerificaciónToolStripMenuItem
            // 
            listaDeVerificaciónToolStripMenuItem.Image = (Image)resources.GetObject("listaDeVerificaciónToolStripMenuItem.Image");
            listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            listaDeVerificaciónToolStripMenuItem.Size = new Size(213, 27);
            listaDeVerificaciónToolStripMenuItem.Text = "Crear lista de verificación";
            listaDeVerificaciónToolStripMenuItem.Click += listaDeVerificaciónToolStripMenuItem_Click;
            // 
            // planAnualToolStripMenuItem
            // 
            planAnualToolStripMenuItem.Image = (Image)resources.GetObject("planAnualToolStripMenuItem.Image");
            planAnualToolStripMenuItem.Name = "planAnualToolStripMenuItem";
            planAnualToolStripMenuItem.Size = new Size(198, 27);
            planAnualToolStripMenuItem.Text = "Crear Programa Anual";
            // 
            // registrarPersonalToolStripMenuItem
            // 
            registrarPersonalToolStripMenuItem.Image = (Image)resources.GetObject("registrarPersonalToolStripMenuItem.Image");
            registrarPersonalToolStripMenuItem.Name = "registrarPersonalToolStripMenuItem";
            registrarPersonalToolStripMenuItem.Size = new Size(170, 27);
            registrarPersonalToolStripMenuItem.Text = "Registrar Personal";
            registrarPersonalToolStripMenuItem.Click += registrarPersonalToolStripMenuItem_Click;
            // 
            // numericAnio
            // 
            numericAnio.Location = new Point(908, 98);
            numericAnio.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numericAnio.Minimum = new decimal(new int[] { 2010, 0, 0, 0 });
            numericAnio.Name = "numericAnio";
            numericAnio.Size = new Size(120, 23);
            numericAnio.TabIndex = 19;
            numericAnio.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            numericAnio.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // fechaElaboracion
            // 
            fechaElaboracion.Location = new Point(770, 171);
            fechaElaboracion.Name = "fechaElaboracion";
            fechaElaboracion.Size = new Size(258, 23);
            fechaElaboracion.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(583, 173);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 33;
            label1.Text = "Fecha de elaboración:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(583, 210);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 23);
            label4.TabIndex = 35;
            label4.Text = "Fecha de aprobación:";
            // 
            // fechaAprobacion
            // 
            fechaAprobacion.Location = new Point(770, 208);
            fechaAprobacion.Name = "fechaAprobacion";
            fechaAprobacion.Size = new Size(258, 23);
            fechaAprobacion.TabIndex = 34;
            // 
            // comboAreas
            // 
            comboAreas.AutoCompleteCustomSource.AddRange(new string[] { "ene-jun", "ago-dic" });
            comboAreas.DisplayMember = "enero-junio";
            comboAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAreas.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboAreas.FormattingEnabled = true;
            comboAreas.Items.AddRange(new object[] { "enero-junio", "agosto-diciembre" });
            comboAreas.Location = new Point(720, 277);
            comboAreas.Name = "comboAreas";
            comboAreas.Size = new Size(308, 30);
            comboAreas.TabIndex = 37;
            comboAreas.SelectedIndexChanged += comboAreas_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(606, 277);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 36;
            label8.Text = "Área a tratar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(62, 174);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 38;
            label9.Text = "Elaboró:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(62, 237);
            label10.Name = "label10";
            label10.Size = new Size(65, 23);
            label10.TabIndex = 40;
            label10.Text = "Aprobó:";
            // 
            // btnCargarServicio
            // 
            btnCargarServicio.BackColor = SystemColors.ControlLight;
            btnCargarServicio.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarServicio.Location = new Point(900, 348);
            btnCargarServicio.Margin = new Padding(2);
            btnCargarServicio.Name = "btnCargarServicio";
            btnCargarServicio.Size = new Size(128, 34);
            btnCargarServicio.TabIndex = 18;
            btnCargarServicio.Text = "Cargar servicio";
            btnCargarServicio.UseVisualStyleBackColor = false;
            btnCargarServicio.Click += btnCargarServicio_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = SystemColors.ControlLight;
            btnGenerar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.ImageAlign = ContentAlignment.TopLeft;
            btnGenerar.Location = new Point(538, 484);
            btnGenerar.Margin = new Padding(2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(144, 61);
            btnGenerar.TabIndex = 42;
            btnGenerar.Text = "Generar documento";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // textElaboro
            // 
            textElaboro.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textElaboro.Location = new Point(136, 174);
            textElaboro.Margin = new Padding(3, 2, 3, 2);
            textElaboro.Name = "textElaboro";
            textElaboro.PlaceholderText = "Nombre de jefe de dpto. de Mantenimiento";
            textElaboro.Size = new Size(370, 26);
            textElaboro.TabIndex = 44;
            // 
            // textAprobo
            // 
            textAprobo.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textAprobo.Location = new Point(136, 237);
            textAprobo.Margin = new Padding(3, 2, 3, 2);
            textAprobo.Name = "textAprobo";
            textAprobo.PlaceholderText = "Nombre de jefe de dpto. de Recursos";
            textAprobo.Size = new Size(370, 26);
            textAprobo.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 375);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // registrarDepartamentoToolStripMenuItem
            // 
            registrarDepartamentoToolStripMenuItem.BackColor = Color.Transparent;
            registrarDepartamentoToolStripMenuItem.Image = (Image)resources.GetObject("registrarDepartamentoToolStripMenuItem.Image");
            registrarDepartamentoToolStripMenuItem.Name = "registrarDepartamentoToolStripMenuItem";
            registrarDepartamentoToolStripMenuItem.Size = new Size(83, 27);
            registrarDepartamentoToolStripMenuItem.Text = "Áreas";
            registrarDepartamentoToolStripMenuItem.Click += registrarDepartamentoToolStripMenuItem_Click;
            // 
            // FormProgramaAnual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1083, 566);
            Controls.Add(pictureBox1);
            Controls.Add(textAprobo);
            Controls.Add(textElaboro);
            Controls.Add(btnGenerar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(comboAreas);
            Controls.Add(btnCargarServicio);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(fechaAprobacion);
            Controls.Add(label1);
            Controls.Add(fechaElaboracion);
            Controls.Add(numericAnio);
            Controls.Add(menuStrip1);
            Controls.Add(labelServicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboPeriodos);
            Controls.Add(labelPeriodo);
            Name = "FormProgramaAnual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa anual";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPeriodo;
        private ComboBox comboPeriodos;
        private Label label2;
        private Label label3;
        private Label labelServicio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem listaDeVerificaciónToolStripMenuItem;
        private ToolStripMenuItem planAnualToolStripMenuItem;
        private ToolStripMenuItem registrarPersonalToolStripMenuItem;
        private NumericUpDown numericAnio;
        private DateTimePicker fechaElaboracion;
        private Label label1;
        private Label label4;
        private DateTimePicker fechaAprobacion;
        private ComboBox comboAreas;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnCargarServicio;
        private Button btnGenerar;
        private TextBox textElaboro;
        private TextBox textAprobo;
        private PictureBox pictureBox1;
        private ToolStripMenuItem registrarDepartamentoToolStripMenuItem;
    }
}