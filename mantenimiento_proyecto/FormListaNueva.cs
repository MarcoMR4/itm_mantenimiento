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
            comboJefeArea.DisplayMember = "apellidoPaterno";
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

                    PageEventHelper2 pageEventHelper = new PageEventHelper2();
                    writer.PageEvent = pageEventHelper;

                    listaPdf.Open();

                    //html 
                    using (StringReader sr = new StringReader(paginahtmlTexto))
                    {
                        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, listaPdf, sr);
                    }

                    //listaPdf.Add(clienttable);
                    listaPdf.NewPage();//page break OR New Page

                    listaPdf.Add(new Paragraph("This is a second page."));

                    listaPdf.NewPage();//page break OR New Page

                    listaPdf.Add(new Paragraph("This is a third page."));


                    //encabezado 
                    /*
                    //logo1
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logoTecNM, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(90, 70);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(listaPdf.LeftMargin, listaPdf.Top -60);
                    listaPdf.Add(img);
                    //logo2
                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(Properties.Resources.logoITM, System.Drawing.Imaging.ImageFormat.Png);
                    img2.ScaleToFit(50,50);
                    img2.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img2.SetAbsolutePosition(listaPdf.RightMargin +420, listaPdf.Top -60);
                    listaPdf.Add(img2);
                    */


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

public class PageEventHelper2 : PdfPageEventHelper
{
    PdfContentByte cb;
    PdfTemplate template;
    BaseFont bf = null;
    int totalPages = 0;
    string textPag;
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

        //no. de pagina 
        int pageN = writer.PageNumber;
        iTextSharp.text.Rectangle pageSize = listaPdf.PageSize;
        textPag = "Página " + pageN.ToString()+ " de";
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
            //logo1
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoTecNM, System.Drawing.Imaging.ImageFormat.Png);
            img.ScaleToFit(100, 80);
            img.Alignment = iTextSharp.text.Image.UNDERLYING;
            img.SetAbsolutePosition(listaPdf.LeftMargin, listaPdf.Top - 60);
            listaPdf.Add(img);
            //logo2
            iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoITM, System.Drawing.Imaging.ImageFormat.Png);
            img2.ScaleToFit(50, 50);
            img2.Alignment = iTextSharp.text.Image.UNDERLYING;
            img2.SetAbsolutePosition(listaPdf.RightMargin + 450, listaPdf.Top - 60);
            listaPdf.Add(img2);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, listaPdf, sr);
        }

        

        /*
        //tabla 
        string titulo = "INSTITÚTO TECNOLÓGICO DE MORELIA";
        iTextSharp.text.Phrase titulo1 = new iTextSharp.text.Phrase();
        titulo1.Add(titulo);
        PdfPTable encabezado = new PdfPTable(3);
        PdfPCell celda1 = new PdfPCell(img);
        PdfPCell celda2 = new PdfPCell(titulo1);
        PdfPCell celda3 = new PdfPCell(img2);
        celda1.Border = 1;
        celda2.Border = 1;
        celda3.Border = 1;
        celda1.Width = 20;
        celda2.Width = 60;
        celda3.Width = 20;
        celda1.BorderWidthTop = 2;
        celda2.BorderWidthTop = 2;
        celda3.BorderWidthTop = 2;
        celda1.BorderWidthBottom = 2;
        celda2.BorderWidthBottom = 2;
        celda3.BorderWidthBottom = 2;
        celda3.BorderWidthTop = 2;
        celda1.BorderColorTop = BaseColor.RED.Darker();
        celda2.BorderColorTop = BaseColor.RED.Darker();
        celda3.BorderColorTop = BaseColor.RED.Darker();
        celda1.BorderColorBottom = BaseColor.RED.Darker();
        celda2.BorderColorBottom = BaseColor.RED.Darker();
        celda3.BorderColorBottom = BaseColor.RED.Darker();
        celda1.HorizontalAlignment = 2;
        celda1.VerticalAlignment = 1;

        encabezado.AddCell(celda1);
        encabezado.AddCell(celda2);
        encabezado.AddCell(celda3);

        listaPdf.Add(encabezado);
        */
       

        Paragraph saltoDeLinea1 = new Paragraph("                                                                                                                                                                                                                                                                                                                                                                                   ");
        listaPdf.Add(saltoDeLinea1);
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
        


        //html 
        /*string pie = mantenimiento_proyecto.Properties.Resources.Pielista.ToString();
        using (StringReader sr = new StringReader(pie))
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XMLWorkerHelper.GetInstance().ParseXHtml(myPDFWriter, listaPdf, sr);
        }*/

        totalPages++;
    }

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

    /* 
     public override void OnEndPage(PdfWriter myPDFWriter, Document document)
    {
        base.OnEndPage(myPDFWriter, document);

        int pageN = myPDFWriter.PageNumber;
        String text = "Page " + pageN.ToString();

        iTextSharp.text.Rectangle pageSize = document.PageSize;

        cb.SetRGBColorFill(100, 100, 100);

        cb.BeginText();
        cb.SetFontAndSize(this.RunDateFont.BaseFont, this.RunDateFont.Size);
        cb.SetTextMatrix(document.LeftMargin, pageSize.GetBottom(document.BottomMargin));
        cb.ShowText(text);

        cb.EndText();

        cb.AddTemplate(template, document.LeftMargin + len, pageSize.GetBottom(document.BottomMargin));
    }*/
}
