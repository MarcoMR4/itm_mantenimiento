namespace mantenimiento_proyecto
{
    partial class FormListaNueva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaNueva));
            label1 = new Label();
            comboAreas = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            comboEspacios = new ComboBox();
            label3 = new Label();
            btnCargarEspacio = new Button();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            registrarDepartamentoToolStripMenuItem = new ToolStripMenuItem();
            registrarPersonalToolStripMenuItem = new ToolStripMenuItem();
            listaDeVerificaciónToolStripMenuItem = new ToolStripMenuItem();
            crearListaDeVerificaciónToolStripMenuItem = new ToolStripMenuItem();
            planAnualToolStripMenuItem = new ToolStripMenuItem();
            textFecha = new DateTimePicker();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            btnImprimir = new Button();
            comboJefeArea = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            labelAnio = new Label();
            numericAnio = new NumericUpDown();
            comboPeriodo = new ComboBox();
            nombreJefe = new TextBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(615, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(409, 34);
            label1.TabIndex = 4;
            label1.Text = "Elaborar lista de verificación";
            // 
            // comboAreas
            // 
            comboAreas.AutoCompleteCustomSource.AddRange(new string[] { "ene-jun", "ago-dic" });
            comboAreas.DisplayMember = "enero-junio";
            comboAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAreas.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboAreas.FormattingEnabled = true;
            comboAreas.Items.AddRange(new object[] { "Personal Registrado 1" });
            comboAreas.Location = new Point(76, 119);
            comboAreas.Name = "comboAreas";
            comboAreas.Size = new Size(308, 30);
            comboAreas.TabIndex = 19;
            comboAreas.SelectedIndexChanged += comboAreas_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(248, 94);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 18;
            label7.Text = "Área verificada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 182);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 21;
            // 
            // comboEspacios
            // 
            comboEspacios.AutoCompleteCustomSource.AddRange(new string[] { "ene-jun", "ago-dic" });
            comboEspacios.DisplayMember = "enero-junio";
            comboEspacios.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEspacios.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboEspacios.FormattingEnabled = true;
            comboEspacios.Items.AddRange(new object[] { "Edificio AG", "Edificio F" });
            comboEspacios.Location = new Point(432, 259);
            comboEspacios.Name = "comboEspacios";
            comboEspacios.Size = new Size(353, 30);
            comboEspacios.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(273, 259);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 23;
            label3.Text = "Espacio revisado:";
            // 
            // btnCargarEspacio
            // 
            btnCargarEspacio.BackColor = Color.Gainsboro;
            btnCargarEspacio.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarEspacio.Location = new Point(631, 190);
            btnCargarEspacio.Margin = new Padding(2);
            btnCargarEspacio.Name = "btnCargarEspacio";
            btnCargarEspacio.Size = new Size(154, 29);
            btnCargarEspacio.TabIndex = 27;
            btnCargarEspacio.Text = "Ver Espacios";
            btnCargarEspacio.UseVisualStyleBackColor = false;
            btnCargarEspacio.Click += btnCargarEspacio_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, registrarDepartamentoToolStripMenuItem, registrarPersonalToolStripMenuItem, listaDeVerificaciónToolStripMenuItem, planAnualToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1024, 31);
            menuStrip1.TabIndex = 28;
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
            // registrarDepartamentoToolStripMenuItem
            // 
            registrarDepartamentoToolStripMenuItem.BackColor = Color.Transparent;
            registrarDepartamentoToolStripMenuItem.Image = (Image)resources.GetObject("registrarDepartamentoToolStripMenuItem.Image");
            registrarDepartamentoToolStripMenuItem.Name = "registrarDepartamentoToolStripMenuItem";
            registrarDepartamentoToolStripMenuItem.Size = new Size(83, 27);
            registrarDepartamentoToolStripMenuItem.Text = "Áreas";
            registrarDepartamentoToolStripMenuItem.Click += registrarDepartamentoToolStripMenuItem_Click;
            // 
            // registrarPersonalToolStripMenuItem
            // 
            registrarPersonalToolStripMenuItem.Image = (Image)resources.GetObject("registrarPersonalToolStripMenuItem.Image");
            registrarPersonalToolStripMenuItem.Name = "registrarPersonalToolStripMenuItem";
            registrarPersonalToolStripMenuItem.Size = new Size(170, 27);
            registrarPersonalToolStripMenuItem.Text = "Registrar Personal";
            registrarPersonalToolStripMenuItem.Click += registrarPersonalToolStripMenuItem_Click;
            // 
            // listaDeVerificaciónToolStripMenuItem
            // 
            listaDeVerificaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearListaDeVerificaciónToolStripMenuItem });
            listaDeVerificaciónToolStripMenuItem.Image = (Image)resources.GetObject("listaDeVerificaciónToolStripMenuItem.Image");
            listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            listaDeVerificaciónToolStripMenuItem.Size = new Size(221, 27);
            listaDeVerificaciónToolStripMenuItem.Text = "Crear listas de verificación";
            listaDeVerificaciónToolStripMenuItem.Click += listaDeVerificaciónToolStripMenuItem_Click;
            // 
            // crearListaDeVerificaciónToolStripMenuItem
            // 
            crearListaDeVerificaciónToolStripMenuItem.Name = "crearListaDeVerificaciónToolStripMenuItem";
            crearListaDeVerificaciónToolStripMenuItem.Size = new Size(251, 28);
            crearListaDeVerificaciónToolStripMenuItem.Text = "Crear lista de verificación";
            // 
            // planAnualToolStripMenuItem
            // 
            planAnualToolStripMenuItem.Image = (Image)resources.GetObject("planAnualToolStripMenuItem.Image");
            planAnualToolStripMenuItem.Name = "planAnualToolStripMenuItem";
            planAnualToolStripMenuItem.Size = new Size(198, 27);
            planAnualToolStripMenuItem.Text = "Crear Programa Anual";
            planAnualToolStripMenuItem.Click += planAnualToolStripMenuItem_Click;
            // 
            // textFecha
            // 
            textFecha.Location = new Point(527, 124);
            textFecha.Name = "textFecha";
            textFecha.Size = new Size(258, 23);
            textFecha.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(527, 99);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 32;
            label8.Text = "Fecha:";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "ene-jun", "ago-dic" });
            comboBox1.DisplayMember = "enero-junio";
            comboBox1.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mantenimiento de equipo" });
            comboBox1.Location = new Point(631, 432);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(350, 31);
            comboBox1.TabIndex = 34;
            comboBox1.Text = "Mantenimiento de equipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(412, 432);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 33;
            label2.Text = "Departamento que elabora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(444, 466);
            label5.Name = "label5";
            label5.Size = new Size(168, 23);
            label5.TabIndex = 35;
            label5.Text = "Jefe del departamento:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(631, 318);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(154, 38);
            button1.TabIndex = 37;
            button1.Text = "Ver Hallazgos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.Gainsboro;
            btnImprimir.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Location = new Point(560, 528);
            btnImprimir.Margin = new Padding(2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(167, 43);
            btnImprimir.TabIndex = 38;
            btnImprimir.Text = "Generar Lista";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // comboJefeArea
            // 
            comboJefeArea.AutoCompleteCustomSource.AddRange(new string[] { "ene-jun", "ago-dic" });
            comboJefeArea.DisplayMember = "enero-junio";
            comboJefeArea.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboJefeArea.FormattingEnabled = true;
            comboJefeArea.Items.AddRange(new object[] { "Personal Registrado 1" });
            comboJefeArea.Location = new Point(76, 190);
            comboJefeArea.Name = "comboJefeArea";
            comboJefeArea.Size = new Size(308, 30);
            comboJefeArea.TabIndex = 41;
            comboJefeArea.SelectedIndexChanged += comboJefeArea_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(181, 165);
            label6.Name = "label6";
            label6.Size = new Size(203, 25);
            label6.TabIndex = 40;
            label6.Text = "Jefe del área verificada:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(100, 322);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 42;
            label9.Text = "Periodo:";
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnio.Location = new Point(100, 358);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(48, 25);
            labelAnio.TabIndex = 43;
            labelAnio.Text = "Año:";
            // 
            // numericAnio
            // 
            numericAnio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numericAnio.Location = new Point(184, 358);
            numericAnio.Maximum = new decimal(new int[] { 2033, 0, 0, 0 });
            numericAnio.Minimum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericAnio.Name = "numericAnio";
            numericAnio.Size = new Size(144, 23);
            numericAnio.TabIndex = 44;
            numericAnio.Tag = "2023";
            numericAnio.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // comboPeriodo
            // 
            comboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPeriodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboPeriodo.FormattingEnabled = true;
            comboPeriodo.Items.AddRange(new object[] { "enero-junio", "agosto-diciembre" });
            comboPeriodo.Location = new Point(184, 322);
            comboPeriodo.Name = "comboPeriodo";
            comboPeriodo.Size = new Size(144, 23);
            comboPeriodo.TabIndex = 45;
            // 
            // nombreJefe
            // 
            nombreJefe.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nombreJefe.Location = new Point(631, 468);
            nombreJefe.Name = "nombreJefe";
            nombreJefe.PlaceholderText = "escriba nombre de jefe de dpto. de Mantenimiento";
            nombreJefe.Size = new Size(350, 26);
            nombreJefe.TabIndex = 46;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 432);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // FormListaNueva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1024, 582);
            Controls.Add(pictureBox1);
            Controls.Add(nombreJefe);
            Controls.Add(comboPeriodo);
            Controls.Add(numericAnio);
            Controls.Add(labelAnio);
            Controls.Add(label9);
            Controls.Add(comboJefeArea);
            Controls.Add(label6);
            Controls.Add(btnImprimir);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(textFecha);
            Controls.Add(menuStrip1);
            Controls.Add(btnCargarEspacio);
            Controls.Add(comboEspacios);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(comboAreas);
            Controls.Add(label7);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormListaNueva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listas de verificación";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormListaNueva_FormClosed;
            Load += FormListaNueva_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboAreas;
        private Label label7;
        private Label label4;
        private ComboBox comboEspacios;
        private Label label3;
        private Button btnCargarEspacio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem listaDeVerificaciónToolStripMenuItem;
        private ToolStripMenuItem planAnualToolStripMenuItem;
        private ToolStripMenuItem registrarPersonalToolStripMenuItem;
        private DateTimePicker textFecha;
        private Label label8;
        private ComboBox comboBox1;
        private Label label2;
        private Label label5;
        private ToolStripMenuItem crearListaDeVerificaciónToolStripMenuItem;
        private Button button1;
        private Button btnImprimir;
        private ComboBox comboJefeArea;
        private Label label6;
        private Label label9;
        private Label labelAnio;
        private NumericUpDown numericAnio;
        private ComboBox comboPeriodo;
        private TextBox nombreJefe;
        private PictureBox pictureBox1;
        private ToolStripMenuItem registrarDepartamentoToolStripMenuItem;
    }
}