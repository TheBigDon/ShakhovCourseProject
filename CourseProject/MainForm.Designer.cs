namespace CourseProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.dealersPictureBox = new System.Windows.Forms.PictureBox();
            this.clientsPictureBox = new System.Windows.Forms.PictureBox();
            this.contractPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.carToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.dealersToolStripMenuItem,
            this.contractsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.profileToolStripMenuItem.Text = "Профиль";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            this.profileToolStripMenuItem.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.carToolStripMenuItem.Text = "Машины";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            this.carToolStripMenuItem.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            this.clientsToolStripMenuItem.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            // 
            // dealersToolStripMenuItem
            // 
            this.dealersToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dealersToolStripMenuItem.Name = "dealersToolStripMenuItem";
            this.dealersToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.dealersToolStripMenuItem.Text = "Дилеры";
            this.dealersToolStripMenuItem.Click += new System.EventHandler(this.dealersToolStripMenuItem_Click);
            this.dealersToolStripMenuItem.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            // 
            // contractsToolStripMenuItem
            // 
            this.contractsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
            this.contractsToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.contractsToolStripMenuItem.Text = "Контракты";
            this.contractsToolStripMenuItem.Click += new System.EventHandler(this.contractsToolStripMenuItem_Click);
            this.contractsToolStripMenuItem.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            this.helpToolStripMenuItem.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            // 
            // carPictureBox
            // 
            this.carPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("carPictureBox.Image")));
            this.carPictureBox.Location = new System.Drawing.Point(99, 49);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(271, 241);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 1;
            this.carPictureBox.TabStop = false;
            this.carPictureBox.Click += new System.EventHandler(this.carPictureBox_Click);
            this.carPictureBox.MouseEnter += new System.EventHandler(this.contractPictureBox_MouseEnter);
            // 
            // dealersPictureBox
            // 
            this.dealersPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dealersPictureBox.Image")));
            this.dealersPictureBox.Location = new System.Drawing.Point(513, 49);
            this.dealersPictureBox.Name = "dealersPictureBox";
            this.dealersPictureBox.Size = new System.Drawing.Size(271, 241);
            this.dealersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dealersPictureBox.TabIndex = 2;
            this.dealersPictureBox.TabStop = false;
            this.dealersPictureBox.Click += new System.EventHandler(this.dealersPictureBox_Click);
            this.dealersPictureBox.MouseEnter += new System.EventHandler(this.contractPictureBox_MouseEnter);
            // 
            // clientsPictureBox
            // 
            this.clientsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clientsPictureBox.Image")));
            this.clientsPictureBox.Location = new System.Drawing.Point(99, 387);
            this.clientsPictureBox.Name = "clientsPictureBox";
            this.clientsPictureBox.Size = new System.Drawing.Size(271, 241);
            this.clientsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clientsPictureBox.TabIndex = 3;
            this.clientsPictureBox.TabStop = false;
            this.clientsPictureBox.Click += new System.EventHandler(this.clientsPictureBox_Click);
            this.clientsPictureBox.MouseEnter += new System.EventHandler(this.contractPictureBox_MouseEnter);
            // 
            // contractPictureBox
            // 
            this.contractPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("contractPictureBox.Image")));
            this.contractPictureBox.Location = new System.Drawing.Point(513, 387);
            this.contractPictureBox.Name = "contractPictureBox";
            this.contractPictureBox.Size = new System.Drawing.Size(271, 241);
            this.contractPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contractPictureBox.TabIndex = 4;
            this.contractPictureBox.TabStop = false;
            this.contractPictureBox.Click += new System.EventHandler(this.contractPictureBox_Click);
            this.contractPictureBox.MouseEnter += new System.EventHandler(this.contractPictureBox_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(189, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(606, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дилеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(189, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Клиенты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(606, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Контракты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(860, 702);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contractPictureBox);
            this.Controls.Add(this.clientsPictureBox);
            this.Controls.Add(this.dealersPictureBox);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseEnter += new System.EventHandler(this.contractPictureBox_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.PictureBox dealersPictureBox;
        private System.Windows.Forms.PictureBox clientsPictureBox;
        private System.Windows.Forms.PictureBox contractPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}