namespace WinFormsApp2
{
    partial class UpdateEmployeeForm
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
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxPosition = new TextBox();
            textBoxNumber = new TextBox();
            buttonUpdate = new Button();
            panel1 = new Panel();
            label10 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxGender = new ComboBox();
            dateTimePickerDoB = new DateTimePicker();
            comboBoxDepartment = new ComboBox();
            label8 = new Label();
            buttonCancel = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(220, 144);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(159, 27);
            textBoxId.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(407, 144);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(159, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(220, 223);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(159, 27);
            textBoxPosition.TabIndex = 2;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(407, 311);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(159, 27);
            textBoxNumber.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Crimson;
            buttonUpdate.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdate.Location = new Point(285, 438);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 69);
            panel1.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Crimson;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(338, 25);
            label10.Name = "label10";
            label10.Size = new Size(105, 24);
            label10.TabIndex = 25;
            label10.Text = "Edit Page";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(8, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(801, 76);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Crimson;
            panel4.Location = new Point(8, 426);
            panel4.Name = "panel4";
            panel4.Size = new Size(801, 27);
            panel4.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Location = new Point(8, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 27);
            panel2.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Crimson;
            panel5.Location = new Point(-1, 489);
            panel5.Name = "panel5";
            panel5.Size = new Size(801, 30);
            panel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(220, 105);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 11;
            label1.Text = "Employee Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(407, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(220, 389);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(159, 27);
            textBoxEmail.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(220, 187);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 16;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(407, 187);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 17;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(220, 270);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 18;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(407, 270);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 19;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(220, 357);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 20;
            label7.Text = "Email";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(407, 223);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(159, 28);
            comboBoxGender.TabIndex = 21;
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.CustomFormat = "dd-MM-yyyy";
            dateTimePickerDoB.Format = DateTimePickerFormat.Custom;
            dateTimePickerDoB.Location = new Point(220, 311);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(159, 27);
            dateTimePickerDoB.TabIndex = 22;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Items.AddRange(new object[] { "Human Resources", "Finance", "Sales", "Marketing", "Operations management", "IT" });
            comboBoxDepartment.Location = new Point(407, 388);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(159, 28);
            comboBoxDepartment.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(407, 357);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 24;
            label8.Text = "Department";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Crimson;
            buttonCancel.ForeColor = SystemColors.ButtonHighlight;
            buttonCancel.Location = new Point(407, 438);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // UpdateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(buttonCancel);
            Controls.Add(label8);
            Controls.Add(comboBoxDepartment);
            Controls.Add(dateTimePickerDoB);
            Controls.Add(comboBoxGender);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateEmployeeForm";
            Text = "UpdateEmployeeForm";
            Load += UpdateEmployeeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxPosition;
        private TextBox textBoxNumber;
        private Button buttonUpdate;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerDoB;
        private ComboBox comboBoxDepartment;
        private Label label8;
        private Label label10;
        private Button buttonCancel;
    }
}