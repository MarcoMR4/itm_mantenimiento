namespace mantenimiento_proyecto.Logica
{
    partial class FormHallazgos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHallazgos));
            textEspacio = new Label();
            label1 = new Label();
            textIdE = new TextBox();
            btnBorrar = new Button();
            btnAgregarHallazgo = new Button();
            btnModificarHallazgo = new Button();
            btnEliminarHallazgo = new Button();
            textNombreHallazgo = new TextBox();
            textNombre = new Label();
            gridHallazgos = new DataGridView();
            label2 = new Label();
            comboAtendido = new ComboBox();
            labelPeriodo = new Label();
            labelAnio = new Label();
            textPeriodo = new TextBox();
            textAnio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridHallazgos).BeginInit();
            SuspendLayout();
            // 
            // textEspacio
            // 
            textEspacio.AutoSize = true;
            textEspacio.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textEspacio.ForeColor = Color.Navy;
            textEspacio.Location = new Point(309, 22);
            textEspacio.Margin = new Padding(2, 0, 2, 0);
            textEspacio.Name = "textEspacio";
            textEspacio.Size = new Size(100, 29);
            textEspacio.TabIndex = 8;
            textEspacio.Text = "(nombre)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(29, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 7;
            label1.Text = "Hallazgos del espacio:";
            // 
            // textIdE
            // 
            textIdE.Location = new Point(487, 190);
            textIdE.Name = "textIdE";
            textIdE.ReadOnly = true;
            textIdE.Size = new Size(100, 23);
            textIdE.TabIndex = 73;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.LightSteelBlue;
            btnBorrar.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(644, 163);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(169, 35);
            btnBorrar.TabIndex = 71;
            btnBorrar.Text = "Limpiar campos";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregarHallazgo
            // 
            btnAgregarHallazgo.BackColor = Color.MediumAquamarine;
            btnAgregarHallazgo.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarHallazgo.Location = new Point(716, 125);
            btnAgregarHallazgo.Margin = new Padding(2);
            btnAgregarHallazgo.Name = "btnAgregarHallazgo";
            btnAgregarHallazgo.Size = new Size(97, 35);
            btnAgregarHallazgo.TabIndex = 69;
            btnAgregarHallazgo.Text = "Agregar ";
            btnAgregarHallazgo.UseVisualStyleBackColor = false;
            btnAgregarHallazgo.Click += btnAgregarHallazgo_Click;
            // 
            // btnModificarHallazgo
            // 
            btnModificarHallazgo.BackColor = Color.Khaki;
            btnModificarHallazgo.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarHallazgo.Location = new Point(615, 227);
            btnModificarHallazgo.Margin = new Padding(2);
            btnModificarHallazgo.Name = "btnModificarHallazgo";
            btnModificarHallazgo.Size = new Size(97, 35);
            btnModificarHallazgo.TabIndex = 72;
            btnModificarHallazgo.Text = "Modificar";
            btnModificarHallazgo.UseVisualStyleBackColor = false;
            btnModificarHallazgo.Click += btnModificarHallazgo_Click;
            // 
            // btnEliminarHallazgo
            // 
            btnEliminarHallazgo.BackColor = Color.LightCoral;
            btnEliminarHallazgo.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarHallazgo.Location = new Point(716, 227);
            btnEliminarHallazgo.Margin = new Padding(2);
            btnEliminarHallazgo.Name = "btnEliminarHallazgo";
            btnEliminarHallazgo.Size = new Size(97, 35);
            btnEliminarHallazgo.TabIndex = 70;
            btnEliminarHallazgo.Text = "Eliminar ";
            btnEliminarHallazgo.UseVisualStyleBackColor = false;
            btnEliminarHallazgo.Click += btnEliminarHallazgo_Click;
            // 
            // textNombreHallazgo
            // 
            textNombreHallazgo.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textNombreHallazgo.Location = new Point(267, 131);
            textNombreHallazgo.Name = "textNombreHallazgo";
            textNombreHallazgo.Size = new Size(331, 29);
            textNombreHallazgo.TabIndex = 68;
            // 
            // textNombre
            // 
            textNombre.AutoSize = true;
            textNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textNombre.ForeColor = Color.Black;
            textNombre.Location = new Point(28, 130);
            textNombre.Margin = new Padding(2, 0, 2, 0);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(223, 25);
            textNombre.TabIndex = 67;
            textNombre.Text = "Descripción de hallazgo:";
            // 
            // gridHallazgos
            // 
            gridHallazgos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHallazgos.Location = new Point(68, 267);
            gridHallazgos.Name = "gridHallazgos";
            gridHallazgos.ReadOnly = true;
            gridHallazgos.RowHeadersWidth = 51;
            gridHallazgos.RowTemplate.Height = 27;
            gridHallazgos.Size = new Size(745, 211);
            gridHallazgos.TabIndex = 66;
            gridHallazgos.CellClick += gridHallazgos_CellClick;
            gridHallazgos.CellContentDoubleClick += gridHallazgos_CellContentDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(68, 190);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 74;
            label2.Text = "Atendido:";
            // 
            // comboAtendido
            // 
            comboAtendido.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAtendido.FormattingEnabled = true;
            comboAtendido.Items.AddRange(new object[] { "No", "Si" });
            comboAtendido.Location = new Point(193, 192);
            comboAtendido.Margin = new Padding(2);
            comboAtendido.Name = "comboAtendido";
            comboAtendido.Size = new Size(118, 23);
            comboAtendido.TabIndex = 75;
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPeriodo.ForeColor = Color.Black;
            labelPeriodo.Location = new Point(411, 73);
            labelPeriodo.Margin = new Padding(2, 0, 2, 0);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(74, 23);
            labelPeriodo.TabIndex = 76;
            labelPeriodo.Text = "Periodo:";
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelAnio.ForeColor = Color.Black;
            labelAnio.Location = new Point(657, 73);
            labelAnio.Margin = new Padding(2, 0, 2, 0);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(46, 23);
            labelAnio.TabIndex = 77;
            labelAnio.Text = "Año:";
            labelAnio.Click += label4_Click;
            // 
            // textPeriodo
            // 
            textPeriodo.Enabled = false;
            textPeriodo.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textPeriodo.Location = new Point(500, 73);
            textPeriodo.Name = "textPeriodo";
            textPeriodo.Size = new Size(152, 29);
            textPeriodo.TabIndex = 78;
            // 
            // textAnio
            // 
            textAnio.Enabled = false;
            textAnio.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textAnio.Location = new Point(708, 73);
            textAnio.Name = "textAnio";
            textAnio.Size = new Size(129, 29);
            textAnio.TabIndex = 79;
            // 
            // FormHallazgos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(872, 517);
            Controls.Add(textAnio);
            Controls.Add(textPeriodo);
            Controls.Add(labelAnio);
            Controls.Add(labelPeriodo);
            Controls.Add(comboAtendido);
            Controls.Add(label2);
            Controls.Add(textIdE);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregarHallazgo);
            Controls.Add(btnModificarHallazgo);
            Controls.Add(btnEliminarHallazgo);
            Controls.Add(textNombreHallazgo);
            Controls.Add(textNombre);
            Controls.Add(gridHallazgos);
            Controls.Add(textEspacio);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHallazgos";
            Text = "FormHallazgos";
            FormClosed += FormHallazgos_FormClosed;
            Load += FormHallazgos_Load;
            ((System.ComponentModel.ISupportInitialize)gridHallazgos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textEspacio;
        private Label label1;
        private TextBox textIdE;
        private Button btnBorrar;
        private Button btnAgregarHallazgo;
        private Button btnModificarHallazgo;
        private Button btnEliminarHallazgo;
        private TextBox textNombreHallazgo;
        private Label textNombre;
        private DataGridView gridHallazgos;
        private Label label2;
        private ComboBox comboAtendido;
        private Label labelPeriodo;
        private Label labelAnio;
        private TextBox textPeriodo;
        private TextBox textAnio;
    }
}