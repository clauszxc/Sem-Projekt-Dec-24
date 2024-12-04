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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;

namespace Sem_Projekt_Dec_24.Winforms
{
    public partial class CustomerConfirmationForm : Form
    {
        public CustomerConfirmationForm()
        {
            InitializeComponent();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm2 = new CustomerForm();
            customerForm2.StartPosition = FormStartPosition.CenterScreen;
            customerForm2.Show();
            this.Hide();
        }

        private void btnCustomerGoBack_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.StartPosition = FormStartPosition.CenterScreen;
            customerForm.Show();
            this.Hide();
        }


        public void CreateInvoicePdf()
        {
            
            string fileName = "Invoice.pdf";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document document = new Document(pdf);

                Paragraph header = new Paragraph("Invoice")
                    .SetFontSize(20)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontColor(ColorConstants.BLACK);
                document.Add(header);

                Paragraph date = new Paragraph($"Date: {DateTime.Now.ToString("dd-mm-yyyy")}")
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetMarginTop(20);
                document.Add(date);

                LineSeparator separator = new LineSeparator(new SolidLine(1));
                document.Add(separator);

                Paragraph content = new Paragraph("")
                    .SetFontSize(12)
                    .SetMarginTop(10);
                document.Add(content);


                Paragraph footer = new Paragraph("Thank you for shopping with us!")
                    .SetFontSize(14)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMarginTop(30);
                document.Add(footer);
            }

            MessageBox.Show($"PDF Invoice created at: {filePath}");
        }

        private void btnCreateOrderInvoice_Click(object sender, EventArgs e)
        {
            CreateInvoicePdf();
        }
    }
}
