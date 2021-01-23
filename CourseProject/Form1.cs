using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Security.Cryptography;

namespace CourseProject
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-IORD2AUP\\MSSQLSERVER01;Initial Catalog=cars_sale;Integrated Security=True");

        public static int idRole;
        public static String photoEmployee;
        public static String fioEmployee;
        public static String genderEmployee;
        public static DateTime dateOfBirthEmployee;
        public static String phoneEmployee;
        public static String emailEmployee;
        public static String addressEmployee;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            passwordField.PasswordChar = '*';
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            bool sucsessLog = false;
            string userLogin = loginField.Text;
            string userPass = passwordField.Text;
            //string hashPass;
            //hashPass = getHash(userPass);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (userLogin == reader.GetString(1) && userPass == reader.GetString(2))
                        {
                            sucsessLog = true;
                            fioEmployee = reader.GetString(3);
                            dateOfBirthEmployee = reader.GetDateTime(4);
                            genderEmployee = reader.GetString(5);
                            phoneEmployee = reader.GetString(8);
                            emailEmployee = reader.GetString(9);
                            addressEmployee = reader.GetString(10);
                            photoEmployee = reader.GetString(11);
                            idRole = reader.GetInt32(12);
                        }

                    }
                    if (sucsessLog)
                    {
                        reader.Close();
                        if (idRole == 1)//User
                        {
                            MainForm main = new MainForm(1);
                            main.Show();
                            this.Hide();
                        }
                        else if(idRole == 2)//Chief
                        {
                            MainForm main = new MainForm(2);
                            main.Show();
                            this.Hide();
                        }
                        else//Admin
                        {
                            MainForm main = new MainForm(3);
                            main.Show();
                            this.Hide();
                        }
                        sucsessLog = false;
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, введите логин и пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reader.Close();
                    }
                }
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void bLogin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private string getHash(String password)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            return Convert.ToBase64String(hash);
        }
    }
}
