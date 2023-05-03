namespace mantenimiento_proyecto
{
    partial class FormPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            listaDeVerificaciónToolStripMenuItem = new ToolStripMenuItem();
            crearListaDeVerificaciónToolStripMenuItem = new ToolStripMenuItem();
            planAnualToolStripMenuItem = new ToolStripMenuItem();
            registrarPersonalToolStripMenuItem = new ToolStripMenuItem();
            registrarDepartamentoToolStripMenuItem = new ToolStripMenuItem();
            gridPersonal = new DataGridView();
            groupBox1 = new GroupBox();
            btnBorrar = new Button();
            comboArea = new ComboBox();
            labelArea = new Label();
            textNombre = new TextBox();
            labelNombre = new Label();
            btnAgregarPersonal = new Button();
            label2 = new Label();
            btnModificarPersonal = new Button();
            btnEliminarPersonal = new Button();
            textID = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPersonal).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            menuStrip1.Size = new Size(982, 31);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Image = (Image)resources.GetObject("inicioToolStripMenuItem.Image");
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(77, 27);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // listaDeVerificaciónToolStripMenuItem
            // 
            listaDeVerificaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearListaDeVerificaciónToolStripMenuItem });
            listaDeVerificaciónToolStripMenuItem.Image = (Image)resources.GetObject("listaDeVerificaciónToolStripMenuItem.Image");
            listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            listaDeVerificaciónToolStripMenuItem.Size = new Size(213, 27);
            listaDeVerificaciónToolStripMenuItem.Text = "Crear lista de verificación";
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
            // registrarPersonalToolStripMenuItem
            // 
            registrarPersonalToolStripMenuItem.Image = (Image)resources.GetObject("registrarPersonalToolStripMenuItem.Image");
            registrarPersonalToolStripMenuItem.Name = "registrarPersonalToolStripMenuItem";
            registrarPersonalToolStripMenuItem.Size = new Size(170, 27);
            registrarPersonalToolStripMenuItem.Text = "Registrar Personal";
            registrarPersonalToolStripMenuItem.Click += registrarPersonalToolStripMenuItem_Click;
            // 
            // registrarDepartamentoToolStripMenuItem
            // 
            registrarDepartamentoToolStripMenuItem.BackColor = Color.PowderBlue;
            registrarDepartamentoToolStripMenuItem.Image = (Image)resources.GetObject("registrarDepartamentoToolStripMenuItem.Image");
            registrarDepartamentoToolStripMenuItem.Name = "registrarDepartamentoToolStripMenuItem";
            registrarDepartamentoToolStripMenuItem.Size = new Size(83, 27);
            registrarDepartamentoToolStripMenuItem.Text = "Áreas";
            registrarDepartamentoToolStripMenuItem.Click += registrarDepartamentoToolStripMenuItem_Click;
            // 
            // gridPersonal
            // 
            gridPersonal.AllowUserToDeleteRows = false;
            gridPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridPersonal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridPersonal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPersonal.Location = new Point(82, 350);
            gridPersonal.Margin = new Padding(2);
            gridPersonal.Name = "gridPersonal";
            gridPersonal.RowHeadersWidth = 51;
            gridPersonal.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridPersonal.RowTemplate.Height = 31;
            gridPersonal.Size = new Size(876, 183);
            gridPersonal.TabIndex = 30;
            gridPersonal.CellClick += gridPersonal_CellClick;
            gridPersonal.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(comboArea);
            groupBox1.Controls.Add(labelArea);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(labelNombre);
            groupBox1.Controls.Add(btnAgregarPersonal);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(82, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 206);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.LightSteelBlue;
            btnBorrar.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(461, 152);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(151, 35);
            btnBorrar.TabIndex = 60;
            btnBorrar.Text = "Limpiar campos";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // comboArea
            // 
            comboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            comboArea.FormattingEnabled = true;
            comboArea.Location = new Point(480, 80);
            comboArea.Name = "comboArea";
            comboArea.Size = new Size(252, 23);
            comboArea.TabIndex = 55;
            comboArea.SelectedIndexChanged += comboArea_SelectedIndexChanged;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelArea.Location = new Point(420, 80);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(54, 25);
            labelArea.TabIndex = 54;
            labelArea.Text = "Área:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(167, 80);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(218, 23);
            textNombre.TabIndex = 49;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.Location = new Point(62, 80);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(79, 25);
            labelNombre.TabIndex = 48;
            labelNombre.Text = "Nombre:";
            // 
            // btnAgregarPersonal
            // 
            btnAgregarPersonal.BackColor = Color.MediumAquamarine;
            btnAgregarPersonal.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarPersonal.Location = new Point(661, 152);
            btnAgregarPersonal.Margin = new Padding(2);
            btnAgregarPersonal.Name = "btnAgregarPersonal";
            btnAgregarPersonal.Size = new Size(97, 35);
            btnAgregarPersonal.TabIndex = 46;
            btnAgregarPersonal.Text = "Agregar ";
            btnAgregarPersonal.UseVisualStyleBackColor = false;
            btnAgregarPersonal.Click += btnAgregarPersonal_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(534, 15);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 29);
            label2.TabIndex = 45;
            label2.Text = "Personal registrado";
            // 
            // btnModificarPersonal
            // 
            btnModificarPersonal.BackColor = Color.Khaki;
            btnModificarPersonal.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarPersonal.Location = new Point(693, 303);
            btnModificarPersonal.Margin = new Padding(2);
            btnModificarPersonal.Name = "btnModificarPersonal";
            btnModificarPersonal.Size = new Size(97, 35);
            btnModificarPersonal.TabIndex = 60;
            btnModificarPersonal.Text = "Modificar";
            btnModificarPersonal.UseVisualStyleBackColor = false;
            btnModificarPersonal.Click += btnModificarPersonal_Click;
            // 
            // btnEliminarPersonal
            // 
            btnEliminarPersonal.BackColor = Color.LightCoral;
            btnEliminarPersonal.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarPersonal.Location = new Point(806, 303);
            btnEliminarPersonal.Margin = new Padding(2);
            btnEliminarPersonal.Name = "btnEliminarPersonal";
            btnEliminarPersonal.Size = new Size(97, 35);
            btnEliminarPersonal.TabIndex = 59;
            btnEliminarPersonal.Text = "Eliminar ";
            btnEliminarPersonal.UseVisualStyleBackColor = false;
            btnEliminarPersonal.Click += btnEliminarPersonal_Click;
            // 
            // textID
            // 
            textID.Location = new Point(441, 303);
            textID.Name = "textID";
            textID.ReadOnly = true;
            textID.Size = new Size(214, 23);
            textID.TabIndex = 61;
            // 
            // FormPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 543);
            Controls.Add(textID);
            Controls.Add(btnModificarPersonal);
            Controls.Add(btnEliminarPersonal);
            Controls.Add(groupBox1);
            Controls.Add(gridPersonal);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
            Name = "FormPersonal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar personal ";
            WindowState = FormWindowState.Maximized;
            Load += FormPersonal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPersonal).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox groupBox1;
        private ComboBox comboArea;
        private Label labelArea;
        private TextBox textNombre;
        private Label labelNombre;
        private Button btnAgregarPersonal;
        private Label label2;
        private Button btnModificarPersonal;
        private Button btnEliminarPersonal;
        private TextBox textID;
        private Button btnBorrar;
    }
}