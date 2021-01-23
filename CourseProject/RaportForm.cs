using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class RaportForm : Form
    {
        public SqlConnection connection;

        public RaportForm()
        {
            InitializeComponent();
        }

        private async void RaportForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

            await connection.OpenAsync();
        }

        private void goMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(Form1.idRole);
            this.Hide();
            mf.Show();
        }

        private void RaportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            Application.Exit();
        }

        private void saveReportbutton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                        string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF");
                        BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL);
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                table.AddCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), fontParagraph));
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(table);
                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand select = new SqlCommand("SELECT cfs.id_contract, cfs.date_of_contract_conclusion," +
                    "cfs.car_cost, c.fio_client, c.date_of_birth_client," +
                    "c.passport_number_client, c.passport_series_client," +
                    "c.address_client, c.phone_number_client, c.email_client," +
                    "c.ivoice_for_payment, e.fio_employee, Car.id_car," +
                    "cp.name_type_of_car_purchase " +
                    "FROM Contract_for_sale cfs" +
                    " INNER JOIN Clients c on cfs.id_client = c.id_client" +
                    " INNER JOIN Employee e on cfs.id_employee = e.id_employee" +
                    " INNER JOIN Car on cfs.id_car = Car.id_car" +
                    " INNER JOIN Car_purchase cp on cfs.id_type_of_car_purchase = cp.id_type_of_car_purchase", connection);

                DataSet dataSet = new DataSet("dataSet");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select);

                sqlDataAdapter.Fill(dataSet, "Report");

                dataGridView1.DataSource = dataSet.Tables["Report"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
