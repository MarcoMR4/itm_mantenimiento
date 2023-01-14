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
        public FormHallazgos()
        {
            InitializeComponent();
        }

        private void btnAgregarHallazgo_Click(object sender, EventArgs e)
        {
            //agregar 
            if (textNombreHallazgo.Text != string.Empty && comboAtendido.Text  != string.Empty)
            {
                Hallazgo hallazgo1 = new Hallazgo()
                {
                    descripcion = textNombreHallazgo.Text,
                    atendido= comboAtendido.Text,
                    idEspacio = FormListaNueva.idEspacioSeleccionado
                };
                bool respuesta = HallazgoLogica.Instancia.Guardar(hallazgo1);
                if (respuesta) 
                {
                    mostrarHallazgos();
                    limpiar();
                }
            }
        }

        private void FormHallazgos_Load(object sender, EventArgs e)
        {
            textEspacio.Text = FormListaNueva.nombreEspacioSeleccionado.ToString();
            mostrarHallazgos();
        }

        public void mostrarHallazgos()
        {
            string espacioBuscar = textEspacio.Text;
            int idHallado = EspacioLogica.Instancia.buscarEspacio(espacioBuscar);
            gridHallazgos.DataSource = HallazgoLogica.Instancia.Listar(idHallado);
        
        }

        public void limpiar()
        {
            textNombreHallazgo.Text = null;
            comboAtendido.Text = "No";
        }
    }
}
