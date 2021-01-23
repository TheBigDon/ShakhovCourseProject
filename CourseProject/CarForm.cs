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
    public partial class CarForm : Form
    {
        public SqlConnection connection;
        public String cmdText;
        public String photoCar;

        public CarForm()
        {
            InitializeComponent();
        }
        private async void CarForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

            await connection.OpenAsync();
        }
        private void CarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void goMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(Form1.idRole);
            this.Hide();
            mainForm.Show();
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand select = new SqlCommand("SELECT * FROM Car", connection);

                DataSet dataSet = new DataSet("dataSet");
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select);

                sqlDataAdapter.Fill(dataSet, "Cars");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataSet.Tables["Cars"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"DELETE FROM Car WHERE id_car = {textBox1.Text}";
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
                    photoCar = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                cmdText = $"INSERT INTO Car (passport_of_the_vehicle, vin, id_model, year_of_production_of_the_car, photo_car, color, mileage, id_type_of_body, id_transmission_type, id_type_of_drive, engine, wheel, id_type_of_car, " +
                    $"engine_volume, engine_power, id_dealer, status_of_the_sale) VALUES('{ptsTextBox.Text}', '{vinTextBox.Text}', '{idModelTextBox.Text}', '{dateTimePicker1.Value.ToShortDateString()}', '{photoCar}', " +
                    $"'{colorTextBox.Text}', '{mileageTextBox.Text}', '{idTypeBodyTextBox.Text}', '{idTransmissionTextBox.Text}', '{idTypeDriveTextBox.Text}', '{engineTextBox.Text}', '{wheelTextBox.Text}', " +
                    $"'{idTypeCarTextBox.Text}', '{engineVolumeTextBox.Text}', '{enginePowerTextBox.Text}', '{idDealerTextBox.Text}', '{checkBox1.Checked}')";
                sqlOperation();

                MessageBox.Show("Данные успешно добавлены!", "Поздравлю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadXmlButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    DataSet dsXML = new DataSet();
                    dsXML.ReadXml(ofd.FileName);
                    dataGridView1.DataSource = dsXML.Tables[0];
                    string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17;
                    int row_count = dataGridView1.Rows.Count;
                    row_count = row_count - 1;
                    for (int i = 0; i < row_count; i++)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        a1 = row.Cells[0].Value.ToString(); //птс
                        a2 = row.Cells[1].Value.ToString(); //vin
                        a3 = row.Cells[2].Value.ToString(); //id модели
                        a4 = row.Cells[3].Value.ToString(); //год выпуска
                        a5 = row.Cells[4].Value.ToString(); //фото
                        a6 = row.Cells[5].Value.ToString(); //цвет
                        a7 = row.Cells[6].Value.ToString(); //пробег
                        a8 = row.Cells[7].Value.ToString(); //id типа кузова
                        a9 = row.Cells[8].Value.ToString(); // id коробки передач
                        a10 = row.Cells[9].Value.ToString(); // id типа привода
                        a11 = row.Cells[10].Value.ToString(); // двигатель 
                        a12 = row.Cells[11].Value.ToString(); // руль 
                        a13 = row.Cells[12].Value.ToString(); // id типа автомобиля
                        a14 = row.Cells[13].Value.ToString(); // объем двигателя
                        a15 = row.Cells[14].Value.ToString(); // мощность двигателя
                        a16 = row.Cells[15].Value.ToString(); // id дилера
                        a17 = row.Cells[16].Value.ToString(); // статус продажи
                        
                        cmdText = "INSERT INTO Car (passport_of_the_vehicle, vin, id_model, year_of_production_of_the_car, photo_car, color, mileage, id_type_of_body, id_transmission_type, " +
                            "id_type_of_drive, engine, wheel, id_type_of_car, engine_volume, engine_power, id_dealer, status_of_the_sale) " +
                            "VALUES ('" + a1 + "','" + a2 + "','" + a3 + "','" + a4 + "','" + a5 + "','" + a6 + "','" + a7 + "','" + a8 + "','" + a9 + "','" + a10 + "','" + a11 + "','" + a12 + "','" 
                            + a13 + "','" + a14 + "', '" + a15 + "', '" + a16 + "', '" + a17 + "');";
                        
                        SqlCommand cmd = new SqlCommand(cmdText, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void goToDefectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefectsForm defectsForm = new DefectsForm();
            this.Hide();
            defectsForm.Show();
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
                    photoCar = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateCarButton_Click(object sender, EventArgs e)
        {
            if (updateIdCarTextBox.Text != "")
            {
                try
                {
                    if (updatePtsTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET passport_of_the_vehicle = '" + updatePtsTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateVINTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET vin = '" + updateVINTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdModelTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET id_model = '" + updateIdModelTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (dateTimePicker2.Value.ToShortDateString() != DateTime.Today.ToString().Split(' ')[0]) 
                    {
                        cmdText = "UPDATE Car SET year_of_production_of_the_car = '" + dateTimePicker2.Value.ToShortDateString() + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateColorTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Car SET color = '" + updateColorTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateMileageTextBox.Text != "") 
                    {
                        cmdText = "UPDATE Car SET mileage = '" + updateMileageTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdTypeBodyTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET id_type_of_body = '" + updateIdTypeBodyTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdTransmissionTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET id_transmission_type = '" + updateIdTransmissionTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdDriveTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET id_type_of_drive = '" + updateIdDriveTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (pictureBox2.Image != null)
                    {
                        cmdText = "UPDATE Car SET photo_car = '" + photoCar + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateEngineTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET engine = '" + updateEngineTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateWheelTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET wheel = '" + updateWheelTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdTypeCarTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET id_type_of_car = '" + updateIdTypeCarTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateEngineVolumeTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET engine_volume = '" + updateEngineVolumeTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateEnginePowerTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET engine_power = '" + updateEnginePowerTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if (updateIdDealerTextBox.Text != "")
                    {
                        cmdText = "UPDATE Car SET id_dealer = '" + updateIdDealerTextBox.Text + "' where id_car = " + updateIdCarTextBox.Text + ";";
                        sqlOperation();
                    }
                    if(updateCheckBox.Checked)
                    {
                        cmdText = "UPDATE Car SET status_of_the_sale = '" + updateCheckBox.Checked + "' where id_car = " + updateIdCarTextBox.Text + ";";
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
                MessageBox.Show("Вы не написали ID Машины!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveXmlButton_Click(object sender, EventArgs e)
        {
            try
            {
                string select = "SELECT * FROM Car";
                SqlDataAdapter adapter = new SqlDataAdapter(select, connection);

                DataSet ds = new DataSet("Car");
                DataTable dt = new DataTable("Car");
                ds.Tables.Add(dt);
                adapter.Fill(ds.Tables["Car"]);

                ds.WriteXml("cars.xml");

                MessageBox.Show("Данные сохранены в файл", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Что-то пошло не по плану! Так, да тут у нас: {ex.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void helpCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarHelpForm carHelpForm = new CarHelpForm();
            this.Hide();
            carHelpForm.Show();
        }
    }
}