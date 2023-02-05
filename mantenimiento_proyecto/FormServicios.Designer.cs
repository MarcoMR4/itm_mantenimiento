namespace mantenimiento_proyecto.Logica
{
    partial class FormServicios
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
            this.textServicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.Label();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnModificarServicio = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.gridServicios = new System.Windows.Forms.DataGridView();
            this.labelAnio = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.textAnio = new System.Windows.Forms.TextBox();
            this.textPeriodo = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mesesLista = new System.Windows.Forms.CheckedListBox();
            this.textId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // textServicio
            // 
            this.textServicio.AutoSize = true;
            this.textServicio.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textServicio.ForeColor = System.Drawing.Color.Navy;
            this.textServicio.Location = new System.Drawing.Point(441, 8);
            this.textServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textServicio.Name = "textServicio";
            this.textServicio.Size = new System.Drawing.Size(100, 29);
            this.textServicio.TabIndex = 10;
            this.textServicio.Text = "(nombre)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(195, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Servicios para el área:";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDescripcion.Location = new System.Drawing.Point(225, 133);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(747, 29);
            this.textDescripcion.TabIndex = 70;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textNombre.ForeColor = System.Drawing.Color.Black;
            this.textNombre.Location = new System.Drawing.Point(225, 109);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(224, 25);
            this.textNombre.TabIndex = 69;
            this.textNombre.Text = "Descripción del servicio:";
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarServicio.Location = new System.Drawing.Point(658, 198);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(97, 35);
            this.btnAgregarServicio.TabIndex = 73;
            this.btnAgregarServicio.Text = "Agregar ";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click_1);
            // 
            // btnModificarServicio
            // 
            this.btnModificarServicio.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarServicio.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarServicio.Location = new System.Drawing.Point(560, 253);
            this.btnModificarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarServicio.Name = "btnModificarServicio";
            this.btnModificarServicio.Size = new System.Drawing.Size(97, 35);
            this.btnModificarServicio.TabIndex = 75;
            this.btnModificarServicio.Text = "Modificar";
            this.btnModificarServicio.UseVisualStyleBackColor = false;
            this.btnModificarServicio.Click += new System.EventHandler(this.btnModificarServicio_Click_1);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarServicio.Location = new System.Drawing.Point(661, 253);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(97, 35);
            this.btnEliminarServicio.TabIndex = 74;
            this.btnEliminarServicio.Text = "Eliminar ";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click_1);
            // 
            // gridServicios
            // 
            this.gridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServicios.Location = new System.Drawing.Point(22, 295);
            this.gridServicios.Name = "gridServicios";
            this.gridServicios.ReadOnly = true;
            this.gridServicios.RowHeadersWidth = 51;
            this.gridServicios.RowTemplate.Height = 27;
            this.gridServicios.Size = new System.Drawing.Size(950, 211);
            this.gridServicios.TabIndex = 76;
            this.gridServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServicios_CellClick);
            this.gridServicios.Click += new System.EventHandler(this.gridServicios_Click);
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelAnio.ForeColor = System.Drawing.Color.Black;
            this.labelAnio.Location = new System.Drawing.Point(732, 34);
            this.labelAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(52, 25);
            this.labelAnio.TabIndex = 77;
            this.labelAnio.Text = "Año:";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelPeriodo.ForeColor = System.Drawing.Color.Black;
            this.labelPeriodo.Location = new System.Drawing.Point(700, 73);
            this.labelPeriodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(84, 25);
            this.labelPeriodo.TabIndex = 78;
            this.labelPeriodo.Text = "Periodo:";
            // 
            // textAnio
            // 
            this.textAnio.Location = new System.Drawing.Point(789, 34);
            this.textAnio.Name = "textAnio";
            this.textAnio.ReadOnly = true;
            this.textAnio.Size = new System.Drawing.Size(183, 23);
            this.textAnio.TabIndex = 79;
            // 
            // textPeriodo
            // 
            this.textPeriodo.Location = new System.Drawing.Point(789, 73);
            this.textPeriodo.Name = "textPeriodo";
            this.textPeriodo.ReadOnly = true;
            this.textPeriodo.Size = new System.Drawing.Size(183, 23);
            this.textPeriodo.TabIndex = 80;
            // 
            // comboTipo
            // 
            this.comboTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "I",
            "E"});
            this.comboTipo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Interno",
            "Externo"});
            this.comboTipo.Location = new System.Drawing.Point(394, 184);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(177, 30);
            this.comboTipo.TabIndex = 82;
            this.comboTipo.Text = "Interno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(225, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 23);
            this.label6.TabIndex = 81;
            this.label6.Text = "Tipo de Servicio";
            // 
            // mesesLista
            // 
            this.mesesLista.CheckOnClick = true;
            this.mesesLista.FormattingEnabled = true;
            this.mesesLista.Location = new System.Drawing.Point(22, 69);
            this.mesesLista.Name = "mesesLista";
            this.mesesLista.Size = new System.Drawing.Size(120, 202);
            this.mesesLista.TabIndex = 83;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(433, 253);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(93, 23);
            this.textId.TabIndex = 84;
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 516);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.mesesLista);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPeriodo);
            this.Controls.Add(this.textAnio);
            this.Controls.Add(this.labelPeriodo);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.gridServicios);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.btnModificarServicio);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textServicio);
            this.Controls.Add(this.label1);
            this.Name = "FormServicios";
            this.Text = "Agregar Servicios ";
            this.Load += new System.EventHandler(this.FormServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textServicio;
        private Label label1;
        private TextBox textDescripcion;
        private Label textNombre;
        private Button btnAgregarServicio;
        private Button btnModificarServicio;
        private Button btnEliminarServicio;
        private DataGridView gridServicios;
        private Label labelAnio;
        private Label labelPeriodo;
        private TextBox textAnio;
        private TextBox textPeriodo;
        private ComboBox comboTipo;
        private Label label6;
        private CheckedListBox mesesLista;
        private TextBox textId;
    }
}