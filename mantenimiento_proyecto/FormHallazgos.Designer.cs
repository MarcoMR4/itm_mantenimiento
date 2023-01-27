﻿namespace mantenimiento_proyecto.Logica
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
            ((System.ComponentModel.ISupportInitialize)(this.gridHallazgos)).BeginInit();
            this.SuspendLayout();
            // 
            // textEspacio
            // 
            this.textEspacio.AutoSize = true;
            this.textEspacio.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textEspacio.ForeColor = System.Drawing.Color.Navy;
            this.textEspacio.Location = new System.Drawing.Point(270, 25);
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
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hallazgos del espacio:";
            // 
            // textIdE
            // 
            this.textIdE.Location = new System.Drawing.Point(487, 215);
            this.textIdE.Name = "textIdE";
            this.textIdE.ReadOnly = true;
            this.textIdE.Size = new System.Drawing.Size(100, 25);
            this.textIdE.TabIndex = 73;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(637, 132);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(169, 40);
            this.btnBorrar.TabIndex = 71;
            this.btnBorrar.Text = "Limpiar campos";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarHallazgo
            // 
            this.btnAgregarHallazgo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAgregarHallazgo.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarHallazgo.Location = new System.Drawing.Point(709, 88);
            this.btnAgregarHallazgo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarHallazgo.Name = "btnAgregarHallazgo";
            this.btnAgregarHallazgo.Size = new System.Drawing.Size(97, 40);
            this.btnAgregarHallazgo.TabIndex = 69;
            this.btnAgregarHallazgo.Text = "Agregar ";
            this.btnAgregarHallazgo.UseVisualStyleBackColor = false;
            this.btnAgregarHallazgo.Click += new System.EventHandler(this.btnAgregarHallazgo_Click);
            // 
            // btnModificarHallazgo
            // 
            this.btnModificarHallazgo.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarHallazgo.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarHallazgo.Location = new System.Drawing.Point(608, 204);
            this.btnModificarHallazgo.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarHallazgo.Name = "btnModificarHallazgo";
            this.btnModificarHallazgo.Size = new System.Drawing.Size(97, 40);
            this.btnModificarHallazgo.TabIndex = 72;
            this.btnModificarHallazgo.Text = "Modificar";
            this.btnModificarHallazgo.UseVisualStyleBackColor = false;
            this.btnModificarHallazgo.Click += new System.EventHandler(this.btnModificarHallazgo_Click);
            // 
            // btnEliminarHallazgo
            // 
            this.btnEliminarHallazgo.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarHallazgo.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarHallazgo.Location = new System.Drawing.Point(709, 204);
            this.btnEliminarHallazgo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarHallazgo.Name = "btnEliminarHallazgo";
            this.btnEliminarHallazgo.Size = new System.Drawing.Size(97, 40);
            this.btnEliminarHallazgo.TabIndex = 70;
            this.btnEliminarHallazgo.Text = "Eliminar ";
            this.btnEliminarHallazgo.UseVisualStyleBackColor = false;
            this.btnEliminarHallazgo.Click += new System.EventHandler(this.btnEliminarHallazgo_Click);
            // 
            // textNombreHallazgo
            // 
            this.textNombreHallazgo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombreHallazgo.Location = new System.Drawing.Point(326, 95);
            this.textNombreHallazgo.Name = "textNombreHallazgo";
            this.textNombreHallazgo.Size = new System.Drawing.Size(331, 29);
            this.textNombreHallazgo.TabIndex = 68;
            // 
            // textNombre
            // 
            this.textNombre.AutoSize = true;
            this.textNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textNombre.ForeColor = System.Drawing.Color.Black;
            this.textNombre.Location = new System.Drawing.Point(139, 95);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(187, 25);
            this.textNombre.TabIndex = 67;
            this.textNombre.Text = "Nombre de hallazgo:";
            // 
            // gridHallazgos
            // 
            this.gridHallazgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHallazgos.Location = new System.Drawing.Point(61, 249);
            this.gridHallazgos.Name = "gridHallazgos";
            this.gridHallazgos.ReadOnly = true;
            this.gridHallazgos.RowHeadersWidth = 51;
            this.gridHallazgos.RowTemplate.Height = 27;
            this.gridHallazgos.Size = new System.Drawing.Size(745, 239);
            this.gridHallazgos.TabIndex = 66;
            this.gridHallazgos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHallazgos_CellClick);
            this.gridHallazgos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridHallazgos_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(229, 155);
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
            this.comboAtendido.Location = new System.Drawing.Point(326, 159);
            this.comboAtendido.Margin = new System.Windows.Forms.Padding(2);
            this.comboAtendido.Name = "comboAtendido";
            this.comboAtendido.Size = new System.Drawing.Size(118, 25);
            this.comboAtendido.TabIndex = 75;
            this.comboAtendido.Text = "No";
            // 
            // FormHallazgos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 515);
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
    }
}