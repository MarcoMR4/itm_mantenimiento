namespace mantenimiento_proyecto
{
    partial class FormAreas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAreas));
            labelArea = new Label();
            textArea = new TextBox();
            btnGuardarArea = new Button();
            gridAreas = new DataGridView();
            btnEditar = new Button();
            textId = new TextBox();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridAreas).BeginInit();
            SuspendLayout();
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelArea.Location = new Point(65, 26);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(54, 25);
            labelArea.TabIndex = 0;
            labelArea.Text = "Area:";
            labelArea.Click += labelArea_Click;
            // 
            // textArea
            // 
            textArea.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textArea.Location = new Point(120, 23);
            textArea.Name = "textArea";
            textArea.PlaceholderText = "Escriba el nombre de area o departamento";
            textArea.Size = new Size(379, 29);
            textArea.TabIndex = 1;
            // 
            // btnGuardarArea
            // 
            btnGuardarArea.BackColor = Color.MediumAquamarine;
            btnGuardarArea.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardarArea.Location = new Point(426, 111);
            btnGuardarArea.Name = "btnGuardarArea";
            btnGuardarArea.Size = new Size(101, 31);
            btnGuardarArea.TabIndex = 2;
            btnGuardarArea.Text = "Guardar";
            btnGuardarArea.UseVisualStyleBackColor = false;
            btnGuardarArea.Click += btnGuardarArea_Click;
            // 
            // gridAreas
            // 
            gridAreas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridAreas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridAreas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridAreas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridAreas.DefaultCellStyle = dataGridViewCellStyle1;
            gridAreas.ImeMode = ImeMode.Off;
            gridAreas.Location = new Point(41, 181);
            gridAreas.MultiSelect = false;
            gridAreas.Name = "gridAreas";
            gridAreas.ReadOnly = true;
            gridAreas.RowTemplate.Height = 27;
            gridAreas.Size = new Size(458, 194);
            gridAreas.TabIndex = 3;
            gridAreas.CellClick += gridAreas_CellClick;
            gridAreas.CellContentClick += gridAreas_CellContentClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Khaki;
            btnEditar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(307, 111);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 31);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // textId
            // 
            textId.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(65, 143);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(92, 32);
            textId.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Salmon;
            btnEliminar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(179, 110);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 32);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkGray;
            btnLimpiar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(426, 143);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 31);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormAreas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(571, 386);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(textId);
            Controls.Add(btnEditar);
            Controls.Add(gridAreas);
            Controls.Add(btnGuardarArea);
            Controls.Add(textArea);
            Controls.Add(labelArea);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAreas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar area ";
            Load += FormAreas_Load;
            Leave += FormAreas_Leave;
            ((System.ComponentModel.ISupportInitialize)gridAreas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelArea;
        private TextBox textArea;
        private Button btnGuardarArea;
        private DataGridView gridAreas;
        private Button btnEditar;
        private TextBox textId;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}