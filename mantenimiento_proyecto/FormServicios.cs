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
        }

        private void btnAgregarHallazgo_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                string t1 = comboTipo.Text;
                int idArea1 = encontrarId();
                MessageBox.Show(idArea1.ToString());
                Servicio s1 = new Servicio()
                {
                    descripcion = textDescripcion.Text,
                    tipoServicio = tipoServicio(t1).ToString(),
                    anio = int.Parse(textAnio.Text),
                    periodo = textPeriodo.Text,
                    idArea = idArea1
                };
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
        }
    }
}
