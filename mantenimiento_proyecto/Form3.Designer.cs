namespace mantenimiento_proyecto
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVerificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPeriodos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAnios = new System.Windows.Forms.ComboBox();
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.textServicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargarServicio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.planAnualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(67, 31);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // listaDeVerificaciónToolStripMenuItem
            // 
            this.listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            this.listaDeVerificaciónToolStripMenuItem.Size = new System.Drawing.Size(193, 31);
            this.listaDeVerificaciónToolStripMenuItem.Text = "Listas de verificación";
            // 
            // planAnualToolStripMenuItem
            // 
            this.planAnualToolStripMenuItem.Name = "planAnualToolStripMenuItem";
            this.planAnualToolStripMenuItem.Size = new System.Drawing.Size(233, 31);
            this.planAnualToolStripMenuItem.Text = "Elaborar Programa Anual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Periodo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.comboPeriodos.Location = new System.Drawing.Point(150, 170);
            this.comboPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.comboPeriodos.Name = "comboPeriodos";
            this.comboPeriodos.Size = new System.Drawing.Size(226, 35);
            this.comboPeriodos.TabIndex = 3;
            this.comboPeriodos.Text = "Seleccione el periodo";
            this.comboPeriodos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(180, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elaborar Programa anual de mantenimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(448, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboAnios
            // 
            this.comboAnios.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboAnios.FormattingEnabled = true;
            this.comboAnios.Location = new System.Drawing.Point(510, 170);
            this.comboAnios.Name = "comboAnios";
            this.comboAnios.Size = new System.Drawing.Size(151, 35);
            this.comboAnios.TabIndex = 7;
            this.comboAnios.Tag = "";
            this.comboAnios.Text = "2022";
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCargarLista.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarLista.Location = new System.Drawing.Point(845, 511);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(166, 62);
            this.btnCargarLista.TabIndex = 8;
            this.btnCargarLista.Text = "Cargar lista de verificación";
            this.btnCargarLista.UseVisualStyleBackColor = false;
            // 
            // textServicio
            // 
            this.textServicio.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textServicio.Location = new System.Drawing.Point(152, 307);
            this.textServicio.Name = "textServicio";
            this.textServicio.Size = new System.Drawing.Size(792, 34);
            this.textServicio.TabIndex = 9;
            this.textServicio.Text = "Descripción del servicio";
            this.textServicio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Servicio";
            // 
            // btnCargarServicio
            // 
            this.btnCargarServicio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCargarServicio.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarServicio.Location = new System.Drawing.Point(53, 511);
            this.btnCargarServicio.Name = "btnCargarServicio";
            this.btnCargarServicio.Size = new System.Drawing.Size(165, 48);
            this.btnCargarServicio.TabIndex = 11;
            this.btnCargarServicio.Text = "Cargar servicio";
            this.btnCargarServicio.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Meses del Servicio";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboBox3.DisplayMember = "enero-junio";
            this.comboBox3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "enero-junio",
            "agosto-diciembre"});
            this.comboBox3.Location = new System.Drawing.Point(267, 383);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(226, 35);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Text = "Seleccione los meses ";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboTipo
            // 
            this.comboTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboTipo.DisplayMember = "enero-junio";
            this.comboTipo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Interno\t(I)",
            "Externo\t(E)"});
            this.comboTipo.Location = new System.Drawing.Point(718, 383);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(226, 35);
            this.comboTipo.TabIndex = 15;
            this.comboTipo.Text = "Interno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(539, 383);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de Servicio";
            // 
            // comboBox5
            // 
            this.comboBox5.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboBox5.DisplayMember = "enero-junio";
            this.comboBox5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "enero-junio",
            "agosto-diciembre"});
            this.comboBox5.Location = new System.Drawing.Point(156, 453);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(306, 35);
            this.comboBox5.TabIndex = 17;
            this.comboBox5.Text = "Seleccione la persona que elabora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(53, 457);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Elaboró:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 596);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCargarServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textServicio);
            this.Controls.Add(this.btnCargarLista);
            this.Controls.Add(this.comboAnios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPeriodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Plan Anual ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem listaDeVerificaciónToolStripMenuItem;
        private ToolStripMenuItem planAnualToolStripMenuItem;
        private Label label1;
        private ComboBox comboPeriodos;
        private Label label2;
        private Label label3;
        private ComboBox comboAnios;
        private Button btnCargarLista;
        private TextBox textServicio;
        private Label label4;
        private Button btnCargarServicio;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox comboTipo;
        private Label label6;
        private ComboBox comboBox5;
        private Label label7;
    }
}