using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using mantenimiento_proyecto.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using iTextSharp.tool.xml.html.table;
using mantenimiento_proyecto.Models;
using mantenimiento_proyecto;
using iTextSharp.text.html.simpleparser;
using iTextSharp.tool.xml.html;
using iTextSharp.tool.xml.pipeline.html;

namespace mantenimiento_proyecto
{

    public partial class FormProgramaAnual : Form
    {
        public static string anioPlan, periodoPlan, nombreAreaElegida, elaboro, aprobo, fecha1, fecha2;

        public FormProgramaAnual()
        {
            InitializeComponent();
            comboPeriodos.ValueMember = "enero-junio";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Form3_Load(object sender, EventArgs e)
        {
            comboPeriodos.Text = "enero-junio";
            comboAreas.DataSource = AreaLogica.Instancia.Listar();
            comboAreas.ValueMember = "nombre";
            if (comboAreas.DataSource == null)
            {
                MessageBox.Show("No existen áreas registradas, por favor registre en la cción áreas");
            }
            else
            {
                nombreAreaElegida = comboAreas.Text;
            }
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FormPrincipal();
            formulario.Show();
            this.Close();

        }


        private void btnG2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                periodoPlan = comboPeriodos.Text;
                anioPlan = numericAnio.Value.ToString();
                guardar.FileName = "prueba.pdf";
                elaboro = textElaboro.Text;
                aprobo = textAprobo.Text;

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document programaAnual = new Document(PageSize.LETTER.Rotate());

                        PdfWriter writer = PdfWriter.GetInstance(programaAnual, new FileStream("output.pdf", FileMode.Create));
                        programaAnual.Open();

                        // Create a new table
                        PdfPTable table = new PdfPTable(3);
                        table.WidthPercentage = 100;
                        table.SplitLate = true;

                        // Parse the HTML and add the contents to the table
                        string html = "<table><tr><td>Cell 1</td><td>Cell 2</td><td>Cell 3</td></tr><tr><td>Cell 4</td><td>Cell 5</td><td>Cell 6</td></tr><tr><td>Cell 7</td><td>Cell 8</td><td>Cell 9</td></tr><tr><td>Cell 10</td><td>Cell 11</td><td>Cell 12</td></tr><tr><td>Cell 13</td><td>Cell 14</td><td>Cell 15</td></tr><tr><td>Cell 16</td><td>Cell 17</td><td>Cell 18</td></tr><tr><td>Cell 19</td><td>Cell 20</td><td>Cell 21</td></tr><tr><td>Cell 22</td><td>Cell 23</td><td>Cell 24</td></tr><tr><td>Cell 25</td><td>Cell 26</td><td>Cell 27</td></tr><tr><td>Cell 28</td><td>Cell 29</td><td>Cell 30</td></tr></table>";
                        HtmlPipelineContext htmlContext = new HtmlPipelineContext(null);
                        htmlContext.SetTagFactory(Tags.GetHtmlTagProcessorFactory());
                        StringReader s1 = new StringReader(html);
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, programaAnual, s1);



                        // Add the table to the document
                        programaAnual.Add(table);

                        // Close the document
                        programaAnual.Close();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al crear formato");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al generar documento");
            }

        }

        //Seleccionar año y periodo 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            anioPlan = numericAnio.ToString();
            periodoPlan = comboPeriodos.Text;
        }

        private void comboAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreAreaElegida = comboAreas.Text;
        }

        //Boton para cargar servicio filtrando periodos y años
        private void btnCargarServicio_Click(object sender, EventArgs e)
        {
            if (periodoPlan != "")
            {
                periodoPlan = comboPeriodos.Text;
                anioPlan = numericAnio.Value.ToString();
                FormServicios formService = new FormServicios();
                formService.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un periodo");
            }
        }


        //                                                         Generar formato PDF 
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                //nombre de archivo para guardar 
                SaveFileDialog guardar = new SaveFileDialog();
                periodoPlan = comboPeriodos.Text;
                anioPlan = numericAnio.Value.ToString();
                guardar.FileName = "programaAnualMantenimiento_" + periodoPlan + "_" + anioPlan + ".pdf";

                elaboro = textElaboro.Text;
                aprobo = textAprobo.Text;

                anioPlan = numericAnio.Value.ToString();
                periodoPlan = comboPeriodos.Text;
                fecha1 = fechaElaboracion.Value.ToString("dd/MM/yyyy");
                fecha2 = fechaAprobacion.Value.ToString("dd/MM/yyyy");

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            //Crear, abrir y preparar documento 
                            Document programaAnual = new Document(PageSize.LETTER.Rotate());
                            PdfWriter writer = PdfWriter.GetInstance(programaAnual, stream);
                            PageEventHelper pageEventHelper = new PageEventHelper();
                            writer.PageEvent = pageEventHelper;
                            programaAnual.Open();
                            //cuerpo de la tabla 
                            var anioPlan = FormProgramaAnual.anioPlan;
                            var periodoPlan = FormProgramaAnual.periodoPlan;
                            var anioBuscar = int.Parse(anioPlan);

                            //consultar datos guardados 
                            string filas = string.Empty;
                            List<Servicio> collection = new List<Servicio>();
                            if (periodoPlan == "enero-junio")
                            {
                                collection = ServicioLogica.Instancia.ListarTodos1(anioBuscar);
                            }
                            else
                            {
                                collection = ServicioLogica.Instancia.ListarTodos2(anioBuscar);
                            }

                            //llenar tabla 
                            //Crear tabla con ayuda de itextSharp 
                            PdfPTableHeader header = new PdfPTableHeader();
                            PdfPTable table = new PdfPTable(16);
                            table.WidthPercentage = 95;
                            table.SetWidths(new float[] { 5, 30, 8, 5, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 }); // Establecer el ancho relativo de cada columna

                            // Agregar encabezado de tabla
                            table.HeaderRows = 1;
                            table.AddCell("No.");
                            table.AddCell("Servicio");
                            table.AddCell("Tipo");
                            table.AddCell("E");
                            table.AddCell("ENE");
                            table.AddCell("FEB");
                            table.AddCell("MAR");
                            table.AddCell("ABR");
                            table.AddCell("MAY");
                            table.AddCell("JUN");
                            table.AddCell("JUL");
                            table.AddCell("AGO");
                            table.AddCell("SEP");
                            table.AddCell("OCT");
                            table.AddCell("NOV");
                            table.AddCell("DIC");


                            // Agregar filas a la tabla
                            for (var i = 0; i < collection.Count; i++)
                            {
                                PdfPCell celdaNo = new PdfPCell(new Paragraph((i + 1).ToString()));
                                celdaNo.Rowspan = 2;
                                table.AddCell(celdaNo);
                                PdfPCell celdaDescripcion = new PdfPCell(new Paragraph(collection[i].descripcion));
                                celdaDescripcion.Rowspan = 2;
                                table.AddCell(celdaDescripcion);
                                PdfPCell celdaTipo = new PdfPCell(new Paragraph(collection[i].tipoServicio));
                                celdaTipo.Rowspan = 2;
                                table.AddCell(celdaTipo);
                                table.AddCell("P");
                                if (collection[i].enero == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].febrero == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].marzo == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].abril == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].mayo == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].junio == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].julio == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].agosto == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].septiembre == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].octubre == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].noviembre == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }
                                if (collection[i].diciembre == 1)
                                {
                                    table.AddCell("X");
                                }
                                else
                                {
                                    table.AddCell("");
                                }

                                //segunda fila
                                table.AddCell("R");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");

                                //tercera fila 
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("O");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                                table.AddCell("");
                            }
                            //Agregar tabla llenada 
                            programaAnual.Add(table);

                            //AgreDatos para firmas 
                            //agregar html para pie 
                            string piehtmlTexto = Properties.Resources.piePrograma.ToString();
                            piehtmlTexto = piehtmlTexto.Replace("@periodo", periodoPlan);  //reemplazar datos en el html 
                            piehtmlTexto = piehtmlTexto.Replace("@elaboro", elaboro);
                            piehtmlTexto = piehtmlTexto.Replace("@anio", anioPlan);
                            piehtmlTexto = piehtmlTexto.Replace("@aprobo", aprobo);
                            piehtmlTexto = piehtmlTexto.Replace("@fecha", fecha1);
                            piehtmlTexto = piehtmlTexto.Replace("@feche", fecha2);

                            //agregar html al pdf 
                            using (StringReader sr3 = new StringReader(piehtmlTexto))
                            {
                                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, programaAnual, sr3);
                            }

                            //pruebas de más páginas 
                            //programaAnual.NewPage();//page break OR New Page
                            //programaAnual.Add(new Paragraph("This is a second page."));

                            //Cerrar documento 
                            programaAnual.Close();
                            stream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar formato \n\n\n" + "Intente cerrar el archivo si está en uso");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el documento \n\n\n");
                Console.WriteLine(ex.Message);
            }
        }

        private void listaDeVerificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormListaNueva();
            formulario.Show();
            this.Hide();
        }

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
    }
}


public class PageEventHelper : PdfPageEventHelper
{
    PdfContentByte cb2;
    PdfTemplate template2;
    BaseFont bf2 = null;
    public override void OnOpenDocument(PdfWriter myPDFWriter, Document document)
    {
        cb2 = myPDFWriter.DirectContent;
        template2 = cb2.CreateTemplate(document.RightMargin + 700, document.PageSize.Top);
        bf2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
    }


    //Crear encabezado 
    public override void OnStartPage(PdfWriter writer, Document planPdf)
    {
        base.OnStartPage(writer, planPdf);

        //no. de pagina 
        int pageN = writer.PageNumber;
        iTextSharp.text.Rectangle pageSize = planPdf.PageSize;
        String text = "Página " + pageN.ToString() + " de";
        cb2.BeginText();
        cb2.SetFontAndSize(bf2, 11);
        //cb2.SetRGBColorFill(50, 50, 200);
        cb2.SetTextMatrix(planPdf.RightMargin + 600, 35);
        cb2.ShowText(text);
        cb2.EndText();
        cb2.AddTemplate(template2, planPdf.LeftMargin, pageSize.GetBottom(planPdf.BottomMargin));

        //html, cargar archivo pdf para encabezado 
        string encabezado = mantenimiento_proyecto.Properties.Resources.encabezadoPrograma.ToString();
        encabezado = encabezado.Replace("@periodo", FormProgramaAnual.periodoPlan);
        encabezado = encabezado.Replace("@anio", FormProgramaAnual.anioPlan);

        //Colocar imagenes de logos y html de encabezado en el pdf 
        using (StringReader sr = new StringReader(encabezado))
        {
            //logo1
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoTecNM, System.Drawing.Imaging.ImageFormat.Png);
            img.ScaleToFit(135, 110);
            img.Alignment = iTextSharp.text.Image.UNDERLYING;
            img.SetAbsolutePosition(planPdf.LeftMargin, planPdf.Top - 80);
            planPdf.Add(img);
            //logo2
            iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoITM, System.Drawing.Imaging.ImageFormat.Png);
            img2.ScaleToFit(60, 60);
            img2.Alignment = iTextSharp.text.Image.UNDERLYING;
            img2.SetAbsolutePosition(planPdf.RightMargin + 600, planPdf.Top - 62);
            planPdf.Add(img2);
            //html a pdf 
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, planPdf, sr);
        }

        //     Realizar un salto de linea para espaciar el encabezado y contenido posterior a este 
        Paragraph salto = new Paragraph();
        salto.Add(new Chunk("\n\n")); // Agregar un salto de línea
        planPdf.Add(salto);

    }


    //Crear pie de pagina 
    public override void OnEndPage(PdfWriter myPDFWriter, Document listaPdf)
    {
        base.OnEndPage(myPDFWriter, listaPdf);



        string text = "ITMORELIA-IT-AD-002-02";
        cb2.BeginText();
        cb2.SetFontAndSize(bf2, 11);
        //cb.SetRGBColorFill(50, 50, 200);
        cb2.SetTextMatrix(listaPdf.RightMargin + 1, 33);
        cb2.ShowText(text);
        cb2.EndText();

        string text2 = "Rev. 1";
        cb2.BeginText();
        cb2.SetFontAndSize(bf2, 11);
        cb2.SetTextMatrix(listaPdf.RightMargin + 380, 33);
        cb2.ShowText(text2);
        cb2.EndText();

        //Linea 
        PdfContentByte l = myPDFWriter.DirectContent;
        l.SetColorStroke(BaseColor.RED.Darker().Darker());
        l.MoveTo(listaPdf.RightMargin + 1, 25);
        l.LineTo(listaPdf.RightMargin + 690, 25);
        l.ClosePathStroke();

        /*Chunk linea = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.5f, 97f, BaseColor.RED.Darker(), Element.ALIGN_CENTER, 10f));
        listaPdf.Add(linea);*/
    }

    public override void OnCloseDocument(PdfWriter writer, Document document)
    {
        base.OnCloseDocument(writer, document);
        iTextSharp.text.Rectangle pageSize = document.PageSize;
        template2.BeginText();
        template2.SetFontAndSize(bf2, 11);
        template2.SetTextMatrix(document.RightMargin + 630, 0);
        template2.ShowText("" + (writer.PageNumber));
        template2.EndText();
    }

}
