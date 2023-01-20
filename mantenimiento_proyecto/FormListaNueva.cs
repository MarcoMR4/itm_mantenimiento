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
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using mantenimiento_proyecto.Properties;

namespace mantenimiento_proyecto
{
    public partial class FormListaNueva : Form
    {
        public static int idAreaSeleccionada = 0;
        public static string nombreAreaSeleccionada = "";

        public static string nombreEspacioSeleccionado = "";
        public static int idEspacioSeleccionado = 0;

        public FormListaNueva()
        {
            InitializeComponent();
            nombreAreaSeleccionada = comboAreas.Text;
            idAreaSeleccionada = AreaLogica.Instancia.buscarArea(nombreAreaSeleccionada);

            comboAreas.DataSource = AreaLogica.Instancia.Listar();
            comboAreas.DisplayMember = "nombre";
           
        }


        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FormPrincipal();
            formulario.Show();
            this.Close();
        }

        private void listaDeVerificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnHallazgos_Click(object sender, EventArgs e)
        {
            Form formulario = new FormHallazgos();
            formulario.Show();
        }


        private void btnCargarEspacio_Click(object sender, EventArgs e)
        {
            string nombreBuscar = comboAreas.Text;
            //MessageBox.Show(nombreBuscar);
            idAreaSeleccionada = AreaLogica.Instancia.buscarArea(nombreBuscar);
            //MessageBox.Show("El id es: " + idAreaSeleccionada);
            nombreAreaSeleccionada = nombreBuscar;
            Form formulario = new FormEspacios();
            formulario.Show();
        }

        private void FormListaNueva_Load(object sender, EventArgs e)
        {
            nombreAreaSeleccionada = "AG";
            idAreaSeleccionada = AreaLogica.Instancia.buscarArea(nombreAreaSeleccionada);
            //MessageBox.Show(idAreaSeleccionada.ToString());
            comboEspacios.DataSource = EspacioLogica.Instancia.Listar(idAreaSeleccionada);
            comboEspacios.DisplayMember = "nombre";
            comboJefeArea.DataSource = PersonaLogica.Instancia.listarPorArea(nombreAreaSeleccionada);
            comboJefeArea.DisplayMember = "nombres";
        }

        private void comboAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboAreas.Text);
            nombreAreaSeleccionada = comboAreas.Text;
            idAreaSeleccionada = AreaLogica.Instancia.buscarArea(nombreAreaSeleccionada);

            comboEspacios.DataSource = EspacioLogica.Instancia.Listar(idAreaSeleccionada);
            comboEspacios.ValueMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreEspacioSeleccionado = comboEspacios.Text;
            idEspacioSeleccionado = EspacioLogica.Instancia.buscarEspacio(nombreEspacioSeleccionado);
            //MessageBox.Show(idEspacioSeleccionado.ToString());
            Form formulario = new FormHallazgos();
            formulario.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          
            
            SaveFileDialog guardar = new SaveFileDialog();  
            guardar.FileName = comboAreas.Text+".pdf";
            guardar.ShowDialog();

            //generar html
            string paginahtmlTexto = Properties.Resources.listaV1.ToString();

            paginahtmlTexto = paginahtmlTexto.Replace("@jefeElabora", comboJefeElabora.Text);
            paginahtmlTexto = paginahtmlTexto.Replace("@jefeArea", comboJefeArea.Text);
            paginahtmlTexto = paginahtmlTexto.Replace("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;

            List<Hallazgo> collection = new List<Hallazgo>();
                                               //pasar idespacio e idarea 
            collection = HallazgoLogica.Instancia.ListarEspacio(idEspacioSeleccionado,idAreaSeleccionada);

            //agregar filas a la tabla 
            foreach (var fila in collection)
            {
                //MessageBox.Show(fila.descripcion);
                filas += "<tr>";
                filas += "<td class=\"celda1\">" + fila.nombreEspacio+"</td>";
                filas += "<td class=\"celda1\">" + fila.descripcion+"</td>";
                if (fila.atendido == "No")
                {
                    filas += "<td align=\"center\" class=\"celda1\"></td>";
                    filas += "<td align=\"center\" class=\"celda1\">X</td>";
                }
                else
                {
                    filas += "<td align=\"center\" class=\"celda1\">X</td>";
                    filas += "<td align=\"center\" class=\"celda1\"></td>";
                }
                filas += "</tr>";
            }

            paginahtmlTexto = paginahtmlTexto.Replace("@filas", filas);

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create)) 
                {
                    Document listaPdf = new Document(PageSize.LETTER);

                    PdfWriter writer = PdfWriter.GetInstance(listaPdf, stream);

                    listaPdf.Open();
                    listaPdf.Add(new Phrase(""));

                    //logo1
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logoTecNM, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(listaPdf.LeftMargin, listaPdf.Top -60);
                    listaPdf.Add(img);
                    //logo2
                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Properties.Resources.logoITM, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(10, 10);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(80, listaPdf.Top - 60);
                    //listaPdf.Add(img2);

                    //html 
                    using (StringReader sr = new StringReader(paginahtmlTexto))
                    {
                        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, listaPdf, sr);
                    }

                    listaPdf.Close();
                    stream.Close();

                }



            }
        }

        private void comboJefeArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreAreaSeleccionada = comboAreas.Text;
   
            comboJefeArea.DataSource = PersonaLogica.Instancia.listarPorArea(nombreAreaSeleccionada);
            comboJefeArea.DisplayMember = "nombres";
        }
    }
}
