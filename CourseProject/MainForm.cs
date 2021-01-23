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
    public partial class MainForm : Form
    {
        public MainForm(int idRole)
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        ///////////////////PictureBox
        private void carPictureBox_Click(object sender, EventArgs e)
        {
            showCarForm();
        }

        private void contractPictureBox_Click(object sender, EventArgs e)
        {
            showContractForm();
        }

        private void clientsPictureBox_Click(object sender, EventArgs e)
        {
            showClientForm();
        }

        private void dealersPictureBox_Click(object sender, EventArgs e)
        {
            showDealerForm();
        }

        ///////////////////ToolStripMenuItem
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileUser pu = new ProfileUser();
            this.Hide();
            pu.Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCarForm();
        }
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showClientForm();
        }
        private void dealersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showDealerForm();
        }
        private void contractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showContractForm();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHelpForm();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        ///////////////////Method Show
        private void showCarForm()
        {
            CarForm cf = new CarForm();
            this.Hide();
            cf.Show();
        }

        private void showContractForm()
        {
            ContractForm cf = new ContractForm();
            this.Hide();
            cf.Show();
        }

        private void showClientForm()
        {
            ClientsForm cf = new ClientsForm();
            this.Hide();
            cf.Show();
        }

        private void showDealerForm()
        {
            DealersForm df = new DealersForm();
            this.Hide();
            df.Show();
        }

        private void showHelpForm()
        {
            HelpForm hf = new HelpForm();
            this.Hide();
            hf.Show();
        }

        ///////////////////Mouse Enter
        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void contractPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
