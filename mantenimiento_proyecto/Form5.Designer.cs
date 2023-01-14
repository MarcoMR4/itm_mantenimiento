namespace mantenimiento_proyecto
{
    partial class Form5
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
            this.labelArea = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.TextBox();
            this.btnGuardarArea = new System.Windows.Forms.Button();
            this.gridAreas = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArea.Location = new System.Drawing.Point(24, 26);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(54, 25);
            this.labelArea.TabIndex = 0;
            this.labelArea.Text = "Area:";
            // 
            // textArea
            // 
            this.textArea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textArea.Location = new System.Drawing.Point(94, 26);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(405, 32);
            this.textArea.TabIndex = 1;
            // 
            // btnGuardarArea
            // 
            this.btnGuardarArea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarArea.Location = new System.Drawing.Point(426, 126);
            this.btnGuardarArea.Name = "btnGuardarArea";
            this.btnGuardarArea.Size = new System.Drawing.Size(101, 31);
            this.btnGuardarArea.TabIndex = 2;
            this.btnGuardarArea.Text = "Guardar";
            this.btnGuardarArea.UseVisualStyleBackColor = true;
            this.btnGuardarArea.Click += new System.EventHandler(this.btnGuardarArea_Click);
            // 
            // gridAreas
            // 
            this.gridAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAreas.Location = new System.Drawing.Point(65, 184);
            this.gridAreas.Name = "gridAreas";
            this.gridAreas.ReadOnly = true;
            this.gridAreas.RowTemplate.Height = 27;
            this.gridAreas.Size = new System.Drawing.Size(462, 241);
            this.gridAreas.TabIndex = 3;
            this.gridAreas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAreas_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(307, 126);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 31);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textId.Location = new System.Drawing.Point(65, 125);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(92, 32);
            this.textId.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(179, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 31);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 437);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gridAreas);
            this.Controls.Add(this.btnGuardarArea);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.labelArea);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar area ";
            ((System.ComponentModel.ISupportInitialize)(this.gridAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelArea;
        private TextBox textArea;
        private Button btnGuardarArea;
        private DataGridView gridAreas;
        private Button btnEditar;
        private TextBox textId;
        private Button btnEliminar;
    }
}