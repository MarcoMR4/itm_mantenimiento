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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicios));
            textServicio = new Label();
            label1 = new Label();
            textDescripcion = new TextBox();
            textNombre = new Label();
            btnAgregarServicio = new Button();
            btnModificarServicio = new Button();
            btnEliminarServicio = new Button();
            gridServicios = new DataGridView();
            labelAnio = new Label();
            labelPeriodo = new Label();
            textAnio = new TextBox();
            textPeriodo = new TextBox();
            comboTipo = new ComboBox();
            label6 = new Label();
            mesesLista = new CheckedListBox();
            textId = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridServicios).BeginInit();
            SuspendLayout();
            // 
            // textServicio
            // 
            textServicio.AutoSize = true;
            textServicio.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textServicio.ForeColor = Color.Navy;
            textServicio.Location = new Point(441, 8);
            textServicio.Margin = new Padding(2, 0, 2, 0);
            textServicio.Name = "textServicio";
            textServicio.Size = new Size(100, 29);
            textServicio.TabIndex = 10;
            textServicio.Text = "(nombre)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(195, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 29);
            label1.TabIndex = 9;
            label1.Text = "Servicios para el área:";
            // 
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textDescripcion.Location = new Point(225, 133);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(747, 29);
            textDescripcion.TabIndex = 70;
            // 
            // textNombre
            // 
            textNombre.AutoSize = true;
            textNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textNombre.ForeColor = Color.Black;
            textNombre.Location = new Point(225, 109);
            textNombre.Margin = new Padding(2, 0, 2, 0);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(224, 25);
            textNombre.TabIndex = 69;
            textNombre.Text = "Descripción del servicio:";
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.BackColor = Color.MediumAquamarine;
            btnAgregarServicio.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarServicio.Location = new Point(778, 184);
            btnAgregarServicio.Margin = new Padding(2);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(97, 35);
            btnAgregarServicio.TabIndex = 73;
            btnAgregarServicio.Text = "Agregar ";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            btnAgregarServicio.Click += btnAgregarServicio_Click_1;
            // 
            // btnModificarServicio
            // 
            btnModificarServicio.BackColor = Color.Khaki;
            btnModificarServicio.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarServicio.Location = new Point(560, 253);
            btnModificarServicio.Margin = new Padding(2);
            btnModificarServicio.Name = "btnModificarServicio";
            btnModificarServicio.Size = new Size(109, 35);
            btnModificarServicio.TabIndex = 75;
            btnModificarServicio.Text = "Modificar";
            btnModificarServicio.UseVisualStyleBackColor = false;
            btnModificarServicio.Click += btnModificarServicio_Click_1;
            // 
            // btnEliminarServicio
            // 
            btnEliminarServicio.BackColor = Color.LightCoral;
            btnEliminarServicio.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarServicio.Location = new Point(695, 253);
            btnEliminarServicio.Margin = new Padding(2);
            btnEliminarServicio.Name = "btnEliminarServicio";
            btnEliminarServicio.Size = new Size(97, 35);
            btnEliminarServicio.TabIndex = 74;
            btnEliminarServicio.Text = "Eliminar ";
            btnEliminarServicio.UseVisualStyleBackColor = false;
            btnEliminarServicio.Click += btnEliminarServicio_Click_1;
            // 
            // gridServicios
            // 
            gridServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServicios.Location = new Point(22, 295);
            gridServicios.Name = "gridServicios";
            gridServicios.ReadOnly = true;
            gridServicios.RowHeadersWidth = 51;
            gridServicios.RowTemplate.Height = 27;
            gridServicios.Size = new Size(950, 211);
            gridServicios.TabIndex = 76;
            gridServicios.CellClick += gridServicios_CellClick;
            gridServicios.Click += gridServicios_Click;
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelAnio.ForeColor = Color.Black;
            labelAnio.Location = new Point(732, 34);
            labelAnio.Margin = new Padding(2, 0, 2, 0);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(52, 25);
            labelAnio.TabIndex = 77;
            labelAnio.Text = "Año:";
            // 
            // labelPeriodo
            // 
            labelPeriodo.AutoSize = true;
            labelPeriodo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelPeriodo.ForeColor = Color.Black;
            labelPeriodo.Location = new Point(700, 73);
            labelPeriodo.Margin = new Padding(2, 0, 2, 0);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(84, 25);
            labelPeriodo.TabIndex = 78;
            labelPeriodo.Text = "Periodo:";
            // 
            // textAnio
            // 
            textAnio.Location = new Point(789, 34);
            textAnio.Name = "textAnio";
            textAnio.ReadOnly = true;
            textAnio.Size = new Size(183, 23);
            textAnio.TabIndex = 79;
            // 
            // textPeriodo
            // 
            textPeriodo.Location = new Point(789, 73);
            textPeriodo.Name = "textPeriodo";
            textPeriodo.ReadOnly = true;
            textPeriodo.Size = new Size(183, 23);
            textPeriodo.TabIndex = 80;
            // 
            // comboTipo
            // 
            comboTipo.AutoCompleteCustomSource.AddRange(new string[] { "I", "E" });
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboTipo.FormattingEnabled = true;
            comboTipo.Items.AddRange(new object[] { "Interno", "Externo" });
            comboTipo.Location = new Point(394, 184);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(177, 30);
            comboTipo.TabIndex = 82;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(225, 184);
            label6.Name = "label6";
            label6.Size = new Size(163, 23);
            label6.TabIndex = 81;
            label6.Text = "Tipo de Servicio";
            // 
            // mesesLista
            // 
            mesesLista.CheckOnClick = true;
            mesesLista.FormattingEnabled = true;
            mesesLista.Location = new Point(22, 69);
            mesesLista.Name = "mesesLista";
            mesesLista.Size = new Size(120, 202);
            mesesLista.TabIndex = 83;
            // 
            // textId
            // 
            textId.Location = new Point(433, 253);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(93, 23);
            textId.TabIndex = 84;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(591, 184);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(167, 35);
            btnLimpiar.TabIndex = 85;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FormServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1016, 516);
            Controls.Add(btnLimpiar);
            Controls.Add(textId);
            Controls.Add(mesesLista);
            Controls.Add(comboTipo);
            Controls.Add(label6);
            Controls.Add(textPeriodo);
            Controls.Add(textAnio);
            Controls.Add(labelPeriodo);
            Controls.Add(labelAnio);
            Controls.Add(gridServicios);
            Controls.Add(btnAgregarServicio);
            Controls.Add(btnModificarServicio);
            Controls.Add(btnEliminarServicio);
            Controls.Add(textDescripcion);
            Controls.Add(textNombre);
            Controls.Add(textServicio);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormServicios";
            Text = "Agregar Servicios ";
            Load += FormServicios_Load;
            ((System.ComponentModel.ISupportInitialize)gridServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnLimpiar;
    }
}