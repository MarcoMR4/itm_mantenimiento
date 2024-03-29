﻿using mantenimiento_proyecto.Logica;
using mantenimiento_proyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mantenimiento_proyecto
{
    public partial class FormPersonal : Form
    {
        public FormPersonal()
        {
            InitializeComponent();
            //MessageBox.Show(PersonaLogica.Instancia.Listar().ToString());
            mostrarPersonal();
            comboArea.DataSource = AreaLogica.Instancia.Listar();
            // mostrar nombre de area 
            comboArea.DisplayMember = "nombre";

            //comboBox.ValueMember = "Index";
        }



        public void limpiar()
        {
            textNombre.Text = string.Empty;
            textID.Text = string.Empty;
        }

        private void listaDeVerificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormListaNueva();
            formulario.Show();
            this.Hide();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        private void registrarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAreas();
            formulario.Show();
        }

        private void comboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            if (textID.Text == String.Empty)
            {
                if (validarDatos())
                {
                    var nombreArea1 = comboArea.Text;
                    int idArea2 = AreaLogica.Instancia.buscarArea(nombreArea1);
                    //MessageBox.Show(idArea2);
                    Personal persona1 = new Personal()
                    {
                        nombre = textNombre.Text,
                        idArea = idArea2
                    };

                    bool respuesta = PersonaLogica.Instancia.Guardar(persona1);

                    if (respuesta)
                    {
                        mostrarPersonal();
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Borrar campos primero ");
                }



            }
        }

        public void mostrarPersonal()
        {
            gridPersonal.DataSource = null;
            gridPersonal.DataSource = PersonaLogica.Instancia.ListarGeneral();
            this.gridPersonal.Columns["idPersonal"].Visible = false;
            this.gridPersonal.Columns["idArea"].Visible = false;
        }

        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                var area1 = comboArea.Text;
                var idArea1 = AreaLogica.Instancia.buscarArea(area1);
                Personal persona1 = new Personal()
                {
                    idPersonal = int.Parse(textID.Text),
                    nombre = textNombre.Text,
                    idArea = idArea1
                };
                bool respuesta = PersonaLogica.Instancia.Eliminar(persona1);
                if (respuesta)
                {
                    mostrarPersonal();
                    limpiar();
                }
            }

        }

        private void btnModificarPersonal_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                var area1 = comboArea.Text;
                var idArea1 = AreaLogica.Instancia.buscarArea(area1);
                Personal persona1 = new Personal()
                {
                    idPersonal = int.Parse(textID.Text),
                    nombre = textNombre.Text,
                    idArea = idArea1
                };
                bool respuesta = PersonaLogica.Instancia.Editar(persona1);
                if (respuesta)
                {
                    mostrarPersonal();
                    limpiar();
                }
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //cargar ventana 
        private void FormPersonal_Load(object sender, EventArgs e)
        {
            if (revisarAreas() == false)
            {
                MessageBox.Show("No existen áreas registradas \n\n favor de presionar en el botón \"Areas \" en la barra superior ");
            }

        }

        //funcion para revisar que en la base de datos haya departamentos o areas guardados 
        private bool revisarAreas()
        {
            bool resultado = true;
            List<Area> areas = new List<Area>();
            areas = AreaLogica.Instancia.Listar();
            if (areas.Count == 0)
            {
                resultado = false;
            }
            return resultado;
        }
        private void gridPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        private void validarCelda(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textID.Text = gridPersonal.Rows[e.RowIndex].Cells[0].Value.ToString();
                textNombre.Text = gridPersonal.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboArea.Text = gridPersonal.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, debe seleccionar una fila válida \n\n\n" + ex.Message);
                //this.Close();
            }


        }

        private void registrarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormPersonal();
            formulario.Show();
        }

        public void reiniciar()
        {
            Form formulario = new FormPersonal();
            this.Close();
            formulario.Show();
        }

        private void planAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormProgramaAnual();
            formulario.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
