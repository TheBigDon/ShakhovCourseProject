namespace CourseProject
{
    partial class DefectsForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showDataButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nameDefectTextBox = new System.Windows.Forms.TextBox();
            this.idCarTextBox = new System.Windows.Forms.TextBox();
            this.idTypeDefectTextBox = new System.Windows.Forms.TextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addDefectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateIdDefectTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.updateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.updateNameDefectTextBox = new System.Windows.Forms.TextBox();
            this.updateIdCarTextBox = new System.Windows.Forms.TextBox();
            this.updateIdTypeDefectTextBox = new System.Windows.Forms.TextBox();
            this.loadUpdateImageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateDefectButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.deleteCartextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goCarToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // goCarToolStripMenuItem
            // 
            this.goCarToolStripMenuItem.Name = "goCarToolStripMenuItem";
            this.goCarToolStripMenuItem.Size = new System.Drawing.Size(194, 29);
            this.goCarToolStripMenuItem.Text = "Перейти к машинам";
            this.goCarToolStripMenuItem.Click += new System.EventHandler(this.goCarToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(987, 268);
            this.dataGridView1.TabIndex = 1;
            // 
            // showDataButton
            // 
            this.showDataButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDataButton.Location = new System.Drawing.Point(13, 312);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(171, 82);
            this.showDataButton.TabIndex = 2;
            this.showDataButton.Text = "Отобразить данные";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 401);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 283);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.nameDefectTextBox);
            this.tabPage1.Controls.Add(this.idCarTextBox);
            this.tabPage1.Controls.Add(this.idTypeDefectTextBox);
            this.tabPage1.Controls.Add(this.loadImageButton);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.addDefectButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1129, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(351, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 202);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // nameDefectTextBox
            // 
            this.nameDefectTextBox.Location = new System.Drawing.Point(10, 162);
            this.nameDefectTextBox.Name = "nameDefectTextBox";
            this.nameDefectTextBox.Size = new System.Drawing.Size(335, 26);
            this.nameDefectTextBox.TabIndex = 10;
            // 
            // idCarTextBox
            // 
            this.idCarTextBox.Location = new System.Drawing.Point(200, 74);
            this.idCarTextBox.Name = "idCarTextBox";
            this.idCarTextBox.Size = new System.Drawing.Size(78, 26);
            this.idCarTextBox.TabIndex = 9;
            // 
            // idTypeDefectTextBox
            // 
            this.idTypeDefectTextBox.Location = new System.Drawing.Point(200, 17);
            this.idTypeDefectTextBox.Name = "idTypeDefectTextBox";
            this.idTypeDefectTextBox.Size = new System.Drawing.Size(78, 26);
            this.idTypeDefectTextBox.TabIndex = 8;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadImageButton.Location = new System.Drawing.Point(952, 6);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(171, 82);
            this.loadImageButton.TabIndex = 7;
            this.loadImageButton.Text = "Загрузить фото";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(751, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // addDefectButton
            // 
            this.addDefectButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDefectButton.Location = new System.Drawing.Point(952, 162);
            this.addDefectButton.Name = "addDefectButton";
            this.addDefectButton.Size = new System.Drawing.Size(171, 82);
            this.addDefectButton.TabIndex = 5;
            this.addDefectButton.Text = "Добавить дефект";
            this.addDefectButton.UseVisualStyleBackColor = true;
            this.addDefectButton.Click += new System.EventHandler(this.addDefectButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(683, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Фото:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID машины:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(347, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание дефекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название дефекта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID типа дефекта:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateIdDefectTextBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.updateRichTextBox);
            this.tabPage2.Controls.Add(this.updateNameDefectTextBox);
            this.tabPage2.Controls.Add(this.updateIdCarTextBox);
            this.tabPage2.Controls.Add(this.updateIdTypeDefectTextBox);
            this.tabPage2.Controls.Add(this.loadUpdateImageButton);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.updateDefectButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1129, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateIdDefectTextBox
            // 
            this.updateIdDefectTextBox.Location = new System.Drawing.Point(200, 17);
            this.updateIdDefectTextBox.Name = "updateIdDefectTextBox";
            this.updateIdDefectTextBox.Size = new System.Drawing.Size(78, 26);
            this.updateIdDefectTextBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID дефекта:";
            // 
            // updateRichTextBox
            // 
            this.updateRichTextBox.Location = new System.Drawing.Point(351, 42);
            this.updateRichTextBox.Name = "updateRichTextBox";
            this.updateRichTextBox.Size = new System.Drawing.Size(322, 202);
            this.updateRichTextBox.TabIndex = 23;
            this.updateRichTextBox.Text = "";
            // 
            // updateNameDefectTextBox
            // 
            this.updateNameDefectTextBox.Location = new System.Drawing.Point(3, 191);
            this.updateNameDefectTextBox.Name = "updateNameDefectTextBox";
            this.updateNameDefectTextBox.Size = new System.Drawing.Size(335, 26);
            this.updateNameDefectTextBox.TabIndex = 22;
            // 
            // updateIdCarTextBox
            // 
            this.updateIdCarTextBox.Location = new System.Drawing.Point(200, 114);
            this.updateIdCarTextBox.Name = "updateIdCarTextBox";
            this.updateIdCarTextBox.Size = new System.Drawing.Size(78, 26);
            this.updateIdCarTextBox.TabIndex = 21;
            // 
            // updateIdTypeDefectTextBox
            // 
            this.updateIdTypeDefectTextBox.Location = new System.Drawing.Point(200, 62);
            this.updateIdTypeDefectTextBox.Name = "updateIdTypeDefectTextBox";
            this.updateIdTypeDefectTextBox.Size = new System.Drawing.Size(78, 26);
            this.updateIdTypeDefectTextBox.TabIndex = 20;
            // 
            // loadUpdateImageButton
            // 
            this.loadUpdateImageButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadUpdateImageButton.Location = new System.Drawing.Point(952, 6);
            this.loadUpdateImageButton.Name = "loadUpdateImageButton";
            this.loadUpdateImageButton.Size = new System.Drawing.Size(171, 82);
            this.loadUpdateImageButton.TabIndex = 19;
            this.loadUpdateImageButton.Text = "Загрузить фото";
            this.loadUpdateImageButton.UseVisualStyleBackColor = true;
            this.loadUpdateImageButton.Click += new System.EventHandler(this.loadUpdateImageButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(751, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // updateDefectButton
            // 
            this.updateDefectButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateDefectButton.Location = new System.Drawing.Point(952, 162);
            this.updateDefectButton.Name = "updateDefectButton";
            this.updateDefectButton.Size = new System.Drawing.Size(171, 82);
            this.updateDefectButton.TabIndex = 17;
            this.updateDefectButton.Text = "Изменить дефект";
            this.updateDefectButton.UseVisualStyleBackColor = true;
            this.updateDefectButton.Click += new System.EventHandler(this.updateDefectButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(683, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Фото:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID машины:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(347, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Описание дефекта:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Название дефекта:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "ID типа дефекта:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteDataButton);
            this.tabPage3.Controls.Add(this.deleteCartextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1129, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDataButton.Location = new System.Drawing.Point(23, 51);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(215, 53);
            this.deleteDataButton.TabIndex = 2;
            this.deleteDataButton.Text = "Удалить";
            this.deleteDataButton.UseVisualStyleBackColor = true;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // deleteCartextBox
            // 
            this.deleteCartextBox.Location = new System.Drawing.Point(146, 16);
            this.deleteCartextBox.Name = "deleteCartextBox";
            this.deleteCartextBox.Size = new System.Drawing.Size(100, 26);
            this.deleteCartextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID дефекта:";
            // 
            // DefectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1203, 696);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DefectsForm";
            this.Text = "Дефекты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DefectsForm_FormClosing);
            this.Load += new System.EventHandler(this.DefectsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox nameDefectTextBox;
        private System.Windows.Forms.TextBox idCarTextBox;
        private System.Windows.Forms.TextBox idTypeDefectTextBox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addDefectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem goCarToolStripMenuItem;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.TextBox deleteCartextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateIdDefectTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox updateRichTextBox;
        private System.Windows.Forms.TextBox updateNameDefectTextBox;
        private System.Windows.Forms.TextBox updateIdCarTextBox;
        private System.Windows.Forms.TextBox updateIdTypeDefectTextBox;
        private System.Windows.Forms.Button loadUpdateImageButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button updateDefectButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}