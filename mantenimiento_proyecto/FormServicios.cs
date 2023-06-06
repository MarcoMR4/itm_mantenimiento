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
            InitializeComponent();   //Inicializar 
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
            mesesLista2.Items.Add("enero");
            mesesLista2.Items.Add("febrero");
            mesesLista2.Items.Add("marzo");
            mesesLista2.Items.Add("abril");
            mesesLista2.Items.Add("mayo");
            mesesLista2.Items.Add("junio");
            mesesLista2.Items.Add("julio");
            mesesLista2.Items.Add("agosto");
            mesesLista2.Items.Add("septiembre");
            mesesLista2.Items.Add("octubre");
            mesesLista2.Items.Add("noviembre");
            mesesLista2.Items.Add("diciembre");
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

        public bool validarDatos()  //validar datos ingresados 
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
        } //Ver tipo de servicio 

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

        private void FormServicios_Load(object sender, EventArgs e)  //abrir formulario 
        {
            var h = mesesLista.Items[0].ToString();
            //MessageBox.Show(h);
                    //Poner los meses del periodo que compete 
            if (textPeriodo.Text == "enero-junio")
            {
                mesesLista.Items.Remove("julio");
                mesesLista.Items.Remove("agosto");
                mesesLista.Items.Remove("septiembre");
                mesesLista.Items.Remove("octubre");
                mesesLista.Items.Remove("noviembre");
                mesesLista.Items.Remove("diciembre");
                mesesLista2.Items.Remove("julio");
                mesesLista2.Items.Remove("agosto");
                mesesLista2.Items.Remove("septiembre");
                mesesLista2.Items.Remove("octubre");
                mesesLista2.Items.Remove("noviembre");
                mesesLista2.Items.Remove("diciembre");
            }
            else
            {

                mesesLista.Items.Remove("enero");
                mesesLista.Items.Remove("febrero");
                mesesLista.Items.Remove("marzo");
                mesesLista.Items.Remove("abril");
                mesesLista.Items.Remove("mayo");
                mesesLista.Items.Remove("junio");
                mesesLista2.Items.Remove("enero");
                mesesLista2.Items.Remove("febrero");
                mesesLista2.Items.Remove("marzo");
                mesesLista2.Items.Remove("abril");
                mesesLista2.Items.Remove("mayo");
                mesesLista2.Items.Remove("junio");
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
            {   //Revisar si el servicio sera interno o externo 
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
                    //Mostrar meses de solo programado
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

                    //Mostrar meses de programado y realizado 
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[6].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(0, true);
                        mesesLista2.SetItemChecked(0, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[7].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(1, true);
                        mesesLista2.SetItemChecked(1, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[8].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(2, true);
                        mesesLista2.SetItemChecked(2, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[9].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(3, true);
                        mesesLista2.SetItemChecked(3, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[10].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(4, true);
                        mesesLista2.SetItemChecked(4, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[11].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(5, true);
                        mesesLista2.SetItemChecked(5, true);
                    }
                    //                              mostrar meses de solo realizado 
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[6].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(0, false);
                        mesesLista2.SetItemChecked(0, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[7].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(1, false);
                        mesesLista2.SetItemChecked(1, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[8].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(2, false);
                        mesesLista2.SetItemChecked(2, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[9].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(3, false);
                        mesesLista2.SetItemChecked(3, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[10].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(4, false);
                        mesesLista2.SetItemChecked(4, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[11].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(5, false);
                        mesesLista2.SetItemChecked(5, true);
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

                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[12].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(0, true);
                        mesesLista2.SetItemChecked(0, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[13].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(1, true);
                        mesesLista2.SetItemChecked(1, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[14].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(2, true);
                        mesesLista2.SetItemChecked(2, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[15].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(3, true);
                        mesesLista2.SetItemChecked(3, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[16].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(4, true);
                        mesesLista2.SetItemChecked(4, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[17].Value.ToString()) == 2)
                    {
                        mesesLista.SetItemChecked(5, true);
                        mesesLista2.SetItemChecked(5, true);
                    }

                    //                              mostrar meses de solo realizado 
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[12].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(0, false);
                        mesesLista2.SetItemChecked(0, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[13].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(1, false);
                        mesesLista2.SetItemChecked(1, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[14].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(2, false);
                        mesesLista2.SetItemChecked(2, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[15].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(3, false);
                        mesesLista2.SetItemChecked(3, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[16].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(4, false);
                        mesesLista2.SetItemChecked(4, true);
                    }
                    if (int.Parse(gridServicios.Rows[e.RowIndex].Cells[17].Value.ToString()) == 3)
                    {
                        mesesLista.SetItemChecked(5, false);
                        mesesLista2.SetItemChecked(5, true);
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
            for (int i = 0; i < mesesLista.Items.Count; i++)
            {
                mesesLista2.SetItemChecked(i, false);
            }
        }

        private void ocultarCeldas()  //Ocultar los campos no necesarios de mostrar
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
                    verChecks(s1);

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
                verChecks(s1);

                //guardar en BD 
                bool respuesta = ServicioLogica.Instancia.Editar(s1);
                if (respuesta)
                {
                    mostrarServicios();
                    limpiar();
                }

            }
        }

        //Revisar qe meses estan seleccionados 1, programado, 2 programado y realizado, 3 solo realizado
        private void verChecks(Servicio s1)
        {
            foreach (var item in mesesLista.CheckedItems)
            {
                //Revisar meses programados 
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

            //revisar meses realizados 
            foreach (var item in mesesLista2.CheckedItems)
            {
                //MessageBox.Show("Item: "+item.ToString());
                if (item.ToString() == "enero")
                { s1.enero = 2; }
                if (item.ToString() == "febrero")
                { s1.febrero = 2; }
                if (item.ToString() == "marzo")
                { s1.marzo = 2; }
                if (item.ToString() == "abril")
                { s1.abril = 2; }
                if (item.ToString() == "mayo")
                { s1.mayo = 2; }
                if (item.ToString() == "junio")
                { s1.junio = 2; }

                if (item.ToString() == "julio")
                { s1.julio = 2; }
                if (item.ToString() == "agosto")
                { s1.agosto = 2; }
                if (item.ToString() == "septiembre")
                { s1.septiembre = 2; }
                if (item.ToString() == "octubre")
                { s1.octubre = 2; }
                if (item.ToString() == "noviembre")
                { s1.noviembre = 2; }
                if (item.ToString() == "diciembre")
                { s1.diciembre = 2; }

            }

            //revisar meses realizados y no programados 
            if (textPeriodo.Text == "enero-junio")
            {
                if (mesesLista.GetItemChecked(0) == false && mesesLista2.GetItemChecked(0)) { s1.enero = 3; }
                if (mesesLista.GetItemChecked(1) == false && mesesLista2.GetItemChecked(1)) { s1.febrero = 3; }
                if (mesesLista.GetItemChecked(2) == false && mesesLista2.GetItemChecked(2)) { s1.abril = 3; }
                if (mesesLista.GetItemChecked(3) == false && mesesLista2.GetItemChecked(3)) { s1.abril = 3; }
                if (mesesLista.GetItemChecked(4) == false && mesesLista2.GetItemChecked(4)) { s1.mayo = 3; }
                if (mesesLista.GetItemChecked(5) == false && mesesLista2.GetItemChecked(5)) { s1.junio = 3; }
            }
            else
            {
                if (mesesLista.GetItemChecked(0) == false && mesesLista2.GetItemChecked(0)) { s1.julio = 3; }
                if (mesesLista.GetItemChecked(1) == false && mesesLista2.GetItemChecked(1)) { s1.agosto = 3; }
                if (mesesLista.GetItemChecked(2) == false && mesesLista2.GetItemChecked(2)) { s1.septiembre = 3; }
                if (mesesLista.GetItemChecked(3) == false && mesesLista2.GetItemChecked(3)) { s1.octubre = 3; }
                if (mesesLista.GetItemChecked(4) == false && mesesLista2.GetItemChecked(4)) { s1.noviembre = 3; }
                if (mesesLista.GetItemChecked(5) == false && mesesLista2.GetItemChecked(5)) { s1.diciembre = 3; }
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

        //Boton para marcar con X los meses de realizacion de servicio 
        private void btnRealizado_Click(object sender, EventArgs e)
        {
            if (mesesLista2.Visible) {mesesLista2.Visible = false;}
            else {mesesLista2.Visible = true;}   
        }
    }
}
