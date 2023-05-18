//Formulario para agregar espacio, listas de verifiación 

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
using static System.Net.Mime.MediaTypeNames;

namespace mantenimiento_proyecto
{
    public partial class FormEspacios : Form
    {
        //Variables globales 
        int idArea2 = 0;  //mostrar espacios segun el área seleccionada 

        //Inicializar ventana o formulario 
        public FormEspacios()
        {
            InitializeComponent();
            int idArea1 = FormListaNueva.idAreaSeleccionada;
            //MessageBox.Show(idArea1.ToString());
            gridEspacios.DataSource = EspacioLogica.Instancia.Listar(idArea1);
            area.Text = FormListaNueva.nombreAreaSeleccionada;
            idArea2 = idArea1;
            mostrarEspacios();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        //Agregar un Espacio
        private void btnAgregarEspacio_Click(object sender, EventArgs e)
        {
            try
            {
                if (textIdE.Text == string.Empty)
                {
                    if (textNombreE.Text != string.Empty)
                    {

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
                else
                {
                    MessageBox.Show("borrar los campos antes de agregar");
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar Espacio");
                Console.WriteLine(ex.Message);
            }


        }

        //Cargar espacios desde la base de datos 
        public void mostrarEspacios()
        {
            try
            {
                gridEspacios.DataSource = null;
                gridEspacios.DataSource = EspacioLogica.Instancia.Listar(idArea2);
                this.gridEspacios.Columns["idEspacio"].Visible = false;
                this.gridEspacios.Columns["idArea"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Espacios desde la base de datos");
                Console.WriteLine(ex.Message);
            }

        }

        //Limpiar campos de formulario para poder agregar nuevos registros a la tabla 
        public void limpiar()
        {
            textNombreE.Text = string.Empty;
            textIdE.Text = string.Empty;
        }

        //Llamar a limpar campos de formulario 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        //Editar un registro de la base de datos 
        private void btnModificarEspacio_Click_1(object sender, EventArgs e)
        {
            try
            {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un espacio de la tabla");
            }

        }

        //Eliminar un registro de la base de datos 
        private void btnEliminarEspacio_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un espacio de la tabla");
            }

        }

        //Seleccionar un registro de la tabla, evento 
        private void gridEspacios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }
        //Seleccionar un registro de la tabla, evento 
        private void gridEspacios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        //Validar que se ha seleccinado una fila de la tabla 
        private void validarCelda(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textIdE.Text = gridEspacios.Rows[e.RowIndex].Cells[0].Value.ToString();
                textNombreE.Text = gridEspacios.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, debe seleccionar una fila válida \n\n\n" + ex.Message);
                this.Close();
            }


        }

        //Actualizar informacion en formListaVerificacion
        private void FormEspacios_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormListaNueva forml = new FormListaNueva();
            MessageBox.Show("Vuelva a abrir Crear lista de verificación en la barra superior para actualizar");
            forml.Refresh();
        }
    }
}
