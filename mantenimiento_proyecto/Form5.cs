using mantenimiento_proyecto.Logica;
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

namespace mantenimiento_proyecto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            mostrarAreas();
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnGuardarArea_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(nombre);

            if (validarDatos())
            {
                Area area1 = new Area()
                {
                    nombre = textArea.Text
                };

                bool respuesta = AreaLogica.Instancia.Guardar(area1);

                if (respuesta)
                {
                    mostrarAreas();
                }
                

            }

         
        }

        public void mostrarAreas()
        {
            gridAreas.DataSource = null;
            gridAreas.DataSource = AreaLogica.Instancia.Listar();
        }

        public bool validarDatos()
        {
            string nombre = textArea.Text;
            bool respuesta;
            if (string.IsNullOrEmpty(nombre))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }

        private void gridAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
