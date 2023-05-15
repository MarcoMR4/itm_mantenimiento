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
        public static string nombreAreaV;
        public FormServicios()
        {
            InitializeComponent();
            if (FormHallazgos.hallazgo)
            {
                textAnio.Text = FormHallazgos.anio.ToString();
                textPeriodo.Text = FormHallazgos.periodo;
                textServicio.Text = FormHallazgos.area;
                nombreAreaV = textServicio.Text;
                textDescripcion.Text = FormHallazgos.descHallazgo;

                FormHallazgos.hallazgo = false;
            }
            else
            {
                textAnio.Text = FormProgramaAnual.anioPlan;
                textPeriodo.Text = FormProgramaAnual.periodoPlan;
                textServicio.Text = FormProgramaAnual.nombreAreaElegida;
                nombreAreaV = textServicio.Text;
            }

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

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
        }

        public int encontrarId()
        {
            string a = nombreAreaV;
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
            else if (string.IsNullOrEmpty(comboTipo.Text))
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
            if (tipo1.Equals("Interno")) { t = 'I'; }
            else { t = 'E'; }

            return t;
        }

        public void mostrarServicios()
        {
            //sMessageBox.Show("esto se recibe "+textAnio.Text);
            int anio = int.Parse(textAnio.Text);
            //mostrar servicios filtrando el semestre 
            if (textPeriodo.Text == "enero-junio")
            {
                gridServicios.DataSource = ServicioLogica.Instancia.Listar1(encontrarId(), anio);
            }
            else
            {
                gridServicios.DataSource = ServicioLogica.Instancia.Listar2(encontrarId(), anio);
            }
            ocultarCeldas();
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
            comboTipo.Text = "Interno";
        }

        private void gridServicios_Click(object sender, EventArgs e)
        {

        }

        private void gridServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            validarCelda(sender, e);
        }

        private void validarCelda(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textDescripcion.Text = gridServicios.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (gridServicios.Rows[e.RowIndex].Cells[2].Value.ToString() == "I")
                {
                    comboTipo.Text = "Interno";
                }
                else
                {
                    comboTipo.Text = "Externo";
                }
                //MessageBox.Show("valor: "+gridServicios.Rows[e.RowIndex].Cells[6].Value.ToString());
                //cambiar meses seleccionados 
                desmarcarTodo();
                if (textPeriodo.Text == "enero-junio")
                {
                    //MessageBox.Show("Äqui: "+ gridServicios.Rows[e.RowIndex].Cells[6].Value.ToString());
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[6].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Enero si esta seleccionado");
                        mesesLista.SetItemChecked(0, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[7].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Febrero si esta seleccionado");
                        mesesLista.SetItemChecked(1, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[8].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Marzo si esta seleccionado");
                        mesesLista.SetItemChecked(2, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[9].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Abril si esta seleccionado");
                        mesesLista.SetItemChecked(3, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[10].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Mayo si esta seleccionado");
                        mesesLista.SetItemChecked(4, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[11].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Junio si esta seleccionado");
                        mesesLista.SetItemChecked(5, true);
                    }
                }
                else
                {
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[12].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("julio si esta seleccionado");
                        mesesLista.SetItemChecked(0, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[13].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("agosto si esta seleccionado");
                        mesesLista.SetItemChecked(1, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[14].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Septiembre si esta seleccionado");
                        mesesLista.SetItemChecked(2, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[15].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("octubre si esta seleccionado");
                        mesesLista.SetItemChecked(3, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[16].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("noviembre si esta seleccionado");
                        mesesLista.SetItemChecked(4, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[17].Value.ToString()) == 1)
                    {
                        //MessageBox.Show("Diciembre si esta seleccionado");
                        mesesLista.SetItemChecked(5, true);
                    }
                }

                textId.Text = gridServicios.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, debe seleccionar una fila válida \n\n\n" + ex.Message);
                //this.Close();
            }


        }

        private void desmarcarTodo()
        {
            for (int i = 0; i < mesesLista.Items.Count; i++)
            {
                mesesLista.SetItemChecked(i, false);
            }
        }

        private void ocultarCeldas()
        {
            this.gridServicios.Columns["idServicio"].Visible = false;
            this.gridServicios.Columns["idArea"].Visible = false;
            this.gridServicios.Columns["periodo"].Visible = false;
            this.gridServicios.Columns["anio"].Visible = false;
            this.gridServicios.Columns["enero"].Visible = false;
            this.gridServicios.Columns["febrero"].Visible = false;
            this.gridServicios.Columns["marzo"].Visible = false;
            this.gridServicios.Columns["abril"].Visible = false;
            this.gridServicios.Columns["mayo"].Visible = false;
            this.gridServicios.Columns["junio"].Visible = false;
            this.gridServicios.Columns["julio"].Visible = false;
            this.gridServicios.Columns["agosto"].Visible = false;
            this.gridServicios.Columns["septiembre"].Visible = false;
            this.gridServicios.Columns["octubre"].Visible = false;
            this.gridServicios.Columns["noviembre"].Visible = false;
            this.gridServicios.Columns["diciembre"].Visible = false;
        }

        private void btnModificarServicio_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            textDescripcion.Text = string.Empty;
            comboTipo.Text = "Interno";
            textId.Text = string.Empty;
            desmarcarTodo();
        }

        private void btnAgregarServicio_Click_1(object sender, EventArgs e)
        {
            if (textId.Text == string.Empty)
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
                    if (respuesta)
                    {
                        mostrarServicios();
                        limpiar();
                    }
                    //guardar los meses en cada servicio , tabla Mes_Servicio
                }
            }
            else
            {
                MessageBox.Show("Favor de limpiar los campos antes de agregar ");
                limpiar();
            }
        }

        private void btnModificarServicio_Click_1(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                string t1 = comboTipo.Text;
                int idArea1 = encontrarId();
                int idServicio1 = int.Parse(textId.Text);
                //MessageBox.Show(idArea1.ToString());
                Servicio s1 = new Servicio()
                {
                    idServicio = idServicio1,
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
                bool respuesta = ServicioLogica.Instancia.Editar(s1);
                if (respuesta)
                {
                    mostrarServicios();
                    limpiar();
                }

            }
        }

        private void btnEliminarServicio_Click_1(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                int idServicio1 = int.Parse(textId.Text);
                //MessageBox.Show(idArea1.ToString());
                Servicio s1 = new Servicio()
                {
                    idServicio = idServicio1
                };


                //BD
                bool respuesta = ServicioLogica.Instancia.Eliminar(s1);
                if (respuesta)
                {
                    mostrarServicios();
                    limpiar();
                }

            }
        }
    }
}
