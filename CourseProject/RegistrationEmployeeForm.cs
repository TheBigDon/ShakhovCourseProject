using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CourseProject
{
    public partial class RegistrationEmployeeForm : Form
    {
        public String photoEmployee;
        public String fioEmployee;
        public char genderEmployee;
        public DateTime dateBirthEmployee;
        public String numberPassportEmployee;
        public String seriesPassportEmployee;
        public String phoneEmployee;
        public String emailEmployee;
        public String addressEmployee;
        public int roleEmployee;
        public String loginEmployee;
        public String passwordEmployee;
        public String md5Password;
        public SqlConnection connection;

        public RegistrationEmployeeForm()
        {
            InitializeComponent();
        }

        ///////////////////Forms
        private void RegistrationEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void RegistrationEmployeeForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

            await connection.OpenAsync();
        }

        ///////////////////ToolStripMenuItem
        private void backMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(Form1.idRole);
            this.Hide();
            mf.Show();
        }

        ///////////////////Buttons
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            //ofd.FileName - путь к файлу
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All file (*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    photoEmployee = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            //Employee`s name
            fioEmployee = checkTextBox(fioTextBox);

            //Employee`s gender
            if(maleRadioButton.Checked)
            {
                genderEmployee = 'М';
            }
            else
            {
                genderEmployee = 'Ж';
            }

            //Employee`s date of birth
            dateBirthEmployee = dateTimePicker1.Value.Date;

            //Employee`s number passport
            numberPassportEmployee = checkTextBox(numberPassportTextBox);

            //Employee`s series passport
            seriesPassportEmployee = checkTextBox(seriesPassportTextBox);

            //Employee`s phone
            phoneEmployee = checkTextBox(phoneTextBox);

            //Employee`s email
            emailEmployee = checkEmail(emailTextBox);

            //Employee`s address
            addressEmployee = checkTextBox(addressTextBox);

            //Employee`s role
            roleEmployee = selectRole(roleComboBox);

            //Employee`s login
            loginEmployee = createLogin();

            //Employee`s password
            passwordEmployee = createPassword();

            //Send email
            sendMail(loginEmployee, passwordEmployee);

            //Генерация хэшированного пароля
            md5Password = getHash(passwordEmployee);

            //Insert into DB
            insertIntoDB(loginEmployee, md5Password, fioEmployee, dateBirthEmployee, genderEmployee, numberPassportEmployee, seriesPassportEmployee, phoneEmployee, emailEmployee, addressEmployee, photoEmployee, roleEmployee); 
        }

        /// <summary>
        /// Check Text Box
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        private string checkTextBox(TextBox tb)
        {
            String line = "";
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                MessageBox.Show($"Ошибка ввода данных! Поле: {tb.AccessibleDescription}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.BackColor = Color.White;
            }
            else
            {
                line = tb.Text;
            }
            return line;
        }

        /// <summary>
        /// Check employee`s email
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="line"></param>
        private string checkEmail(TextBox tb)
        {
            String pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            String line = "";

            if(Regex.IsMatch(tb.Text, pattern, RegexOptions.IgnoreCase))
            {
                line = tb.Text;
            }
            else
            {
                tb.BackColor = Color.Red;
                MessageBox.Show($"Ошибка ввода данных! Поле: {tb.AccessibleDescription}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb.BackColor = Color.White;
            }
            return line;
        }

        private int selectRole(ComboBox cb)
        {
            int numberRole;
            numberRole = cb.SelectedIndex + 1;
            return numberRole;
        }

        /// <summary>
        /// Send message to email
        /// </summary>
        private void sendMail(String login, String password)
        {
            MailAddress From = new MailAddress("takistepan@gmail.com", "Твой босс");
            MailAddress To = new MailAddress("takistepan@gmail.com");
            MailMessage msg = new MailMessage(From, To);

            msg.Subject = "Оповещение о создании аккаунта";
            msg.Body = $"<h4>Поздравляем!</h4><h4>Вы приняты в нашу семью!</h4><p>Данные вашего аккаунта: логин - {login}, пароль - {password}</p><h4>С любовью, твой начальник!</h4>";
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(From.Address, "");
            smtp.Send(msg);
        }

        /// <summary>
        /// Create employee`s login
        /// </summary>
        /// <returns></returns>
        private string createLogin()
        {
            String login = "Employee";
            Random random = new Random();
            int number = random.Next(1, 20);
            login += number;
            return login;
        }

        /// <summary>
        /// Create employee`s password
        /// </summary>
        /// <returns></returns>
        private string createPassword()
        {
            String password = "Qwerty";
            Random random = new Random();
            int number = random.Next(1, 20);
            password += number;
            return password;
        }

        private string getHash(String password)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Insert into DataBase
        /// </summary>
        /// <param name="photo"></param>
        /// <param name="fio"></param>
        /// <param name="gender"></param>
        /// <param name="date"></param>
        /// <param name="numberPassport"></param>
        /// <param name="seriesPassport"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="role"></param>
        private async void insertIntoDB(String login, String password, String fio, DateTime date, char gender,String numberPassport, String seriesPassport, String phone, String email, String address, String photo, int idRole)
        {
            const string NotifyEmployeeError = "Notify Employee";
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Employee " +
                    $"(login, password, fio_employee, date_of_birth_employee, gender, passport_number_employee, passport_series_employee, phone_number_employee, email_employee, address_employee, photo_employee, id_role) " +
                    $"VALUES('{login}', '{password}', '{fio}', '{date}', '{gender}', '{numberPassport}', '{seriesPassport}', '{phone}', '{email}', '{address}', '{photo}', '{idRole}')", connection);

                await command.ExecuteNonQueryAsync();

                MessageBox.Show("Сотрудник добавлен!", "Мои поздравления!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Delete error 50000 :)
            catch (Exception e)
            {
                if(e.Message != NotifyEmployeeError)
                {
                    MessageBox.Show($"Ошибка записи данных! Ошибка: {e.Message}", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}