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

namespace mantenimiento_proyecto
{
    public partial class FormProgramaAnual : Form
    {
        public static string anioPlan,periodoPlan,nombreAreaElegida; 
       
        public FormProgramaAnual()
        {
            InitializeComponent();
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
            comboAprobo.DataSource = PersonaLogica.Instancia.Listar();
            comboAprobo.ValueMember = "nombres";
            comboAreas.DataSource = AreaLogica.Instancia.Listar();
            comboAreas.ValueMember = "nombre";
            nombreAreaElegida = comboAreas.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            anioPlan = numericAnio.ToString();
            periodoPlan = comboPeriodos.Text;
        }

        private void comboAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreAreaElegida = comboAreas.Text;
        }


        private void btnCargarServicio_Click(object sender, EventArgs e)
        {
            if (periodoPlan != "") 
            {
                periodoPlan= comboPeriodos.Text;
                anioPlan= numericAnio.Value.ToString();
                FormServicios formService = new FormServicios();
                formService.Show();
            }
        }

        private void comboAprobo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName =  "programaAnualMantenimiento.pdf";
            guardar.ShowDialog();

            //generar html
            string paginahtmlTexto = Properties.Resources.programaV1.ToString();

            paginahtmlTexto = paginahtmlTexto.Replace("@periodo", comboPeriodos.Text);
            paginahtmlTexto = paginahtmlTexto.Replace("@elaboro", comboElaboro.Text);
            paginahtmlTexto = paginahtmlTexto.Replace("@anio",numericAnio.Value.ToString());
            paginahtmlTexto = paginahtmlTexto.Replace("@aprobo", comboAprobo.Text);
            paginahtmlTexto = paginahtmlTexto.Replace("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document programaAnual = new Document(PageSize.LETTER.Rotate());

                    PdfWriter writer = PdfWriter.GetInstance(programaAnual, stream);

                    PageEventHelper pageEventHelper = new PageEventHelper();
                    writer.PageEvent = pageEventHelper;

                    programaAnual.Open();

                    //html 
                    using (StringReader sr = new StringReader(paginahtmlTexto))
                    {
                        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, programaAnual, sr);
                    }

                    programaAnual.NewPage();//page break OR New Page

                    programaAnual.Add(new Paragraph("This is a second page."));

                    programaAnual.Close();
                    stream.Close();

                }



            }

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
        template2 = cb2.CreateTemplate(document.RightMargin +700, document.PageSize.Top);
        bf2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
    }


    //Crear encabezado 
    public override void OnStartPage(PdfWriter writer, Document listaPdf)
    {
        base.OnStartPage(writer, listaPdf);

        //no. de pagina 
        int pageN = writer.PageNumber;
        iTextSharp.text.Rectangle pageSize = listaPdf.PageSize;
        String text = "Página " + pageN.ToString() + " de";
        cb2.BeginText();
        cb2.SetFontAndSize(bf2, 11);
        //cb2.SetRGBColorFill(50, 50, 200);
        cb2.SetTextMatrix(listaPdf.RightMargin + 600, 35);
        cb2.ShowText(text);
        cb2.EndText();

        cb2.AddTemplate(template2, listaPdf.LeftMargin, pageSize.GetBottom(listaPdf.BottomMargin));

        //html
        string encabezado = mantenimiento_proyecto.Properties.Resources.encabezadoPrograma.ToString();
        using (StringReader sr = new StringReader(encabezado))
        {
            //logo1
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoTecNM, System.Drawing.Imaging.ImageFormat.Png);
            img.ScaleToFit(135, 110);
            img.Alignment = iTextSharp.text.Image.UNDERLYING;
            img.SetAbsolutePosition(listaPdf.LeftMargin, listaPdf.Top - 80);
            listaPdf.Add(img);
            //logo2
            iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(mantenimiento_proyecto.Properties.Resources.logoITM, System.Drawing.Imaging.ImageFormat.Png);
            img2.ScaleToFit(60, 60);
            img2.Alignment = iTextSharp.text.Image.UNDERLYING;
            img2.SetAbsolutePosition(listaPdf.RightMargin + 600, listaPdf.Top - 62);
            listaPdf.Add(img2);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, listaPdf, sr);
        }

        Paragraph saltoDeLinea1 = new Paragraph("                                                                                                                                                                                                                                                                                                                                                                                   ");
        listaPdf.Add(saltoDeLinea1);
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




        /*PdfPTable pie = new PdfPTable(1);
        pie.TotalWidth = 95f;
        PdfPCell celda1 = new PdfPCell();
        celda1.Border = 3;
        celda1.BorderColorBottom = BaseColor.DARK_GRAY;
        pie.AddCell(celda1);
        //pie.WriteSelectedRows(0, 50, listaPdf.Left + 30, listaPdf.Top - 310, myPDFWriter.DirectContent);
        listaPdf.Add(pie);*/


    }

    public override void OnCloseDocument(PdfWriter writer, Document document)
    {
        base.OnCloseDocument(writer, document);
        iTextSharp.text.Rectangle pageSize = document.PageSize;
        template2.BeginText();
        template2.SetFontAndSize(bf2, 11);
        template2.SetTextMatrix(document.RightMargin + 630, 0);
        template2.ShowText(""+(writer.PageNumber));
        template2.EndText();

        
    }

}
