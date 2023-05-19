//Código para formulario de hallazgos, lista de verificación

using mantenimiento_proyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantenimiento_proyecto.Logica
{
    public partial class FormHallazgos : Form
    {
        //variables globales 
        public static int anio;
        public static string periodo;
        public static bool hallazgo = false;
        public static string area;
        public static string descHallazgo;
        public FormHallazgos() //Inicializar formulario 
        {
            InitializeComponent();
            area = FormListaNueva.nombreAreaSeleccionada;
            descHallazgo = textNombreHallazgo.Text;
        }

        //Función para agregar un hallazgo, listas de verififación
        private void btnAgregarHallazgo_Click(object sender, EventArgs e)
        {
            try
            {
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

                        //  DEscripcion pasar ,MessageBox.Show(descHallazgo);
                        hallazgo = true;
                        FormServicios form1 = new FormServicios();
                        form1.Show();                         //PASAR NOMBRE DE SERVICIO***********
                                                              //this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Campos limpiados, ahora si puede agregar");
                    limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar guardar hallazgo");
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        //Cargar formulario 
        private void FormHallazgos_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Mensaje interrogativo", "Ejemplo Mensaje Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            textEspacio.Text = FormListaNueva.nombreEspacioSeleccionado.ToString();
            textAnio.Text = FormListaNueva.anio.ToString();
            textPeriodo.Text = FormListaNueva.periodo;
            mostrarHallazgos();
            anio = int.Parse(textAnio.Text);
            periodo = textPeriodo.Text;
            comboAtendido.Text = "No";
        }

        //Cargar hallazgos de la base de datos 
        public void mostrarHallazgos()
        {
            anio = int.Parse(textAnio.Text);
            periodo = textPeriodo.Text;
            string espacioBuscar = textEspacio.Text;
            try
            {
                int idHallado = EspacioLogica.Instancia.buscarEspacio(espacioBuscar);
                gridHallazgos.DataSource = HallazgoLogica.Instancia.Listar(idHallado, anio, periodo);
                this.gridHallazgos.Columns["idHallazgo"].Visible = false;
                this.gridHallazgos.Columns["nombreEspacio"].Visible = false;
                this.gridHallazgos.Columns["idEspacio"].Visible = false;
                this.gridHallazgos.Columns["anio"].Visible = false;
                this.gridHallazgos.Columns["periodo"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar de la base de datos");
            }

        }

        //Limpiar campos para poder agregar un nuevo registro en la tabla hallazgos 
        public void limpiar()
        {
            textNombreHallazgo.Text = string.Empty;
            comboAtendido.Text = "No";
            textIdE.Text = string.Empty;
        }

        //Editar información de un registro en la tabla de hallazgos 
        private void btnModificarHallazgo_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Seleccione un registro de la tabla primero");
            }

        }

        private void gridHallazgos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        //Eliminar un registro de la tabla hallazgos 
        private void btnEliminarHallazgo_Click(object sender, EventArgs e)
        {
            try
            {
                Hallazgo hallazgo1 = new Hallazgo()
                {
                    idHallazgo = int.Parse(textIdE.Text),
                };
                bool respuesta = HallazgoLogica.Instancia.Eliminar(hallazgo1);
                if (respuesta)
                {
                    MessageBox.Show("Area eliminada");
                    mostrarHallazgos();
                    limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un área en la tabla");
            }


        }

        //Clic en una celda 
        private void gridHallazgos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        //Revisar valor de fila seleccionada en la tabla de hallazgos 
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

        //Cerrar formulario


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormHallazgos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormListaNueva forml = new FormListaNueva();
            MessageBox.Show("Vuelva a abrir Crear lista de verificación en la barra superior para actualizar datos");
            forml.Refresh();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
