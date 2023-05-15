namespace mantenimiento_proyecto
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            registrarDepartamentoToolStripMenuItem = new ToolStripMenuItem();
            registrarPersonalToolStripMenuItem = new ToolStripMenuItem();
            listaDeVerificaciónToolStripMenuItem = new ToolStripMenuItem();
            planAnualToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, registrarDepartamentoToolStripMenuItem, registrarPersonalToolStripMenuItem, listaDeVerificaciónToolStripMenuItem, planAnualToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1043, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Image = (Image)resources.GetObject("inicioToolStripMenuItem.Image");
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(77, 27);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // registrarDepartamentoToolStripMenuItem
            // 
            registrarDepartamentoToolStripMenuItem.BackColor = Color.Transparent;
            registrarDepartamentoToolStripMenuItem.Image = (Image)resources.GetObject("registrarDepartamentoToolStripMenuItem.Image");
            registrarDepartamentoToolStripMenuItem.Name = "registrarDepartamentoToolStripMenuItem";
            registrarDepartamentoToolStripMenuItem.Size = new Size(83, 27);
            registrarDepartamentoToolStripMenuItem.Text = "Áreas";
            registrarDepartamentoToolStripMenuItem.Click += registrarDepartamentoToolStripMenuItem_Click;
            // 
            // registrarPersonalToolStripMenuItem
            // 
            registrarPersonalToolStripMenuItem.Image = (Image)resources.GetObject("registrarPersonalToolStripMenuItem.Image");
            registrarPersonalToolStripMenuItem.Name = "registrarPersonalToolStripMenuItem";
            registrarPersonalToolStripMenuItem.Size = new Size(170, 27);
            registrarPersonalToolStripMenuItem.Text = "Registrar Personal";
            registrarPersonalToolStripMenuItem.Click += registrarPersonalToolStripMenuItem_Click;
            // 
            // listaDeVerificaciónToolStripMenuItem
            // 
            listaDeVerificaciónToolStripMenuItem.Image = (Image)resources.GetObject("listaDeVerificaciónToolStripMenuItem.Image");
            listaDeVerificaciónToolStripMenuItem.Name = "listaDeVerificaciónToolStripMenuItem";
            listaDeVerificaciónToolStripMenuItem.Size = new Size(213, 27);
            listaDeVerificaciónToolStripMenuItem.Text = "Crear lista de verificación";
            listaDeVerificaciónToolStripMenuItem.Click += listaDeVerificaciónToolStripMenuItem_Click;
            // 
            // planAnualToolStripMenuItem
            // 
            planAnualToolStripMenuItem.Image = (Image)resources.GetObject("planAnualToolStripMenuItem.Image");
            planAnualToolStripMenuItem.Name = "planAnualToolStripMenuItem";
            planAnualToolStripMenuItem.Size = new Size(198, 27);
            planAnualToolStripMenuItem.Text = "Crear Programa Anual";
            planAnualToolStripMenuItem.Click += planAnualToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(46, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1032, 37);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al generador de documentos para el departamento de mantenimiento";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(57, 335);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 141);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(57, 188);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(149, 141);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1043, 512);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem listaDeVerificaciónToolStripMenuItem;
        private ToolStripMenuItem planAnualToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem registrarPersonalToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ToolStripMenuItem registrarDepartamentoToolStripMenuItem;
    }
}