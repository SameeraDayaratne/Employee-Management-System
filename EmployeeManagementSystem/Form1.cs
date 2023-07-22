using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private const string databaseFilePath = "employee.txt"; // Path to the text file database
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            // Clear existing data and columns
            dataGridViewEmployees.Rows.Clear();
            dataGridViewEmployees.Columns.Clear();

            // Read data from the text file
            string[] lines = File.ReadAllLines(databaseFilePath);

            if (lines.Length > 0)
            {
                // Add columns based on the first line (header) in the text file
                string[] headers = lines[0].Split(',');
                foreach (string header in headers)
                {
                    dataGridViewEmployees.Columns.Add(header, header);
                }

                // Add rows based on the remaining lines (data) in the text file
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    dataGridViewEmployees.Rows.Add(values);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get employee details from text boxes
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

            bool idExists = CheckIfIdExists(databaseFilePath, id);

            if (idExists)
            {
                // Show a message box or perform any desired action
                MessageBox.Show("Id Already exists, Please enter a new Id", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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





            // Create the employee record
            string employee = $"{id},{name},{position},{gender},{birthDate},{number},{email},{department}";

            // Append the record to the text file
            File.AppendAllText(databaseFilePath, employee + Environment.NewLine);

            // Refresh the employee table
            LoadEmployees();

            // Clear input fields
            // ClearInputFields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Get the selected row
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployees.SelectedRows[0];

                // Get the employee details from the selected row
                string id = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[1].Value.ToString();
                string position = selectedRow.Cells[2].Value.ToString();
                string gender = selectedRow.Cells[3].Value.ToString();
                string birthDate = selectedRow.Cells[4].Value.ToString();
                string number = selectedRow.Cells[5].Value.ToString();
                string email = selectedRow.Cells[6].Value.ToString();
                string department = selectedRow.Cells[7].Value.ToString();


                // Show the UpdateEmployeeForm to allow updating the employee details
                UpdateEmployeeForm updateForm = new UpdateEmployeeForm(id, name, position, gender, birthDate, number, email, department);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the employee record in the text file
                    string updatedEmployee = $"{updateForm.EmployeeId},{updateForm.EmployeeName},{updateForm.EmployeePosition},{updateForm.EmployeeGender},{updateForm.EmployeeBirthDate},{updateForm.EmployeeNumber},{updateForm.EmployeeEmail},{updateForm.EmployeeDepartment}";
                    List<string> lines = new List<string>(File.ReadAllLines(databaseFilePath));
                    int selectedIndex = selectedRow.Index;
                    lines[selectedIndex + 1] = updatedEmployee;
                    File.WriteAllLines(databaseFilePath, lines);

                    // Refresh the employee table
                    LoadEmployees();
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployees.SelectedRows[0];


                // Remove the employee record from the text file
                List<string> lines = new List<string>(File.ReadAllLines(databaseFilePath));
                int selectedIndex = selectedRow.Index;
                lines.RemoveAt(selectedIndex + 1);
                File.WriteAllLines(databaseFilePath, lines);

                // Refresh the employee table
                LoadEmployees();
            }

        }

        private void ClearInputFields()
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxPosition.Clear();
            comboBoxGender.SelectedItem = null;
            textBoxNumber.Clear();
            textBoxEmail.Clear();
            comboBoxDepartment.SelectedItem = null;

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

        static bool CheckIfIdExists(string databaseFilePath, string id)
        {
            if (File.Exists(databaseFilePath))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(databaseFilePath);

                // Check if any line contains the given ID
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0 && parts[0] == id)
                    {
                        return true; // ID already exists
                    }
                }
            }

            return false; // ID not found in the file
        }

        private void textBoxPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Applicatiom", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}