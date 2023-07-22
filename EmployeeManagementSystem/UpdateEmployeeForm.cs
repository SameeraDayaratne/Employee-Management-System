using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class UpdateEmployeeForm : Form
    {
        private const string databaseFilePath = "employee.txt";
        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        // Properties to access updated employee details
        public string EmployeeId => textBoxId.Text;
        public string EmployeeName => textBoxName.Text;
        public string EmployeePosition => textBoxPosition.Text;
        public string EmployeeGender => comboBoxGender.GetItemText(comboBoxGender.SelectedItem);
        public string EmployeeBirthDate => dateTimePickerDoB.Text;
        public string EmployeeNumber => textBoxNumber.Text;
        public string EmployeeEmail => textBoxEmail.Text;
        public string EmployeeDepartment => comboBoxDepartment.GetItemText(comboBoxDepartment.SelectedItem);


        public UpdateEmployeeForm(string id, string name, string position, string gender, string birthDate, string number, string email, string department)
        : this()
        {
            textBoxId.Text = id;
            textBoxName.Text = name;
            textBoxPosition.Text = position;
            comboBoxGender.Text = gender;
            string dateFormat = "dd-MM-yyyy";

            // Parse the string to a DateTime object using the specified format
            if (DateTime.TryParseExact(birthDate, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime desiredDate))
            {
                // Set the value of the DateTimePicker control to the parsed date
                dateTimePickerDoB.Value = desiredDate;
            }

            textBoxNumber.Text = number;
            textBoxEmail.Text = email;
            comboBoxDepartment.Text = department;
        }




        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            string id = textBoxId.Text;
            string name = textBoxName.Text;
            string position = textBoxPosition.Text;
            string gender = comboBoxGender.GetItemText(comboBoxGender.SelectedItem);
            string birthDate = dateTimePickerDoB.Text;
            string number = textBoxNumber.Text;
            string email = textBoxEmail.Text;
            string department = comboBoxDepartment.GetItemText(comboBoxDepartment.SelectedItem);

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position) ||
               string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(birthDate) || string.IsNullOrEmpty(number) ||
               string.IsNullOrEmpty(email) || string.IsNullOrEmpty(department))
            {
                // Show a messagebox indicating that some values are empty
                MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Exit the method or return, depending on your logic
                return;
            }


            bool isInteger = IsInteger(number);

            if (!isInteger)
            {
                MessageBox.Show("Please enter a valid phone number", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            bool isValidEmail = IsValidEmail(email);

            if (!isValidEmail)
            {
                MessageBox.Show("Please enter a valid email address.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }





            DialogResult = DialogResult.OK;
            Close();
        }

        static bool IsValidEmail(string email)
        {
            // This regular expression pattern checks for a valid email address format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        static bool IsInteger(string number)
        {
            // Use int.TryParse to attempt parsing the string as an integer
            return long.TryParse(number, out long result);
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
