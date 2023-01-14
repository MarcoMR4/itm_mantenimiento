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
            this.label1 = new System.Windows.Forms.Label();
            this.comboAreas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboEspacios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarEspacio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVerificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearListaDeVerificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planAnualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardarLista = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(200, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elaborar lista de verificación";
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
            "Personal Registrado 1"});
            this.comboAreas.Location = new System.Drawing.Point(200, 139);
            this.comboAreas.Name = "comboAreas";
            this.comboAreas.Size = new System.Drawing.Size(308, 30);
            this.comboAreas.TabIndex = 19;
            this.comboAreas.SelectedIndexChanged += new System.EventHandler(this.comboAreas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(200, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Área verificada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 21;
            // 
            // comboEspacios
            // 
            this.comboEspacios.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboEspacios.DisplayMember = "enero-junio";
            this.comboEspacios.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboEspacios.FormattingEnabled = true;
            this.comboEspacios.Items.AddRange(new object[] {
            "Edificio AG",
            "Edificio F"});
            this.comboEspacios.Location = new System.Drawing.Point(432, 293);
            this.comboEspacios.Name = "comboEspacios";
            this.comboEspacios.Size = new System.Drawing.Size(353, 30);
            this.comboEspacios.TabIndex = 24;
            this.comboEspacios.Text = "Seleccione un espacio guardado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(273, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Espacio revisado:";
            // 
            // btnCargarEspacio
            // 
            this.btnCargarEspacio.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCargarEspacio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarEspacio.Location = new System.Drawing.Point(631, 215);
            this.btnCargarEspacio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargarEspacio.Name = "btnCargarEspacio";
            this.btnCargarEspacio.Size = new System.Drawing.Size(154, 33);
            this.btnCargarEspacio.TabIndex = 27;
            this.btnCargarEspacio.Text = "Ver Espacios";
            this.btnCargarEspacio.UseVisualStyleBackColor = false;
            this.btnCargarEspacio.Click += new System.EventHandler(this.btnCargarEspacio_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1024, 31);
            this.menuStrip1.TabIndex = 28;
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
            this.listaDeVerificaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearListaDeVerificaciónToolStripMenuItem});
            this.listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            this.listaDeVerificaciónToolStripMenuItem.Size = new System.Drawing.Size(201, 27);
            this.listaDeVerificaciónToolStripMenuItem.Text = "Crear listas de verificación";
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
            this.planAnualToolStripMenuItem.Click += new System.EventHandler(this.planAnualToolStripMenuItem_Click);
            // 
            // registrarPersonalToolStripMenuItem
            // 
            this.registrarPersonalToolStripMenuItem.Name = "registrarPersonalToolStripMenuItem";
            this.registrarPersonalToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.registrarPersonalToolStripMenuItem.Text = "Registrar Personal";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(527, 140);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(258, 25);
            this.textFecha.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(527, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Fecha:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "ene-jun",
            "ago-dic"});
            this.comboBox1.DisplayMember = "enero-junio";
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mantenimiento de equipo"});
            this.comboBox1.Location = new System.Drawing.Point(673, 490);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 30);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Text = "Mantenimiento de equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(467, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Departamento que elabora:";
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
            this.comboBox2.Location = new System.Drawing.Point(673, 526);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 30);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.Text = "Daniel Villamar Reyes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(499, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Jefe del departamento:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(631, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Hallazgos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.Location = new System.Drawing.Point(478, 586);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(154, 33);
            this.btnImprimir.TabIndex = 38;
            this.btnImprimir.Text = "Imprimir ";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnGuardarLista
            // 
            this.btnGuardarLista.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarLista.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarLista.Location = new System.Drawing.Point(273, 586);
            this.btnGuardarLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarLista.Name = "btnGuardarLista";
            this.btnGuardarLista.Size = new System.Drawing.Size(154, 33);
            this.btnGuardarLista.TabIndex = 39;
            this.btnGuardarLista.Text = "Guardar lista ";
            this.btnGuardarLista.UseVisualStyleBackColor = false;
            // 
            // FormListaNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 630);
            this.Controls.Add(this.btnGuardarLista);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCargarEspacio);
            this.Controls.Add(this.comboEspacios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboAreas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FormListaNueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas de verificación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListaNueva_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox comboBox2;
        private Label label5;
        private ToolStripMenuItem crearListaDeVerificaciónToolStripMenuItem;
        private Button button1;
        private Button btnImprimir;
        private Button btnGuardarLista;
    }
}