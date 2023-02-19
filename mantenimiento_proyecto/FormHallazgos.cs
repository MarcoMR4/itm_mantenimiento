using mantenimiento_proyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantenimiento_proyecto.Logica
{
    public partial class FormHallazgos : Form
    {
        public static int anio;
        public static string periodo;
        public static bool hallazgo = false;
        public static string area;
        public static string descHallazgo;
        public FormHallazgos()
        {
            InitializeComponent();
            area = FormListaNueva.nombreAreaSeleccionada;
            descHallazgo = textNombreHallazgo.Text;
        }

        private void btnAgregarHallazgo_Click(object sender, EventArgs e)
        {
            //agregar 
            if (textIdE.Text == string.Empty)
            {
                if (textNombreHallazgo.Text != string.Empty && comboAtendido.Text != string.Empty)
                {
                    Hallazgo hallazgo1 = new Hallazgo()
                    {
                        descripcion = textNombreHallazgo.Text,
                        atendido = comboAtendido.Text,
                        idEspacio = FormListaNueva.idEspacioSeleccionado,
                        anio = int.Parse(textAnio.Text),
                        periodo = textPeriodo.Text
                    };
                    descHallazgo = hallazgo1.descripcion;
                    bool respuesta = HallazgoLogica.Instancia.Guardar(hallazgo1);
                    if (respuesta)
                    {
                        mostrarHallazgos();
                        limpiar();
                    }
                }
                //preguntar si se desea guardar como servicio 
                var servicio = MessageBox.Show("Guardar como servicio?", "Ejemplo Mensaje Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (servicio == System.Windows.Forms.DialogResult.OK)
                {
      
                    MessageBox.Show(descHallazgo);
                    hallazgo = true;
                    FormServicios form1 = new FormServicios();
                    form1.Show();                         //PASAR NOMBRE DE SERVICIO***********
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Campos limpiados, ahora si puede agregar");
                limpiar();
            }
        }

        private void FormHallazgos_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Mensaje interrogativo", "Ejemplo Mensaje Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            textEspacio.Text = FormListaNueva.nombreEspacioSeleccionado.ToString();
            textAnio.Text = FormListaNueva.anio.ToString();
            textPeriodo.Text = FormListaNueva.periodo;
            mostrarHallazgos();
            anio = int.Parse(textAnio.Text);
            periodo = textPeriodo.Text;

            MessageBox.Show(anio.ToString());


        }

        public void mostrarHallazgos()
        {
            anio = int.Parse(textAnio.Text);
            periodo = textPeriodo.Text;
            string espacioBuscar = textEspacio.Text;
            int idHallado = EspacioLogica.Instancia.buscarEspacio(espacioBuscar);
            gridHallazgos.DataSource = HallazgoLogica.Instancia.Listar(idHallado, anio, periodo);
            this.gridHallazgos.Columns["idHallazgo"].Visible = false;
            this.gridHallazgos.Columns["nombreEspacio"].Visible = false;
            this.gridHallazgos.Columns["idEspacio"].Visible = false;
            this.gridHallazgos.Columns["anio"].Visible = false;
            this.gridHallazgos.Columns["periodo"].Visible = false;
        }

        public void limpiar()
        {
            textNombreHallazgo.Text = null;
            comboAtendido.Text = "No";
            textIdE.Text = string.Empty; 
        }

        private void btnModificarHallazgo_Click(object sender, EventArgs e)
        {
            Hallazgo hallazgo1 = new Hallazgo()
            {
                idHallazgo = int.Parse(textIdE.Text),
                descripcion = textNombreHallazgo.Text,
                atendido = comboAtendido.Text
            };
            bool respuesta = HallazgoLogica.Instancia.Editar(hallazgo1);
            if (respuesta)
            {
                mostrarHallazgos();
                limpiar();
                //MessageBox.Show("Editado");
            }
        }

        private void gridHallazgos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        private void btnEliminarHallazgo_Click(object sender, EventArgs e)
        {
            Hallazgo hallazgo1 = new Hallazgo()
            {
                idHallazgo = int.Parse(textIdE.Text),
            };
            bool respuesta = HallazgoLogica.Instancia.Eliminar(hallazgo1);
            if (respuesta)
            {
                mostrarHallazgos();
                limpiar();
            }

        }

        private void gridHallazgos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        private void validarCelda(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textIdE.Text = gridHallazgos.Rows[e.RowIndex].Cells[0].Value.ToString();
                textNombreHallazgo.Text = gridHallazgos.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboAtendido.Text = gridHallazgos.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, debe seleccionar una fila válida \n\n\n" + ex.Message);
                //this.Close();
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
