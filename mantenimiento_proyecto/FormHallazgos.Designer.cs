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
            this.textEspacio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdE = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregarHallazgo = new System.Windows.Forms.Button();
            this.btnModificarHallazgo = new System.Windows.Forms.Button();
            this.btnEliminarHallazgo = new System.Windows.Forms.Button();
            this.textNombreHallazgo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.Label();
            this.gridHallazgos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAtendido = new System.Windows.Forms.ComboBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelAnio = new System.Windows.Forms.Label();
            this.textPeriodo = new System.Windows.Forms.TextBox();
            this.textAnio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridHallazgos)).BeginInit();
            this.SuspendLayout();
            // 
            // textEspacio
            // 
            this.textEspacio.AutoSize = true;
            this.textEspacio.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textEspacio.ForeColor = System.Drawing.Color.Navy;
            this.textEspacio.Location = new System.Drawing.Point(309, 22);
            this.textEspacio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textEspacio.Name = "textEspacio";
            this.textEspacio.Size = new System.Drawing.Size(100, 29);
            this.textEspacio.TabIndex = 8;
            this.textEspacio.Text = "(nombre)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hallazgos del espacio:";
            // 
            // textIdE
            // 
            this.textIdE.Location = new System.Drawing.Point(487, 190);
            this.textIdE.Name = "textIdE";
            this.textIdE.ReadOnly = true;
            this.textIdE.Size = new System.Drawing.Size(100, 23);
            this.textIdE.TabIndex = 73;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(644, 163);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(169, 35);
            this.btnBorrar.TabIndex = 71;
            this.btnBorrar.Text = "Limpiar campos";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarHallazgo
            // 
            this.btnAgregarHallazgo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarHallazgo.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarHallazgo.Location = new System.Drawing.Point(716, 125);
            this.btnAgregarHallazgo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarHallazgo.Name = "btnAgregarHallazgo";
            this.btnAgregarHallazgo.Size = new System.Drawing.Size(97, 35);
            this.btnAgregarHallazgo.TabIndex = 69;
            this.btnAgregarHallazgo.Text = "Agregar ";
            this.btnAgregarHallazgo.UseVisualStyleBackColor = false;
            this.btnAgregarHallazgo.Click += new System.EventHandler(this.btnAgregarHallazgo_Click);
            // 
            // btnModificarHallazgo
            // 
            this.btnModificarHallazgo.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarHallazgo.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarHallazgo.Location = new System.Drawing.Point(615, 227);
            this.btnModificarHallazgo.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarHallazgo.Name = "btnModificarHallazgo";
            this.btnModificarHallazgo.Size = new System.Drawing.Size(97, 35);
            this.btnModificarHallazgo.TabIndex = 72;
            this.btnModificarHallazgo.Text = "Modificar";
            this.btnModificarHallazgo.UseVisualStyleBackColor = false;
            this.btnModificarHallazgo.Click += new System.EventHandler(this.btnModificarHallazgo_Click);
            // 
            // btnEliminarHallazgo
            // 
            this.btnEliminarHallazgo.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarHallazgo.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarHallazgo.Location = new System.Drawing.Point(716, 227);
            this.btnEliminarHallazgo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarHallazgo.Name = "btnEliminarHallazgo";
            this.btnEliminarHallazgo.Size = new System.Drawing.Size(97, 35);
            this.btnEliminarHallazgo.TabIndex = 70;
            this.btnEliminarHallazgo.Text = "Eliminar ";
            this.btnEliminarHallazgo.UseVisualStyleBackColor = false;
            this.btnEliminarHallazgo.Click += new System.EventHandler(this.btnEliminarHallazgo_Click);
            // 
            // textNombreHallazgo
            // 
            this.textNombreHallazgo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombreHallazgo.Location = new System.Drawing.Point(267, 131);
            this.textNombreHallazgo.Name = "textNombreHallazgo";
            this.textNombreHallazgo.Size = new System.Drawing.Size(331, 29);
            this.textNombreHallazgo.TabIndex = 68;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textNombre.ForeColor = System.Drawing.Color.Black;
            this.textNombre.Location = new System.Drawing.Point(28, 130);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(223, 25);
            this.textNombre.TabIndex = 67;
            this.textNombre.Text = "Descripción de hallazgo:";
            // 
            // gridHallazgos
            // 
            this.gridHallazgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHallazgos.Location = new System.Drawing.Point(68, 267);
            this.gridHallazgos.Name = "gridHallazgos";
            this.gridHallazgos.ReadOnly = true;
            this.gridHallazgos.RowHeadersWidth = 51;
            this.gridHallazgos.RowTemplate.Height = 27;
            this.gridHallazgos.Size = new System.Drawing.Size(745, 211);
            this.gridHallazgos.TabIndex = 66;
            this.gridHallazgos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHallazgos_CellClick);
            this.gridHallazgos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHallazgos_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Atendido:";
            // 
            // comboAtendido
            // 
            this.comboAtendido.FormattingEnabled = true;
            this.comboAtendido.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.comboAtendido.Location = new System.Drawing.Point(193, 192);
            this.comboAtendido.Margin = new System.Windows.Forms.Padding(2);
            this.comboAtendido.Name = "comboAtendido";
            this.comboAtendido.Size = new System.Drawing.Size(118, 23);
            this.comboAtendido.TabIndex = 75;
            this.comboAtendido.Text = "No";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelPeriodo.ForeColor = System.Drawing.Color.Black;
            this.labelPeriodo.Location = new System.Drawing.Point(411, 73);
            this.labelPeriodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(74, 23);
            this.labelPeriodo.TabIndex = 76;
            this.labelPeriodo.Text = "Periodo:";
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelAnio.ForeColor = System.Drawing.Color.Black;
            this.labelAnio.Location = new System.Drawing.Point(657, 73);
            this.labelAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(46, 23);
            this.labelAnio.TabIndex = 77;
            this.labelAnio.Text = "Año:";
            this.labelAnio.Click += new System.EventHandler(this.label4_Click);
            // 
            // textPeriodo
            // 
            this.textPeriodo.Enabled = false;
            this.textPeriodo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPeriodo.Location = new System.Drawing.Point(500, 73);
            this.textPeriodo.Name = "textPeriodo";
            this.textPeriodo.Size = new System.Drawing.Size(152, 29);
            this.textPeriodo.TabIndex = 78;
            // 
            // textAnio
            // 
            this.textAnio.Enabled = false;
            this.textAnio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAnio.Location = new System.Drawing.Point(708, 73);
            this.textAnio.Name = "textAnio";
            this.textAnio.Size = new System.Drawing.Size(129, 29);
            this.textAnio.TabIndex = 79;
            // 
            // FormHallazgos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 517);
            this.Controls.Add(this.textAnio);
            this.Controls.Add(this.textPeriodo);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.labelPeriodo);
            this.Controls.Add(this.comboAtendido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIdE);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregarHallazgo);
            this.Controls.Add(this.btnModificarHallazgo);
            this.Controls.Add(this.btnEliminarHallazgo);
            this.Controls.Add(this.textNombreHallazgo);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.gridHallazgos);
            this.Controls.Add(this.textEspacio);
            this.Controls.Add(this.label1);
            this.Name = "FormHallazgos";
            this.Text = "FormHallazgos";
            this.Load += new System.EventHandler(this.FormHallazgos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHallazgos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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