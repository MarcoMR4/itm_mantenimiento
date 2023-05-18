//Librerías 
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
    public partial class FormAreas : Form    //Clase que controla el comportmiento del formulario 
    {
        public FormAreas()
        {
            InitializeComponent();
            mostrarAreas();
        }

        //Guardar area en la base de datos 
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

        //Cargar las areas guardadas en la base de datos 
        public void mostrarAreas()
        {
            gridAreas.DataSource = null;
            gridAreas.DataSource = AreaLogica.Instancia.Listar();
        }

        //Comprobar que los campos se llenaron 
        public bool validarDatos()
        {
            string nombre = textArea.Text;
            string id = textId.Text;
            bool respuesta;
            if (string.IsNullOrEmpty(nombre))
            {
                respuesta = false;
                MessageBox.Show("Ingrese un nombre para el area");
            }
            else if (string.IsNullOrEmpty(id))
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
                MessageBox.Show("Seleccione el boton limpiar y escriba un nombre de area, luego presione guardar");
            }
            return respuesta;
        }

        //Borrar campos 
        public void limpiar()
        {
            textArea.Text = string.Empty;
        }

        private void gridAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }
        private void gridAreas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        //Botón de editar 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un area en la tabla");
            }


        }

        //Botón de eliminar 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un area en la tabla");
            }
        }

        private void FormAreas_Load(object sender, EventArgs e)
        {

        }

        private void FormAreas_Close(object sender, EventArgs e)
        {
            Form formulario = new FormPersonal();
            formulario.Close();
            formulario.Show();
        }

        private void gridAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);

        }

        private void validarCelda(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textArea.Text = gridAreas.Rows[e.RowIndex].Cells[1].Value.ToString();
                textId.Text = gridAreas.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, debe seleccionar una fila válida \n\n\n" + ex.Message);
                this.Close();
            }


        }

        private void FormAreas_Leave(object sender, EventArgs e)
        {
            Form formulario = new FormPersonal();
            formulario.Refresh();
        }

        private void labelArea_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textId.Text = null;
            textArea.Text = null;
        }
    }
}
