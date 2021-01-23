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
    public partial class DefectsForm : Form
    {
        public SqlConnection connection;
        public String cmdText;
        public String photoDefect;

        public DefectsForm()
        {
            InitializeComponent();
        }
        private async void DefectsForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

            await connection.OpenAsync();
        }
        private void showDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Defects", connection);

                DataSet dataSet = new DataSet("dataSet");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select);

                sqlDataAdapter.Fill(dataSet, "Defects");

                dataGridView1.DataSource = dataSet.Tables["Defects"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DefectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void goCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm();
            this.Hide();
            carForm.Show();
        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"DELETE FROM Defects WHERE id_defect = {deleteCartextBox.Text}";
                sqlOperation();
                MessageBox.Show("Данные успешно удалены!", "Поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All file (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    photoDefect = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateDefectButton_Click(object sender, EventArgs e)
        {
            if (updateIdDefectTextBox.Text != "")
            {
                try
                {
                    if (updateIdTypeDefectTextBox.Text != "")
                    {
                        cmdText = "UPDATE Defects SET id_type_defect = '" + updateIdTypeDefectTextBox.Text + "' where id_defect = " + updateIdDefectTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateNameDefectTextBox.Text != "")
                    {
                        cmdText = "UPDATE Defects SET name_defect = '" + updateNameDefectTextBox.Text + "' where id_defect = " + updateIdDefectTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateRichTextBox.Text != "")
                    {
                        cmdText = "UPDATE Defects SET description_defect = '" + updateRichTextBox.Text + "' where id_defect = " + updateIdDefectTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (pictureBox2.Image != null) 
                    {
                        cmdText = "UPDATE Defects SET photo_defect = '" + photoDefect + "' where id_defect = " + updateIdDefectTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdCarTextBox.Text != "")
                    {
                        cmdText = "UPDATE Defects SET id_car = '" + updateIdCarTextBox.Text + "' where id_defect = " + updateIdDefectTextBox.Text + ";";
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
                MessageBox.Show("Вы не написали ID Дефекта!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadUpdateImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All file (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = new Bitmap(ofd.FileName);
                    photoDefect = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addDefectButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"INSERT INTO Defects (id_type_defect, name_defect, description_defect, photo_defect, id_car) VALUES('{idTypeDefectTextBox.Text}', '{nameDefectTextBox.Text}', '{richTextBox1.Text}', '{photoDefect}', '{idCarTextBox.Text}')";
                sqlOperation();

                MessageBox.Show("Данные успешно добавлены!", "Поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefectsHelpForm defectsHelpForm = new DefectsHelpForm();
            this.Hide();
            defectsHelpForm.Show();
        }
    }
}