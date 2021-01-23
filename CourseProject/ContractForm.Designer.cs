namespace CourseProject
{
    partial class ContractForm
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
            this.goMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showContractButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addContractButton = new System.Windows.Forms.Button();
            this.idPurchasetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idCarTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carCostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateIdContractTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateIdPurchaseTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateIdCarTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateIdEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.updateIdClientTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.updateCarCostTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goMainFormToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goMainFormToolStripMenuItem
            // 
            this.goMainFormToolStripMenuItem.Name = "goMainFormToolStripMenuItem";
            this.goMainFormToolStripMenuItem.Size = new System.Drawing.Size(243, 29);
            this.goMainFormToolStripMenuItem.Text = "Перейти на главное меню";
            this.goMainFormToolStripMenuItem.Click += new System.EventHandler(this.goMainFormToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 268);
            this.dataGridView1.TabIndex = 1;
            // 
            // showContractButton
            // 
            this.showContractButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showContractButton.Location = new System.Drawing.Point(13, 311);
            this.showContractButton.Name = "showContractButton";
            this.showContractButton.Size = new System.Drawing.Size(171, 82);
            this.showContractButton.TabIndex = 2;
            this.showContractButton.Text = "Отобразить данные";
            this.showContractButton.UseVisualStyleBackColor = true;
            this.showContractButton.Click += new System.EventHandler(this.showContractButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 399);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1148, 274);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addContractButton);
            this.tabPage1.Controls.Add(this.idPurchasetextBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.idCarTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.idEmployeeTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.idClientTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.carCostTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addContractButton
            // 
            this.addContractButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addContractButton.Location = new System.Drawing.Point(510, 6);
            this.addContractButton.Name = "addContractButton";
            this.addContractButton.Size = new System.Drawing.Size(171, 82);
            this.addContractButton.TabIndex = 4;
            this.addContractButton.Text = "Добавить контракт";
            this.addContractButton.UseVisualStyleBackColor = true;
            this.addContractButton.Click += new System.EventHandler(this.addContractButton_Click);
            // 
            // idPurchasetextBox
            // 
            this.idPurchasetextBox.Location = new System.Drawing.Point(284, 167);
            this.idPurchasetextBox.Name = "idPurchasetextBox";
            this.idPurchasetextBox.Size = new System.Drawing.Size(200, 26);
            this.idPurchasetextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID типа приобретения:";
            // 
            // idCarTextBox
            // 
            this.idCarTextBox.Location = new System.Drawing.Point(284, 133);
            this.idCarTextBox.Name = "idCarTextBox";
            this.idCarTextBox.Size = new System.Drawing.Size(200, 26);
            this.idCarTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID Машины:";
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.Location = new System.Drawing.Point(284, 101);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.Size = new System.Drawing.Size(200, 26);
            this.idEmployeeTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID Сотрудника:";
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(284, 68);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(200, 26);
            this.idClientTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Клиента: ";
            // 
            // carCostTextBox
            // 
            this.carCostTextBox.Location = new System.Drawing.Point(284, 36);
            this.carCostTextBox.Name = "carCostTextBox";
            this.carCostTextBox.Size = new System.Drawing.Size(200, 26);
            this.carCostTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стоимость машины:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата подписания контракта:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateIdContractTextBox);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.updateButton);
            this.tabPage2.Controls.Add(this.updateIdPurchaseTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.updateIdCarTextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.updateIdEmployeeTextBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.updateIdClientTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.updateCarCostTextBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateIdContractTextBox
            // 
            this.updateIdContractTextBox.Location = new System.Drawing.Point(298, 7);
            this.updateIdContractTextBox.Name = "updateIdContractTextBox";
            this.updateIdContractTextBox.Size = new System.Drawing.Size(200, 26);
            this.updateIdContractTextBox.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "ID Контракта";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(963, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(171, 82);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Изменить контракт";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateIdPurchaseTextBox
            // 
            this.updateIdPurchaseTextBox.Location = new System.Drawing.Point(735, 12);
            this.updateIdPurchaseTextBox.Name = "updateIdPurchaseTextBox";
            this.updateIdPurchaseTextBox.Size = new System.Drawing.Size(200, 26);
            this.updateIdPurchaseTextBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(514, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID типа приобретения:";
            // 
            // updateIdCarTextBox
            // 
            this.updateIdCarTextBox.Location = new System.Drawing.Point(298, 167);
            this.updateIdCarTextBox.Name = "updateIdCarTextBox";
            this.updateIdCarTextBox.Size = new System.Drawing.Size(200, 26);
            this.updateIdCarTextBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID Машины:";
            // 
            // updateIdEmployeeTextBox
            // 
            this.updateIdEmployeeTextBox.Location = new System.Drawing.Point(298, 135);
            this.updateIdEmployeeTextBox.Name = "updateIdEmployeeTextBox";
            this.updateIdEmployeeTextBox.Size = new System.Drawing.Size(200, 26);
            this.updateIdEmployeeTextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(17, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "ID Сотрудника:";
            // 
            // updateIdClientTextBox
            // 
            this.updateIdClientTextBox.Location = new System.Drawing.Point(298, 102);
            this.updateIdClientTextBox.Name = "updateIdClientTextBox";
            this.updateIdClientTextBox.Size = new System.Drawing.Size(200, 26);
            this.updateIdClientTextBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(17, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "ID Клиента: ";
            // 
            // updateCarCostTextBox
            // 
            this.updateCarCostTextBox.Location = new System.Drawing.Point(298, 70);
            this.updateCarCostTextBox.Name = "updateCarCostTextBox";
            this.updateCarCostTextBox.Size = new System.Drawing.Size(200, 26);
            this.updateCarCostTextBox.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(17, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Стоимость машины:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(298, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(17, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(270, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Дата подписания контракта:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteButton);
            this.tabPage3.Controls.Add(this.deleteIdTextBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1140, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(18, 55);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(215, 53);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteIdTextBox
            // 
            this.deleteIdTextBox.Location = new System.Drawing.Point(152, 16);
            this.deleteIdTextBox.Name = "deleteIdTextBox";
            this.deleteIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.deleteIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Контракта:";
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1203, 681);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.showContractButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контракты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractForm_FormClosing);
            this.Load += new System.EventHandler(this.ContractForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goMainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showContractButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteIdTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idPurchasetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idCarTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carCostTextBox;
        private System.Windows.Forms.Button addContractButton;
        private System.Windows.Forms.TextBox updateIdContractTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateIdPurchaseTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updateIdCarTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateIdEmployeeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox updateIdClientTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox updateCarCostTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
    }
}