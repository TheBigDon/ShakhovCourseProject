using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class ProfileUser : Form
    {
        int idRole = Form1.idRole;
        public ProfileUser()
        {
            InitializeComponent();
            photoPictureBox.Load(Form1.photoEmployee);
            fioLabel.Text = Form1.fioEmployee;
            genderLabel.Text = Form1.genderEmployee;
            dateLabel.Text = Form1.dateOfBirthEmployee.ToShortDateString();
            phoneLabel.Text = Form1.phoneEmployee;
            emailLabel.Text = Form1.emailEmployee;
            addressLabel.Text = Form1.addressEmployee;

            if (idRole == 3)
            {
                addButton.Visible = true;
            }
            else if (idRole == 2) 
            {
                addButton.Text = "Сформировать отчет";
            }
            else
            {
                addButton.Visible = false;
                this.Height = 360;
            }
        }

        ///////////////////ToolStripMenuItem
        private void backMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(idRole);
            this.Hide();
            mf.Show();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            this.Hide();
            hf.Show();
        }

        ///////////////////Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (idRole == 3)
            {
                goAddEmployee();
            }
            else
            {
                goCreateReport();
            }
        }

        ///////////////////Form
        private void ProfileUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void goAddEmployee()
        {
            RegistrationEmployeeForm registration = new RegistrationEmployeeForm();
            this.Hide();
            registration.Show();
        }

        public void goCreateReport()
        {
            RaportForm rf = new RaportForm();
            this.Hide();
            rf.Show();
        }
    }
}
