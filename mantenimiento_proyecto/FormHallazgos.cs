﻿using mantenimiento_proyecto.Models;
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
            this.gridHallazgos.Columns["idHallazgo"].Visible = false;
            this.gridHallazgos.Columns["idListaVerificacion"].Visible = false;
            this.gridHallazgos.Columns["nombreEspacio"].Visible = false;
            this.gridHallazgos.Columns["idEspacio"].Visible = false;
        }

        public void limpiar()
        {
            textNombreHallazgo.Text = null;
            comboAtendido.Text = "No";
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
    }
}