namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEmployees = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxPosition = new TextBox();
            textBoxNumber = new TextBox();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            comboBoxGender = new ComboBox();
            dateTimePickerDoB = new DateTimePicker();
            label1 = new Label();
            panel1 = new Panel();
            buttonClose = new Button();
            label9 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBoxDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewEmployees.Location = new Point(360, 177);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewEmployees.Size = new Size(1023, 465);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "First name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Last Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gender";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date of Birth";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Phone Number";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Department";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(24, 613);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(24, 220);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(151, 27);
            textBoxId.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(191, 220);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(24, 320);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(151, 27);
            textBoxPosition.TabIndex = 4;
            textBoxPosition.TextChanged += textBoxPosition_TextChanged;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(190, 432);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(151, 27);
            textBoxNumber.TabIndex = 5;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Crimson;
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(137, 613);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Edit";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Crimson;
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(248, 613);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(191, 320);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(151, 28);
            comboBoxGender.TabIndex = 8;
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.CustomFormat = "dd-MM-yyyy";
            dateTimePickerDoB.Format = DateTimePickerFormat.Custom;
            dateTimePickerDoB.Location = new Point(24, 432);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(151, 27);
            dateTimePickerDoB.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(24, 177);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 10;
            label1.Text = "Employee Id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1396, 106);
            panel1.TabIndex = 11;
            // 
            // buttonClose
            // 
            buttonClose.BackgroundImage = EmployeeManagementSystem.Resource1.close;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(1316, 33);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(47, 47);
            buttonClose.TabIndex = 23;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Crimson;
            label9.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(12, 34);
            label9.Name = "label9";
            label9.Size = new Size(550, 41);
            label9.TabIndex = 22;
            label9.Text = "Employee Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(label10);
            panel2.Location = new Point(-1, 689);
            panel2.Name = "panel2";
            panel2.Size = new Size(1459, 45);
            panel2.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Crimson;
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(492, 14);
            label10.Name = "label10";
            label10.Size = new Size(433, 21);
            label10.TabIndex = 23;
            label10.Text = "Developed by - D.M.S.N. Dayaratne CS/2017/004";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(191, 177);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 13;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(24, 286);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 14;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(191, 286);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 15;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(24, 400);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 16;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(190, 400);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 17;
            label6.Text = "Phone Number";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(24, 528);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(151, 27);
            textBoxEmail.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(25, 496);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 19;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(191, 496);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 20;
            label8.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Items.AddRange(new object[] { "Human Resources", "Finance", "Sales", "Marketing", "Operations management", "IT" });
            comboBoxDepartment.Location = new Point(191, 528);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(151, 28);
            comboBoxDepartment.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 734);
            Controls.Add(comboBoxDepartment);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDoB);
            Controls.Add(comboBoxGender);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(button1);
            Controls.Add(dataGridViewEmployees);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Button button1;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxPosition;
        private TextBox textBoxNumber;
        private Button buttonUpdate;
        private Button buttonDelete;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerDoB;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label7;
        private Label label8;
        private ComboBox comboBoxDepartment;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label9;
        private Label label10;
        private Button buttonClose;
    }
}