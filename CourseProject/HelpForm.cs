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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void goMainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(Form1.idRole);
            this.Hide();
            mainForm.Show();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проект выполнил студент группы ЭИС-35\nШахов Степан Максимович", "Разработчик", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
