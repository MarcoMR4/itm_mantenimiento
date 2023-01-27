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
            this.label1 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.gridEspacios = new System.Windows.Forms.DataGridView();
            this.textNombre = new System.Windows.Forms.Label();
            this.textNombreE = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregarEspacio = new System.Windows.Forms.Button();
            this.btnModificarEspacio = new System.Windows.Forms.Button();
            this.btnEliminarEspacio = new System.Windows.Forms.Button();
            this.textIdE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspacios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Espacios del área:";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.area.ForeColor = System.Drawing.Color.Navy;
            this.area.Location = new System.Drawing.Point(265, 23);
            this.area.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 29);
            this.area.TabIndex = 6;
            this.area.Text = "(nombre)";
            // 
            // gridEspacios
            // 
            this.gridEspacios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridEspacios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridEspacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEspacios.Location = new System.Drawing.Point(43, 253);
            this.gridEspacios.Name = "gridEspacios";
            this.gridEspacios.ReadOnly = true;
            this.gridEspacios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridEspacios.RowHeadersWidth = 70;
            this.gridEspacios.RowTemplate.Height = 27;
            this.gridEspacios.Size = new System.Drawing.Size(544, 244);
            this.gridEspacios.TabIndex = 7;
            this.gridEspacios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEspacios_CellClick);
            this.gridEspacios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEspacios_CellContentClick);
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textNombre.ForeColor = System.Drawing.Color.Black;
            this.textNombre.Location = new System.Drawing.Point(76, 86);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(261, 25);
            this.textNombre.TabIndex = 12;
            this.textNombre.Text = "Nombre de espacio revisado:";
            // 
            // textNombreE
            // 
            this.textNombreE.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombreE.Location = new System.Drawing.Point(342, 86);
            this.textNombreE.Name = "textNombreE";
            this.textNombreE.Size = new System.Drawing.Size(331, 29);
            this.textNombreE.TabIndex = 13;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(691, 122);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 40);
            this.btnBorrar.TabIndex = 63;
            this.btnBorrar.Text = "Limpiar campos";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregarEspacio
            // 
            this.btnAgregarEspacio.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarEspacio.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarEspacio.Location = new System.Drawing.Point(691, 78);
            this.btnAgregarEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEspacio.Name = "btnAgregarEspacio";
            this.btnAgregarEspacio.Size = new System.Drawing.Size(97, 40);
            this.btnAgregarEspacio.TabIndex = 61;
            this.btnAgregarEspacio.Text = "Agregar ";
            this.btnAgregarEspacio.UseVisualStyleBackColor = false;
            this.btnAgregarEspacio.Click += new System.EventHandler(this.btnAgregarEspacio_Click);
            // 
            // btnModificarEspacio
            // 
            this.btnModificarEspacio.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarEspacio.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarEspacio.Location = new System.Drawing.Point(590, 194);
            this.btnModificarEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEspacio.Name = "btnModificarEspacio";
            this.btnModificarEspacio.Size = new System.Drawing.Size(97, 40);
            this.btnModificarEspacio.TabIndex = 64;
            this.btnModificarEspacio.Text = "Modificar";
            this.btnModificarEspacio.UseVisualStyleBackColor = false;
            this.btnModificarEspacio.Click += new System.EventHandler(this.btnModificarEspacio_Click_1);
            // 
            // btnEliminarEspacio
            // 
            this.btnEliminarEspacio.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarEspacio.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarEspacio.Location = new System.Drawing.Point(691, 194);
            this.btnEliminarEspacio.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEspacio.Name = "btnEliminarEspacio";
            this.btnEliminarEspacio.Size = new System.Drawing.Size(97, 40);
            this.btnEliminarEspacio.TabIndex = 62;
            this.btnEliminarEspacio.Text = "Eliminar ";
            this.btnEliminarEspacio.UseVisualStyleBackColor = false;
            this.btnEliminarEspacio.Click += new System.EventHandler(this.btnEliminarEspacio_Click);
            // 
            // textIdE
            // 
            this.textIdE.Location = new System.Drawing.Point(429, 194);
            this.textIdE.Name = "textIdE";
            this.textIdE.ReadOnly = true;
            this.textIdE.Size = new System.Drawing.Size(100, 25);
            this.textIdE.TabIndex = 65;
            // 
            // FormEspacios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 501);
            this.Controls.Add(this.textIdE);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregarEspacio);
            this.Controls.Add(this.btnModificarEspacio);
            this.Controls.Add(this.btnEliminarEspacio);
            this.Controls.Add(this.textNombreE);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.gridEspacios);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label1);
            this.Name = "FormEspacios";
            this.Text = "Espacios";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEspacios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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