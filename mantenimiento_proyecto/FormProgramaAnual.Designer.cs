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
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.comboPeriodos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelServicio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVerificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericAnio = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboAreas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboAprobo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCargarServicio = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPeriodo.Location = new System.Drawing.Point(455, 106);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(73, 25);
            this.labelPeriodo.TabIndex = 2;
            this.labelPeriodo.Text = "Periodo";
            this.labelPeriodo.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboPeriodos
            // 
            this.comboPeriodos.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboPeriodos.DisplayMember = "enero-junio";
            this.comboPeriodos.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboPeriodos.FormattingEnabled = true;
            this.comboPeriodos.Items.AddRange(new object[] {
            "enero-junio",
            "agosto-diciembre"});
            this.comboPeriodos.Location = new System.Drawing.Point(531, 106);
            this.comboPeriodos.Name = "comboPeriodos";
            this.comboPeriodos.Size = new System.Drawing.Size(177, 30);
            this.comboPeriodos.TabIndex = 3;
            this.comboPeriodos.Text = "enero-junio";
            this.comboPeriodos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(41, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elaborar Programa anual de mantenimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(762, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelServicio.Location = new System.Drawing.Point(716, 394);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(89, 25);
            this.labelServicio.TabIndex = 10;
            this.labelServicio.Text = "Servicios:";
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
            this.registrarPersonalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1017, 31);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click_1);
            // 
            // listaDeVerificaciónToolStripMenuItem
            // 
            this.listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            this.listaDeVerificaciónToolStripMenuItem.Size = new System.Drawing.Size(193, 27);
            this.listaDeVerificaciónToolStripMenuItem.Text = "Crear lista de verificación";
            this.listaDeVerificaciónToolStripMenuItem.Click += new System.EventHandler(this.listaDeVerificaciónToolStripMenuItem_Click);
            // 
            // planAnualToolStripMenuItem
            // 
            this.planAnualToolStripMenuItem.Name = "planAnualToolStripMenuItem";
            this.planAnualToolStripMenuItem.Size = new System.Drawing.Size(178, 27);
            this.planAnualToolStripMenuItem.Text = "Crear Programa Anual";
            this.planAnualToolStripMenuItem.Click += new System.EventHandler(this.planAnualToolStripMenuItem_Click);
            // 
            // registrarPersonalToolStripMenuItem
            // 
            this.registrarPersonalToolStripMenuItem.Name = "registrarPersonalToolStripMenuItem";
            this.registrarPersonalToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.registrarPersonalToolStripMenuItem.Text = "Registrar Personal";
            // 
            // numericAnio
            // 
            this.numericAnio.Location = new System.Drawing.Point(810, 105);
            this.numericAnio.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericAnio.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numericAnio.Name = "numericAnio";
            this.numericAnio.Size = new System.Drawing.Size(120, 25);
            this.numericAnio.TabIndex = 19;
            this.numericAnio.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericAnio.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(683, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 25);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(511, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha de elaboración:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(511, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha de aprobación:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(683, 228);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(258, 25);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // comboAreas
            // 
            this.comboAreas.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboAreas.DisplayMember = "enero-junio";
            this.comboAreas.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboAreas.FormattingEnabled = true;
            this.comboAreas.Items.AddRange(new object[] {
            "enero-junio",
            "agosto-diciembre"});
            this.comboAreas.Location = new System.Drawing.Point(645, 307);
            this.comboAreas.Name = "comboAreas";
            this.comboAreas.Size = new System.Drawing.Size(308, 30);
            this.comboAreas.TabIndex = 37;
            this.comboAreas.Text = "Seleccione en la lista";
            this.comboAreas.SelectedIndexChanged += new System.EventHandler(this.comboAreas_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(531, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Área a tratar:";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboBox2.DisplayMember = "enero-junio";
            this.comboBox2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Daniel Villamar Reyes"});
            this.comboBox2.Location = new System.Drawing.Point(157, 187);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 30);
            this.comboBox2.TabIndex = 39;
            this.comboBox2.Text = "Daniel Villamar Reyes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(83, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Elaboró:";
            // 
            // comboAprobo
            // 
            this.comboAprobo.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboAprobo.DisplayMember = "enero-junio";
            this.comboAprobo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboAprobo.FormattingEnabled = true;
            this.comboAprobo.Items.AddRange(new object[] {
            "Hugo Fernando Hernandez Lopez ",
            "Juan Manuel Treviño Cruz "});
            this.comboAprobo.Location = new System.Drawing.Point(154, 229);
            this.comboAprobo.Name = "comboAprobo";
            this.comboAprobo.Size = new System.Drawing.Size(308, 30);
            this.comboAprobo.TabIndex = 41;
            this.comboAprobo.Text = "Escriba o seleccione en la lista";
            this.comboAprobo.SelectedIndexChanged += new System.EventHandler(this.comboAprobo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(83, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 40;
            this.label10.Text = "Aprobó:";
            // 
            // btnCargarServicio
            // 
            this.btnCargarServicio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCargarServicio.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarServicio.Location = new System.Drawing.Point(825, 388);
            this.btnCargarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarServicio.Name = "btnCargarServicio";
            this.btnCargarServicio.Size = new System.Drawing.Size(128, 39);
            this.btnCargarServicio.TabIndex = 18;
            this.btnCargarServicio.Text = "Cargar servicio";
            this.btnCargarServicio.UseVisualStyleBackColor = false;
            this.btnCargarServicio.Click += new System.EventHandler(this.btnCargarServicio_Click);
            // 
            // FormProgramaAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 566);
            this.Controls.Add(this.comboAprobo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboAreas);
            this.Controls.Add(this.btnCargarServicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericAnio);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPeriodos);
            this.Controls.Add(this.labelPeriodo);
            this.Name = "FormProgramaAnual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa anual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboAreas;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private ComboBox comboAprobo;
        private Label label10;
        private Button btnCargarServicio;
    }
}