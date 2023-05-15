namespace mantenimiento_proyecto
{
    partial class FormEspacios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEspacios));
            label1 = new Label();
            area = new Label();
            gridEspacios = new DataGridView();
            textNombre = new Label();
            textNombreE = new TextBox();
            btnBorrar = new Button();
            btnAgregarEspacio = new Button();
            btnModificarEspacio = new Button();
            btnEliminarEspacio = new Button();
            textIdE = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridEspacios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(76, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 5;
            label1.Text = "Espacios del área:";
            // 
            // area
            // 
            area.AutoSize = true;
            area.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            area.ForeColor = Color.Navy;
            area.Location = new Point(265, 20);
            area.Margin = new Padding(2, 0, 2, 0);
            area.Name = "area";
            area.Size = new Size(100, 29);
            area.TabIndex = 6;
            area.Text = "(nombre)";
            // 
            // gridEspacios
            // 
            gridEspacios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridEspacios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridEspacios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEspacios.Location = new Point(43, 223);
            gridEspacios.Name = "gridEspacios";
            gridEspacios.ReadOnly = true;
            gridEspacios.RightToLeft = RightToLeft.No;
            gridEspacios.RowHeadersWidth = 70;
            gridEspacios.RowTemplate.Height = 27;
            gridEspacios.Size = new Size(544, 215);
            gridEspacios.TabIndex = 7;
            gridEspacios.CellClick += gridEspacios_CellClick;
            gridEspacios.CellContentClick += gridEspacios_CellContentClick;
            // 
            // textNombre
            // 
            textNombre.AutoSize = true;
            textNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textNombre.ForeColor = Color.Black;
            textNombre.Location = new Point(76, 76);
            textNombre.Margin = new Padding(2, 0, 2, 0);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(261, 25);
            textNombre.TabIndex = 12;
            textNombre.Text = "Nombre de espacio revisado:";
            // 
            // textNombreE
            // 
            textNombreE.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textNombreE.Location = new Point(342, 76);
            textNombreE.Name = "textNombreE";
            textNombreE.Size = new Size(331, 29);
            textNombreE.TabIndex = 13;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.LightSteelBlue;
            btnBorrar.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(691, 108);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(97, 35);
            btnBorrar.TabIndex = 63;
            btnBorrar.Text = "Limpiar campos";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregarEspacio
            // 
            btnAgregarEspacio.BackColor = Color.MediumAquamarine;
            btnAgregarEspacio.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarEspacio.Location = new Point(691, 69);
            btnAgregarEspacio.Margin = new Padding(2);
            btnAgregarEspacio.Name = "btnAgregarEspacio";
            btnAgregarEspacio.Size = new Size(97, 35);
            btnAgregarEspacio.TabIndex = 61;
            btnAgregarEspacio.Text = "Agregar ";
            btnAgregarEspacio.UseVisualStyleBackColor = false;
            btnAgregarEspacio.Click += btnAgregarEspacio_Click;
            // 
            // btnModificarEspacio
            // 
            btnModificarEspacio.BackColor = Color.Khaki;
            btnModificarEspacio.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarEspacio.Location = new Point(590, 171);
            btnModificarEspacio.Margin = new Padding(2);
            btnModificarEspacio.Name = "btnModificarEspacio";
            btnModificarEspacio.Size = new Size(97, 35);
            btnModificarEspacio.TabIndex = 64;
            btnModificarEspacio.Text = "Modificar";
            btnModificarEspacio.UseVisualStyleBackColor = false;
            btnModificarEspacio.Click += btnModificarEspacio_Click_1;
            // 
            // btnEliminarEspacio
            // 
            btnEliminarEspacio.BackColor = Color.LightCoral;
            btnEliminarEspacio.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarEspacio.Location = new Point(691, 171);
            btnEliminarEspacio.Margin = new Padding(2);
            btnEliminarEspacio.Name = "btnEliminarEspacio";
            btnEliminarEspacio.Size = new Size(97, 35);
            btnEliminarEspacio.TabIndex = 62;
            btnEliminarEspacio.Text = "Eliminar ";
            btnEliminarEspacio.UseVisualStyleBackColor = false;
            btnEliminarEspacio.Click += btnEliminarEspacio_Click;
            // 
            // textIdE
            // 
            textIdE.Location = new Point(429, 171);
            textIdE.Name = "textIdE";
            textIdE.ReadOnly = true;
            textIdE.Size = new Size(100, 23);
            textIdE.TabIndex = 65;
            // 
            // FormEspacios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(828, 442);
            Controls.Add(textIdE);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregarEspacio);
            Controls.Add(btnModificarEspacio);
            Controls.Add(btnEliminarEspacio);
            Controls.Add(textNombreE);
            Controls.Add(textNombre);
            Controls.Add(gridEspacios);
            Controls.Add(area);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEspacios";
            Text = "Espacios";
            FormClosed += FormEspacios_FormClosed;
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)gridEspacios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label area;
        private DataGridView gridEspacios;
        private Label textNombre;
        private TextBox textNombreE;
        private Button btnBorrar;
        private Button btnAgregarEspacio;
        private Button btnModificarEspacio;
        private Button btnEliminarEspacio;
        private TextBox textIdE;
    }
}