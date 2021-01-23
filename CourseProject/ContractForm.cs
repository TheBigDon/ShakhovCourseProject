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
    public partial class ContractForm : Form
    {
        public SqlConnection connection;
        public String cmdText;

        public ContractForm()
        {
            InitializeComponent();
        }

        private async void ContractForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

            await connection.OpenAsync();
        }

        private void goMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(Form1.idRole);
            this.Hide();
            mainForm.Show();
        }

        private void ContractForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
            Application.Exit();
        }

        private void showContractButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Contract_for_sale", connection);

                DataSet dataSet = new DataSet("dataSet");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select);

                sqlDataAdapter.Fill(dataSet, "Contract");

                dataGridView1.DataSource = dataSet.Tables["Contract"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"DELETE FROM Contract_for_sale WHERE id_contract = {deleteIdTextBox.Text}";
                sqlOperation();
                MessageBox.Show("Контракт успешно удален из базы данных!", "Поздравляю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addContractButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"INSERT INTO Contract_for_sale (date_of_contract_conclusion, car_cost, id_client, id_employee, id_car, id_type_of_car_purchase) VALUES('{dateTimePicker1.Value.ToShortDateString()}', " +
                    $"'{carCostTextBox.Text}', '{idClientTextBox.Text}', '{idEmployeeTextBox.Text}', '{idCarTextBox.Text}', '{idPurchasetextBox.Text}')";
                sqlOperation();
                MessageBox.Show("Контракт успешно добавлен в базу данных!", "Поздравляю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updateIdContractTextBox.Text != "")
            {
                try
                {
                    if (dateTimePicker2.Value.ToShortDateString() != DateTime.Today.ToString().Split(' ')[0])
                    {
                        cmdText = "UPDATE Contract_for_sale SET date_of_сontract_conclusion = '" + dateTimePicker2.Value.ToShortDateString() + "' where id_contract = " + updateIdContractTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateCarCostTextBox.Text != "")
                    {
                        cmdText = "UPDATE Contract_for_sale SET car_cost = '" + updateCarCostTextBox.Text + "' where id_contract = " + updateIdContractTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdClientTextBox.Text != "")
                    {
                        cmdText = "UPDATE Contract_for_sale SET id_client = '" + updateIdClientTextBox.Text + "' where id_contract = " + updateIdContractTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdEmployeeTextBox.Text != "")
                    {
                        cmdText = "UPDATE Contract_for_sale SET id_employee = '" + updateIdEmployeeTextBox.Text + "' where id_contract = " + updateIdContractTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdCarTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Contract_for_sale SET id_car = '" + updateIdCarTextBox + "' where id_contract = " + updateIdContractTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdPurchaseTextBox.Text != "")
                    {
                        cmdText = "UPDATE Contract_for_sale SET id_type_of_car_purchase = '" + updateIdPurchaseTextBox.Text + "' where id_contract = " + updateIdContractTextBox.Text + ";";
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
                MessageBox.Show("Вы не написали ID Контракта!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractHelpForm contractHelpForm = new ContractHelpForm();
            this.Hide();
            contractHelpForm.Show();
        }
    }
}