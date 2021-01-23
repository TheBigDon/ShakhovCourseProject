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
    public partial class ContractHelpForm : Form
    {
        public ContractHelpForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/takistepan");
        }

        private void goContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContractForm contractForm = new ContractForm();
            this.Hide();
            contractForm.Show();
        }
    }
}
