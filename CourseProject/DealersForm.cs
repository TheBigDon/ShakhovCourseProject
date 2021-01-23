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
    public partial class DealersForm : Form
    {
        public SqlConnection connection;
        public String photoDealer;
        public String cmdText;
        public DealersForm()
        {
            InitializeComponent();
        }
        private async void DealersForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

            await connection.OpenAsync();
        }
        private void DealersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            Application.Exit();
        }

        private void goMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(Form1.idRole);
            this.Hide();
            mainForm.Show();
        }

        private void showDealersButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Dealer", connection);

                DataSet dataSet = new DataSet("dataSet");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select);

                sqlDataAdapter.Fill(dataSet, "Dealer");

                dataGridView1.DataSource = dataSet.Tables["Dealer"];
            }
            catch (Exception ex)
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
                    photoDealer = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void sqlOperation()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addDealerButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"INSERT INTO Dealer (name, contact_person, phone_number_dealer, email_dealer, photo_dealer, address_dealer, id_type_dealer) VALUES('{nameTextBox.Text}', '{contactPersonTextBox.Text}', " +
                    $"'{phoneTextBox.Text}', '{emailTextBox.Text}', '{photoDealer}', '{addressTextBox.Text}', '{idTypeDealerTextBox.Text}')";
                sqlOperation();
                MessageBox.Show("Данные успешно добавлены!", "Поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateDealerButton_Click(object sender, EventArgs e)
        {
            if (idUpdateDealerTextBox.Text != "")
            {
                try
                {
                    if (updateNameTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Dealer SET name = '" + updateNameTextBox.Text + "' where id_dealer = " + idUpdateDealerTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateContactfaceTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Dealer SET contact_person = '" + updateContactfaceTextBox.Text + "' where id_dealer = " + idUpdateDealerTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updatePhoneTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Dealer SET phone_number_dealer = '" + updatePhoneTextBox.Text + "' where id_dealer = " + idUpdateDealerTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateEmailTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Dealer SET email_dealer = '" + updateEmailTextBox.Text + "' where id_dealer = " + idUpdateDealerTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (pictureBox2.Image != null) 
                    {
                        cmdText = "UPDATE Dealer SET photo_dealer = '" + photoDealer + "' where id_dealer = " + idUpdateDealerTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateAddressTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Dealer SET address_dealer = '" + updateAddressTextBox.Text + "' where id_dealer = " + idUpdateDealerTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdTypeDealerTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Dealer SET id_type_dealer = '" + updateIdTypeDealerTextBox.Text + "' where id_dealer = " + idUpdateDealerTextBox.Text + ";";
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
                MessageBox.Show("Вы не написали ID Дилера!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteDealerButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"DELETE FROM Dealer WHERE id_dealer = {textBox1.Text}";
                sqlOperation();
                MessageBox.Show("Данные успешно удалены!", "Поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealersHelpForm dealersHelpForm = new DealersHelpForm();
            this.Hide();
            dealersHelpForm.Show();
        }
    }
}