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
            this.textArea.Size = new System.Drawing.Size(302, 32);
            this.textArea.TabIndex = 1;
            // 
            // btnGuardarArea
            // 
            this.btnGuardarArea.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarArea.Location = new System.Drawing.Point(295, 73);
            this.btnGuardarArea.Name = "btnGuardarArea";
            this.btnGuardarArea.Size = new System.Drawing.Size(101, 31);
            this.btnGuardarArea.TabIndex = 2;
            this.btnGuardarArea.Text = "Guardar";
            this.btnGuardarArea.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 263);
            this.Controls.Add(this.btnGuardarArea);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.labelArea);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar area ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelArea;
        private TextBox textArea;
        private Button btnGuardarArea;
    }
}