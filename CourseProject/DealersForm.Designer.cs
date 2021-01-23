namespace CourseProject
{
    partial class DealersForm
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
            this.goMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showDealersButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addDealerButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idTypeDealerTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.idUpdateDealerTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.updateDealerButton = new System.Windows.Forms.Button();
            this.loadNewImageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateIdTypeDealerTextBox = new System.Windows.Forms.TextBox();
            this.updateAddressTextBox = new System.Windows.Forms.TextBox();
            this.updateEmailTextBox = new System.Windows.Forms.TextBox();
            this.updatePhoneTextBox = new System.Windows.Forms.TextBox();
            this.updateContactfaceTextBox = new System.Windows.Forms.TextBox();
            this.updateNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteDealerButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goMainMenuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goMainMenuToolStripMenuItem
            // 
            this.goMainMenuToolStripMenuItem.Name = "goMainMenuToolStripMenuItem";
            this.goMainMenuToolStripMenuItem.Size = new System.Drawing.Size(243, 32);
            this.goMainMenuToolStripMenuItem.Text = "Перейти на главное меню";
            this.goMainMenuToolStripMenuItem.Click += new System.EventHandler(this.goMainMenuToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            // showDealersButton
            // 
            this.showDealersButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDealersButton.Location = new System.Drawing.Point(13, 312);
            this.showDealersButton.Name = "showDealersButton";
            this.showDealersButton.Size = new System.Drawing.Size(171, 82);
            this.showDealersButton.TabIndex = 2;
            this.showDealersButton.Text = "Отобразить данные";
            this.showDealersButton.UseVisualStyleBackColor = true;
            this.showDealersButton.Click += new System.EventHandler(this.showDealersButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 401);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1129, 250);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addDealerButton);
            this.tabPage1.Controls.Add(this.loadImageButton);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.idTypeDealerTextBox);
            this.tabPage1.Controls.Add(this.addressTextBox);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(this.phoneTextBox);
            this.tabPage1.Controls.Add(this.contactPersonTextBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1121, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addDealerButton
            // 
            this.addDealerButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDealerButton.Location = new System.Drawing.Point(835, 120);
            this.addDealerButton.Name = "addDealerButton";
            this.addDealerButton.Size = new System.Drawing.Size(161, 71);
            this.addDealerButton.TabIndex = 15;
            this.addDealerButton.Text = "Добавить дилера";
            this.addDealerButton.UseVisualStyleBackColor = true;
            this.addDealerButton.Click += new System.EventHandler(this.addDealerButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadImageButton.Location = new System.Drawing.Point(835, 16);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(161, 71);
            this.loadImageButton.TabIndex = 14;
            this.loadImageButton.Text = "Загрузить изображение";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(593, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // idTypeDealerTextBox
            // 
            this.idTypeDealerTextBox.Location = new System.Drawing.Point(593, 156);
            this.idTypeDealerTextBox.Name = "idTypeDealerTextBox";
            this.idTypeDealerTextBox.Size = new System.Drawing.Size(205, 26);
            this.idTypeDealerTextBox.TabIndex = 12;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(190, 156);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(205, 26);
            this.addressTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(190, 120);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(205, 26);
            this.emailTextBox.TabIndex = 10;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(190, 85);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(205, 26);
            this.phoneTextBox.TabIndex = 9;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(190, 51);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(205, 26);
            this.contactPersonTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(190, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(205, 26);
            this.nameTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(469, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Тип дилера:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(469, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Фото:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Почта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Контактное лицо:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название фирмы:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.idUpdateDealerTextBox);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.updateDealerButton);
            this.tabPage2.Controls.Add(this.loadNewImageButton);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.updateIdTypeDealerTextBox);
            this.tabPage2.Controls.Add(this.updateAddressTextBox);
            this.tabPage2.Controls.Add(this.updateEmailTextBox);
            this.tabPage2.Controls.Add(this.updatePhoneTextBox);
            this.tabPage2.Controls.Add(this.updateContactfaceTextBox);
            this.tabPage2.Controls.Add(this.updateNameTextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1121, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // idUpdateDealerTextBox
            // 
            this.idUpdateDealerTextBox.Location = new System.Drawing.Point(200, 7);
            this.idUpdateDealerTextBox.Name = "idUpdateDealerTextBox";
            this.idUpdateDealerTextBox.Size = new System.Drawing.Size(205, 26);
            this.idUpdateDealerTextBox.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(17, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 21);
            this.label16.TabIndex = 32;
            this.label16.Text = "ID Диалера:";
            // 
            // updateDealerButton
            // 
            this.updateDealerButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateDealerButton.Location = new System.Drawing.Point(835, 136);
            this.updateDealerButton.Name = "updateDealerButton";
            this.updateDealerButton.Size = new System.Drawing.Size(161, 71);
            this.updateDealerButton.TabIndex = 31;
            this.updateDealerButton.Text = "Изменить дилера";
            this.updateDealerButton.UseVisualStyleBackColor = true;
            this.updateDealerButton.Click += new System.EventHandler(this.updateDealerButton_Click);
            // 
            // loadNewImageButton
            // 
            this.loadNewImageButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadNewImageButton.Location = new System.Drawing.Point(835, 12);
            this.loadNewImageButton.Name = "loadNewImageButton";
            this.loadNewImageButton.Size = new System.Drawing.Size(161, 71);
            this.loadNewImageButton.TabIndex = 30;
            this.loadNewImageButton.Text = "Загрузить изображение";
            this.loadNewImageButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(593, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // updateIdTypeDealerTextBox
            // 
            this.updateIdTypeDealerTextBox.Location = new System.Drawing.Point(593, 172);
            this.updateIdTypeDealerTextBox.Name = "updateIdTypeDealerTextBox";
            this.updateIdTypeDealerTextBox.Size = new System.Drawing.Size(205, 26);
            this.updateIdTypeDealerTextBox.TabIndex = 28;
            // 
            // updateAddressTextBox
            // 
            this.updateAddressTextBox.Location = new System.Drawing.Point(593, 131);
            this.updateAddressTextBox.Name = "updateAddressTextBox";
            this.updateAddressTextBox.Size = new System.Drawing.Size(205, 26);
            this.updateAddressTextBox.TabIndex = 27;
            // 
            // updateEmailTextBox
            // 
            this.updateEmailTextBox.Location = new System.Drawing.Point(200, 163);
            this.updateEmailTextBox.Name = "updateEmailTextBox";
            this.updateEmailTextBox.Size = new System.Drawing.Size(205, 26);
            this.updateEmailTextBox.TabIndex = 26;
            // 
            // updatePhoneTextBox
            // 
            this.updatePhoneTextBox.Location = new System.Drawing.Point(200, 128);
            this.updatePhoneTextBox.Name = "updatePhoneTextBox";
            this.updatePhoneTextBox.Size = new System.Drawing.Size(205, 26);
            this.updatePhoneTextBox.TabIndex = 25;
            // 
            // updateContactfaceTextBox
            // 
            this.updateContactfaceTextBox.Location = new System.Drawing.Point(200, 94);
            this.updateContactfaceTextBox.Name = "updateContactfaceTextBox";
            this.updateContactfaceTextBox.Size = new System.Drawing.Size(205, 26);
            this.updateContactfaceTextBox.TabIndex = 24;
            // 
            // updateNameTextBox
            // 
            this.updateNameTextBox.Location = new System.Drawing.Point(200, 57);
            this.updateNameTextBox.Name = "updateNameTextBox";
            this.updateNameTextBox.Size = new System.Drawing.Size(205, 26);
            this.updateNameTextBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(469, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Тип дилера:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(469, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Фото:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(469, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Адрес:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(17, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Почта:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(17, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "Телефон:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(17, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Контактное лицо:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(17, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Название фирмы:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteDealerButton);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1121, 217);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteDealerButton
            // 
            this.deleteDealerButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDealerButton.Location = new System.Drawing.Point(22, 59);
            this.deleteDealerButton.Name = "deleteDealerButton";
            this.deleteDealerButton.Size = new System.Drawing.Size(215, 53);
            this.deleteDealerButton.TabIndex = 2;
            this.deleteDealerButton.Text = "Удалить";
            this.deleteDealerButton.UseVisualStyleBackColor = true;
            this.deleteDealerButton.Click += new System.EventHandler(this.deleteDealerButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Дилера:";
            // 
            // DealersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1203, 696);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.showDealersButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DealersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дилеры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DealersForm_FormClosing);
            this.Load += new System.EventHandler(this.DealersForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem goMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showDealersButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteDealerButton;
        private System.Windows.Forms.Button addDealerButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idTypeDealerTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idUpdateDealerTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button updateDealerButton;
        private System.Windows.Forms.Button loadNewImageButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox updateIdTypeDealerTextBox;
        private System.Windows.Forms.TextBox updateAddressTextBox;
        private System.Windows.Forms.TextBox updateEmailTextBox;
        private System.Windows.Forms.TextBox updatePhoneTextBox;
        private System.Windows.Forms.TextBox updateContactfaceTextBox;
        private System.Windows.Forms.TextBox updateNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}