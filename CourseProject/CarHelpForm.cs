using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class CarHelpForm : Form
    {
        public CarHelpForm()
        {
            InitializeComponent();
        }

        private void goToCarFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm carForm = new CarForm();
            this.Hide();
            carForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/takistepan");
        }
    }
}
