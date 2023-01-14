using mantenimiento_proyecto.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantenimiento_proyecto
{
    public partial class FormProgramaAnual : Form
    {
        public FormProgramaAnual()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormPrincipal();
            formulario.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboAprobo.DataSource = PersonaLogica.Instancia.Listar();
            comboAprobo.ValueMember = "nombres";
            //comboAprobo.ValueMember += "apellidoPaterno";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FormPrincipal();
            formulario.Show();
            this.Close();

        }

        private void listaDeVerificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
