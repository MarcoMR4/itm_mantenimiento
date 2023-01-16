namespace mantenimiento_proyecto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listaDeVerificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormListaNueva();
            formulario.Show();
            this.Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void planAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormProgramaAnual();
            formulario.Show();
            this.Hide();
        }

        private void registrarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormPersonal();
            formulario.Show();
            this.Hide();
        }
    }
}