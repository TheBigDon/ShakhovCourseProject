using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class ClientsForm : Form
    {
        public SqlConnection connection;
        public String fioClient;
        public DateTime dateBirthClietn;
        public String passportNumberClient;
        public String passportSeriesClient;
        public String phoneClient;
        public String emailClient;
        public String photoClient;
        public String addressClient;
        public String invoice;

        string cmdText;
        public ClientsForm()
        {
            InitializeComponent();
        }

        private async void ClientsForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

            await connection.OpenAsync();
        }

        private void ClientsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            Application.Exit();
        }

        private void showClientsButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Clients", connection);

                DataSet dataSet = new DataSet("dataSet");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select);

                sqlDataAdapter.Fill(dataSet, "Clients");

                dataGridView1.DataSource = dataSet.Tables["Clients"];
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void goMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(Form1.idRole);
            this.Hide();
            mainForm.Show();
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"DELETE FROM Clients WHERE id_client = {textBox1.Text}";
                sqlOperation();
                MessageBox.Show("Данные успешно удалены!", "Поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void sqlOperation()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All file (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    photoClient = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"INSERT INTO Clients (fio_client, date_of_birth_client, passport_number_client, passport_series_client, phone_number_client, email_client, photo_client, address_client, ivoice_for_payment)" +
                    $" VALUES('{fioClientTextBox.Text}', '{dateTimePicker1.Value.ToShortDateString()}', '{numberPassportTextBox.Text}', '{seriesPassportTextBox.Text}', '{phoneTextBox.Text}', '{emailTextBox.Text}', " +
                    $"'{photoClient}', '{addressTextBox.Text}', '{invoiceTextBox.Text}')";
                sqlOperation();
                MessageBox.Show("Данные успешно добавлены!", "Поздравляю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeClientButton_Click(object sender, EventArgs e)
        {
            if(idUpClientTextBox.Text != "")
            {
                try
                {
                    if (fioUpClientTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Clients SET fio_client = '" + fioUpClientTextBox.Text + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (dateTimePicker2.Value.ToShortDateString() != DateTime.Today.ToString().Split(' ')[0])
                    {
                        cmdText = "UPDATE Clients SET date_of_birth_client = '" + dateTimePicker2.Value.ToShortDateString() + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (numberPassUpTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Clients SET passport_number_client = '" + numberPassUpTextBox.Text + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (seriesPassUpTextBox.Text != "")
                    {
                        cmdText = "UPDATE Clients SET passport_series_client = '" + seriesPassUpTextBox.Text + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (phoneUpTextBox.Text != "")
                    {
                        cmdText = "UPDATE Clients SET phone_number_client = '" + phoneUpTextBox.Text + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (pictureBox2.Image != null)
                    {
                        cmdText = "UPDATE Clients SET photo_client = '" + photoClient + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (emailUpTextBox.Text != "")
                    {
                        cmdText = "UPDATE Clients SET email_client = '" + emailUpTextBox.Text + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (addressUpTextBox.Text != "")
                    {
                        cmdText = "UPDATE Clients SET address_client = '" + addressUpTextBox.Text + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (invoiceUpTextBox.Text != "")
                    {
                        cmdText = "UPDATE Clients SET ivoice_for_payment = '" + invoiceUpTextBox.Text + "' where id_client = " + idUpClientTextBox.Text + ";";
                        sqlOperation();
                    }

                    MessageBox.Show("Данные успешно обновлены!", "Поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            else
            {
                MessageBox.Show("Вы не написали ID Клиента!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadUpImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All file (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = new Bitmap(ofd.FileName);
                    photoClient = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void goHelpFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientHelpForm clientHelpForm = new ClientHelpForm();
            this.Hide();
            clientHelpForm.Show();
        }
    }
}