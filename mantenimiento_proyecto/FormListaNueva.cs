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
using iTextSharp.tool.xml.html.head;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace mantenimiento_proyecto
{
    public partial class FormListaNueva : Form
    {
        public static int idAreaSeleccionada = 0;
        public static string nombreAreaSeleccionada = "";

        public static string nombreEspacioSeleccionado = "";
        public static int idEspacioSeleccionado = 0;

        public static int anio;
        public static string periodo;

        public FormListaNueva()
        {
            InitializeComponent();
            nombreAreaSeleccionada = comboAreas.Text;
            idAreaSeleccionada = AreaLogica.Instancia.buscarArea(nombreAreaSeleccionada);

            comboAreas.DataSource = AreaLogica.Instancia.Listar();
            comboAreas.DisplayMember = "nombre";

            anio = int.Parse(numericAnio.Value.ToString());
            periodo = comboPeriodo.Text;

            // MessageBox.Show(anio.ToString()+" y "+periodo);
        }


        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FormPrincipal();
            formulario.Show();
            this.Hide();
        }

        private void listaDeVerificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormListaNueva();
            formulario.Show();
            this.Hide();
        }

        private void planAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormProgramaAnual();
            formulario.Show();
            this.Hide();
        }

        private void btnHallazgos_Click(object sender, EventArgs e)
        {
            anio = int.Parse(numericAnio.Value.ToString());
            periodo = comboPeriodo.Text;
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
            //nombreAreaSeleccionada = "AG";
            //idAreaSeleccionada = AreaLogica.Instancia.buscarArea(nombreAreaSeleccionada);
            //MessageBox.Show(idAreaSeleccionada.ToString());
            comboAreas.DataSource = AreaLogica.Instancia.Listar();
            comboAreas.DisplayMember = "nombre";
            revisarEspacios();
            comboJefeArea.DataSource = PersonaLogica.Instancia.listarPorArea(nombreAreaSeleccionada);
            comboJefeArea.DisplayMember = "nombre";
            comboPeriodo.Text = "enero-junio";

        }

        //Cargar espacios desde la base de datos 
        private void revisarEspacios()
        {
            List<Espacio> espacios = new List<Espacio>();
            espacios = EspacioLogica.Instancia.Listar(idAreaSeleccionada);
            if (espacios.Count == 0)
            {
                MessageBox.Show("No existen espacios registrados en esta área, favor de registrar en el botón \"Ver espacios \" ");
                comboEspacios.Text = string.Empty;
                comboEspacios.DataSource = null;
                comboEspacios.Enabled = false;
            }
            else
            {
                comboEspacios.DataSource = espacios;
                comboEspacios.DisplayMember = "nombre";
                comboEspacios.Enabled = true;
            }
        }

        private void comboAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboAreas.Text);
            nombreAreaSeleccionada = comboAreas.Text;
            idAreaSeleccionada = AreaLogica.Instancia.buscarArea(nombreAreaSeleccionada);
            revisarEspacios();
            comboJefeArea.DataSource = PersonaLogica.Instancia.listarPorArea(nombreAreaSeleccionada);
            comboJefeArea.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreEspacioSeleccionado = comboEspacios.Text;
            idEspacioSeleccionado = EspacioLogica.Instancia.buscarEspacio(nombreEspacioSeleccionado);
            anio = int.Parse(numericAnio.Value.ToString());
            periodo = comboPeriodo.Text;
            //MessageBox.Show(idEspacioSeleccionado.ToString());
            Form formulario = new FormHallazgos();
            formulario.Show();
        }

        //Generar y guardar doumento pdf 
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            idEspacioSeleccionado = EspacioLogica.Instancia.buscarEspacio(nombreEspacioSeleccionado);
            anio = int.Parse(numericAnio.Value.ToString());
            periodo = comboPeriodo.Text;
            guardar.FileName = "listaVerificación_" + comboAreas.Text + "_" + periodo + "_" + anio + ".pdf";
            //guardar.ShowDialog();

            //generar html
            string paginahtmlTexto = Properties.Resources.listaV1.ToString();
            string pieHtml = Properties.Resources.pieLista.ToString();

            //Escribir información capturada en formulario en la tabla de html 
            paginahtmlTexto = paginahtmlTexto.Replace("@jefeElabora", nombreJefe.Text);      //pasar datos a la primera tabla 
            paginahtmlTexto = paginahtmlTexto.Replace("@jefeArea", comboJefeArea.Text);
            var fecha1 = textFecha.Value.ToString("dd/MM/yyyy");   //establecer formato ara fecha seleccionada 
            paginahtmlTexto = paginahtmlTexto.Replace("@fecha", fecha1);     //agregar la fecha 
            pieHtml = pieHtml.Replace("@jefeElabora", nombreJefe.Text);
            pieHtml = pieHtml.Replace("@jefeArea", comboJefeArea.Text);      //pasar datos a la ultima tabla 

            string filas = string.Empty;
            List<Hallazgo> collection = new List<Hallazgo>();
            try      //obtener una lista de objetos consultados de la tabla hallazgos 
            {
                //pasar idespacio e idarea
                anio = int.Parse(numericAnio.Value.ToString());
                periodo = comboPeriodo.Text;
                collection = HallazgoLogica.Instancia.ListarEspacio(idEspacioSeleccionado, idAreaSeleccionada, anio, periodo);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al consultar de la base de datos");
            }

            //esta solo se uso para comprobar que se devolvía desde la Base de datos
            /*foreach (var aver in collection)
            {
                MessageBox.Show(aver.ToString());
            }*/
            /*if (collection == null)
            {
                MessageBox.Show("Parece que no hay hallazgos");
            }
            else
            {
                MessageBox.Show("Todo bien...");
                foreach (var aver in collection)
                {
                    MessageBox.Show(aver.ToString());
                }
            }*/


            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        //crear, abrir y preparar documento 
                        Document listaPdf = new Document(PageSize.LETTER);
                        PdfWriter writer = PdfWriter.GetInstance(listaPdf, stream);
                        PageEventHelper2 pageEventHelper = new PageEventHelper2();
                        writer.PageEvent = pageEventHelper;
                        listaPdf.Open();

                        //Crear un estilo de letra en negritas 
                        //var boldFont = new iTextSharp.text.Font(Font.FontFamily, 12, Font.BOLD);

                        //Crear tabla con ayuda de itextSharp 
                        PdfPTableHeader header = new PdfPTableHeader();
                        PdfPTable table = new PdfPTable(4);
                        table.WidthPercentage = 95;
                        table.SetWidths(new float[] { 40, 50, 10, 10 }); // Establecer el ancho relativo de cada columna

                        // Agregar encabezado de tabla, columnas de encabezado
                        var font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                        table.HeaderRows = 2;
                        PdfPCell celda = new PdfPCell(new Paragraph("Espacio Revisado"));
                        celda.Phrase = new Phrase("Espacio Revisado", font);
                        celda.Rowspan = 2;
                        table.AddCell(celda);
                        PdfPCell celda2 = new PdfPCell(new Paragraph("Hallazgo"));
                        celda2.Phrase = new Phrase("Hallazgo", font);
                        celda2.Rowspan = 2;
                        table.AddCell(celda2);
                        PdfPCell celda3 = new PdfPCell(new Paragraph("Atendido"));
                        celda3.Phrase = new Phrase("Atendido", font);
                        celda3.Colspan = 2;
                        table.AddCell(celda3);
                        table.AddCell("Si");
                        table.AddCell("No");

                        // Agregar filas a la tabla
                        foreach (var cosas in collection)
                        {
                            table.AddCell(cosas.nombreEspacio);
                            table.AddCell(cosas.descripcion);
                            if (cosas.atendido == "Si")
                            {
                                table.AddCell(" X ");
                                table.AddCell("");
                            }
                            else
                            {
                                table.AddCell("");
                                table.AddCell(" X ");
                            }

                        }


                        //Convertir el html generado a un archivo PDF  
                        try
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, listaPdf, new StringReader(paginahtmlTexto));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al convertir html en pdf \n\n\n");
                            Console.WriteLine(ex);
                        }

                        //añadir tabla dinamica creada con la librería ItextSharp
                        listaPdf.Add(table);

                        //Añadir un salto entre tabla de hallazgos y espacio de firmas 
                        Paragraph salto = new Paragraph();
                        salto.Add(new Chunk("\n")); // Agregar un salto de línea
                        listaPdf.Add(salto);
                        //ultima tabla de nombres (firmas) con html 
                        try
                        {
                            //Convertir tabla html y agregar al documento 
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, listaPdf, new StringReader(pieHtml));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al convertir html en pdf ");
                            Console.WriteLine(ex);
                        }

                        //          Probar varias paginas 
                        /*
                        listaPdf.NewPage();//page break OR New Page
                        listaPdf.Add(new Paragraph("This is a second page."));
                        */

                        //Cerrar el documento generado y guardado 
                        listaPdf.Close();
                        stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar formato, Intente cerrar el archivo si está en uso");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Si existe personal registrado en un area, motrar nombre completo 
        private void comboJefeArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreAreaSeleccionada = comboAreas.Text;
            comboJefeArea.DataSource = PersonaLogica.Instancia.listarPorArea(nombreAreaSeleccionada);
            comboJefeArea.DisplayMember = "nombres";
        }

        private void comboJefeElabora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //ir a registrar personal
        private void registrarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormPersonal();
            formulario.Show();
            this.Hide();
        }

        private void registrarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAreas();
            formulario.Show();
        }

        //Cerrar programa al cerrar esta ventana 
        private void FormListaNueva_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

//Clase utilizada para controlar el comportamiento del documento en cada página 
public class PageEventHelper2 : PdfPageEventHelper
{
    PdfContentByte cb;
    PdfTemplate template;  //plantilla de pdf 
    BaseFont bf = null;
    int totalPages = 0;     //Contador de paginas 
    string textPag;

    //Abrir documento para crear 
    public override void OnOpenDocument(PdfWriter myPDFWriter, Document document)
    {
        cb = myPDFWriter.DirectContent;
        template = cb.CreateTemplate(580, 700);
        bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
    }


    //Crear encabezado 
    public override void OnStartPage(PdfWriter writer, Document listaPdf)
    {
        base.OnStartPage(writer, listaPdf);

        //colocar no. de pagina 
        int pageN = writer.PageNumber;
        iTextSharp.text.Rectangle pageSize = listaPdf.PageSize;
        textPag = "Página " + pageN.ToString() + " de";
        cb.BeginText();
        cb.SetFontAndSize(bf, 9);
        //cb.SetRGBColorFill(50, 50, 200);
        //cb.SetTextMatrix(listaPdf.RightMargin + 450, pageSize.GetTop(120));
        cb.SetTextMatrix(listaPdf.RightMargin + 450, listaPdf.Top - 70); ;
        cb.ShowText(textPag);
        cb.EndText();

        cb.AddTemplate(template, listaPdf.LeftMargin, pageSize.GetBottom(listaPdf.BottomMargin));

        //html
        string encabezado = mantenimiento_proyecto.Properties.Resources.EncabezadoLista.ToString();
        using (StringReader sr = new StringReader(encabezado))
        {
            //insertar logo1
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoTecNM, System.Drawing.Imaging.ImageFormat.Png);
            img.ScaleToFit(100, 80);
            img.Alignment = iTextSharp.text.Image.UNDERLYING;
            img.SetAbsolutePosition(listaPdf.LeftMargin, listaPdf.Top - 60);
            listaPdf.Add(img);
            //insertar logo2
            iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoITM, System.Drawing.Imaging.ImageFormat.Png);
            img2.ScaleToFit(50, 50);
            img2.Alignment = iTextSharp.text.Image.UNDERLYING;
            img2.SetAbsolutePosition(listaPdf.RightMargin + 450, listaPdf.Top - 60);
            listaPdf.Add(img2);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, listaPdf, sr);
        }

        //     Realizar un salto de linea para espaciar el encabezado y contenido posterior a este 
        Paragraph salto = new Paragraph();
        salto.Add(new Chunk("\n")); // Agregar un salto de línea
        listaPdf.Add(salto);
    }


    //Crear pie de pagina 
    public override void OnEndPage(PdfWriter myPDFWriter, Document listaPdf)
    {
        base.OnEndPage(myPDFWriter, listaPdf);

        string text = "ITMORELIA-IT-AD-002-01";
        cb.BeginText();
        cb.SetFontAndSize(bf, 11);
        //cb.SetRGBColorFill(50, 50, 200);
        cb.SetTextMatrix(listaPdf.RightMargin + 1, 30);
        cb.ShowText(text);
        cb.EndText();

        string text2 = "Rev. 1";
        cb.BeginText();
        cb.SetFontAndSize(bf, 11);
        cb.SetTextMatrix(listaPdf.RightMargin + 450, 30);
        cb.ShowText(text2);
        cb.EndText();

        totalPages++;   //contar páginas totales de documento 
    }

    //Cerrar documento para imprimir, colocar páginas totales 
    public override void OnCloseDocument(PdfWriter writer, Document document)
    {
        base.OnCloseDocument(writer, document);
        iTextSharp.text.Rectangle pageSize = document.PageSize;
        template.BeginText();
        template.SetFontAndSize(bf, 9);
        template.SetTextMatrix(document.RightMargin + 465, document.Top - 106);
        template.ShowText(" " + (writer.PageNumber));
        template.EndText();
    }
}
