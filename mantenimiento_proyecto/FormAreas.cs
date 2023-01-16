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
    public partial class FormAreas : Form
    {
        public FormAreas()
        {
            InitializeComponent();
            mostrarAreas();
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
                    limpiar();
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

        public void limpiar()
        { 
            textArea.Text = string.Empty;
        }

        private void gridAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textArea.Text = gridAreas.Rows[e.RowIndex].Cells[1].Value.ToString();
            textId.Text = gridAreas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void gridAreas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textArea.Text = gridAreas.Rows[e.RowIndex].Cells[1].Value.ToString();
            textId.Text = gridAreas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Area area1 = new Area()
            {
                idArea = int.Parse(textId.Text),
                nombre = textArea.Text
            };

            bool respuesta = AreaLogica.Instancia.Editar(area1);

            if (respuesta)
            {
                mostrarAreas();
                limpiar();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Area area1 = new Area()
            {
                idArea = int.Parse(textId.Text),
            };
            bool respuesta = AreaLogica.Instancia.Eliminar(area1);
            if (respuesta)
            {
                mostrarAreas();
                limpiar();
            }

        }

        private void FormAreas_Load(object sender, EventArgs e)
        {

        }
    }
}
