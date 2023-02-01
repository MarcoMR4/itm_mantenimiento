using iTextSharp.text;
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
    public partial class FormServicios : Form
    {
        public FormServicios()
        {
            InitializeComponent();
            textAnio.Text = FormProgramaAnual.anioPlan;
            textPeriodo.Text = FormProgramaAnual.periodoPlan;
            textServicio.Text = FormProgramaAnual.nombreAreaElegida;
            mostrarServicios();

            mesesLista.Items.Add("enero");
            mesesLista.Items.Add("febrero");
            mesesLista.Items.Add("marzo");
            mesesLista.Items.Add("abril");
            mesesLista.Items.Add("mayo");
            mesesLista.Items.Add("junio");
            mesesLista.Items.Add("julio");
            mesesLista.Items.Add("agosto");
            mesesLista.Items.Add("septiembre");
            mesesLista.Items.Add("octubre");
            mesesLista.Items.Add("noviembre");
            mesesLista.Items.Add("diciembre");
        }

        private void btnAgregarHallazgo_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                string t1 = comboTipo.Text;
                int idArea1 = encontrarId();
                //MessageBox.Show(idArea1.ToString());
                Servicio s1 = new Servicio()
                {
                    descripcion = textDescripcion.Text,
                    tipoServicio = tipoServicio(t1).ToString(),
                    anio = int.Parse(textAnio.Text),
                    periodo = textPeriodo.Text,
                    idArea = idArea1,
                };

                foreach (var item in mesesLista.CheckedItems)
                {
                    //MessageBox.Show("Item: "+item.ToString());
                    if (item.ToString() == "enero")
                    { s1.enero = 1; }
                    if (item.ToString() == "febrero")
                    { s1.febrero = 1; }
                    if (item.ToString() == "marzo")
                    { s1.marzo = 1; }
                    if (item.ToString() == "abril")
                    { s1.abril = 1; }
                    if (item.ToString() == "mayo")
                    { s1.mayo = 1; }
                    if (item.ToString() == "junio")
                    { s1.junio = 1; }

                    if (item.ToString() == "julio")
                    { s1.julio = 1; }
                    if (item.ToString() == "agosto")
                    { s1.agosto = 1; }
                    if (item.ToString() == "septiembre")
                    { s1.septiembre = 1; }
                    if (item.ToString() == "octubre")
                    { s1.octubre = 1; }
                    if (item.ToString() == "noviembre")
                    { s1.noviembre = 1; }
                    if (item.ToString() == "diciembre")
                    { s1.diciembre = 1; }

                }
                
                //guardar en BD 
                bool respuesta = ServicioLogica.Instancia.Guardar(s1);
                if(respuesta) 
                {
                    mostrarServicios();
                }
                //guardar los meses en cada servicio , tabla Mes_Servicio


            }

        }

        public int encontrarId()
        {
            string a = FormProgramaAnual.nombreAreaElegida;
            int id = AreaLogica.Instancia.buscarArea(a);
            return id;
        }

        public bool validarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(textDescripcion.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(textPeriodo.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(textAnio.Text))
            {
                respuesta = false;
            }

            else
            {
                respuesta = true;
            }
            return respuesta;
        }

        public char tipoServicio(string tipo1)
        {
            char t;
            if (tipo1.Equals("Interno")){ t = 'I'; }
            else { t = 'E'; }

            return t;
        }

        public void mostrarServicios()
        {
           gridServicios.DataSource = ServicioLogica.Instancia.Listar(encontrarId());
           this.gridServicios.Columns["idServicio"].Visible = false;
           this.gridServicios.Columns["idArea"].Visible = false;
           this.gridServicios.Columns["periodo"].Visible = false;
           this.gridServicios.Columns["anio"].Visible = false;
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
           var h = mesesLista.Items[0].ToString();
            //MessageBox.Show(h);

            if (textPeriodo.Text == "enero-junio")
            {
                mesesLista.Items.Remove("julio");
                mesesLista.Items.Remove("agosto");
                mesesLista.Items.Remove("septiembre");
                mesesLista.Items.Remove("octubre");
                mesesLista.Items.Remove("noviembre");
                mesesLista.Items.Remove("diciembre");
            }
            else 
            {
                mesesLista.Items.Remove("enero");
                mesesLista.Items.Remove("febrero");
                mesesLista.Items.Remove("marzo");
                mesesLista.Items.Remove("abril");
                mesesLista.Items.Remove("mayo");
                mesesLista.Items.Remove("junio");
            }
        }
    }
}
