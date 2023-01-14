﻿using mantenimiento_proyecto.Logica;
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
using static System.Net.Mime.MediaTypeNames;

namespace mantenimiento_proyecto
{
    public partial class Form6 : Form
    {
        int idArea2 = 0;
        public Form6()
        {
            InitializeComponent();
            int idArea1 = Form2.idAreaSeleccionada;
            //MessageBox.Show(idArea1.ToString());
            gridEspacios.DataSource = EspacioLogica.Instancia.Listar(idArea1);
            area.Text = Form2.nombreAreaSeleccionada;
            idArea2 = idArea1;
            mostrarEspacios();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEspacio_Click(object sender, EventArgs e)
        {
            if (textNombreE.Text != string.Empty) {
           
                Espacio espacio1 = new Espacio()
                {
                    nombre = textNombreE.Text,
                    idArea = idArea2
                };
          
                //MessageBox.Show("id Area:"+idArea2.ToString());
                bool respuesta = EspacioLogica.Instancia.Guardar(espacio1);

                if (respuesta)
                {
                    mostrarEspacios();
                    limpiar();
                }

            }
        }


        public void mostrarEspacios() 
        {
            gridEspacios.DataSource = null;
            gridEspacios.DataSource = EspacioLogica.Instancia.Listar(idArea2);
        }

        public void limpiar() 
        {
            textNombreE.Text = string.Empty;
            textIdE.Text = string.Empty;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnModificarEspacio_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Entro");
            Espacio espacio1 = new Espacio()
            {
                idEspacio = int.Parse(textIdE.Text),
                nombre = textNombreE.Text,
            };
            bool respuesta = EspacioLogica.Instancia.Editar(espacio1);
            if (respuesta)
            {
                mostrarEspacios();
                limpiar();
                //MessageBox.Show("Editado");
            }
            
        }

        private void btnEliminarEspacio_Click(object sender, EventArgs e)
        {
            Espacio espacio1 = new Espacio()
            {
                idEspacio = int.Parse(textIdE.Text),
                nombre = textNombre.Text,
            };
            bool respuesta = EspacioLogica.Instancia.Eliminar(espacio1);
            if (respuesta)
            {
                mostrarEspacios();
                limpiar();
            }
        }

        private void gridEspacios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textIdE.Text = gridEspacios.Rows[e.RowIndex].Cells[0].Value.ToString();
            textNombreE.Text = gridEspacios.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
    }
}
