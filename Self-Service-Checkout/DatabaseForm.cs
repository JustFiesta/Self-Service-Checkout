using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Self_Service_Checkout.Data;
using Self_Service_Checkout.Models;

namespace Self_Service_Checkout
{
    public partial class DatabaseForm : Form
    {
        private SscdbContext context = new SscdbContext();
        private int rowCount = 0;
        public DatabaseForm()
        {
            InitializeComponent();
        }
        //super special function that removes applications running in the background
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //changing the image when you hover over the button
        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.backHover;
        }
        //changing the image when you leave the button
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.back;
        }
        //backButton action - exit current window
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Gets DB contents
        private dynamic GetDBContents(string category)
        {
            List<Customer> customers = null;
            List<Employee> employees = null;
            customerDGV.Rows.Clear();
            employeeDGV.Rows.Clear();

            if (category.Equals("Customers"))
            {
                customers = context.Customers.OrderBy(e => e.Id).ToList();
                customerDGV.Rows.AddRange(customers.Select(c => ConvertCustomerToRow(c)).ToArray());

                customerDGV.Visible = true;
                employeeDGV.Visible = false;

                rowCount = customers.Count;

                return customers;
            }

            if (category.Equals("Employees"))
            {
                employees = context.Employees.Where(e => e.Id != 1).OrderBy(e => e.Id).ToList();
                employeeDGV.Rows.AddRange(employees.Select(e => ConvertEmployeeToRow(e)).ToArray());

                employeeDGV.Visible = true;
                customerDGV.Visible = false;

                rowCount = employees.Count;

                return employees;
            }
            return null;
        }
        private DataGridViewRow ConvertCustomerToRow(Customer customer)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(customerDGV);
            row.Cells[0].Value = customer.Id;
            row.Cells[1].Value = customer.Name;
            row.Cells[2].Value = customer.Surname;
            row.Cells[3].Value = customer.PhoneNumber;
            row.Cells[4].Value = customer.Email;
            return row;
        }
        private DataGridViewRow ConvertEmployeeToRow(Employee employee)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(employeeDGV);
            row.Cells[0].Value = employee.Id;
            row.Cells[1].Value = employee.Name;
            row.Cells[2].Value = employee.Surname;
            row.Cells[3].Value = employee.PhoneNumber;
            row.Cells[4].Value = employee.Email;
            row.Cells[5].Value = employee.employeeType;
            row.Cells[6].Value = employee.AccessCode;
            return row;
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // Set edit type to EditProgrammatically
            customerDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            employeeDGV.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Assign action DataGridView_CellValueChanged
            customerDGV.CellValueChanged += DataGridView_CellValueChanged;
            employeeDGV.CellValueChanged += DataGridView_CellValueChanged;

            // Assign key action
            customerDGV.KeyDown += DataGridView_KeyDown;
            employeeDGV.KeyDown += DataGridView_KeyDown;

            // Disable editing for the first column (id)
            customerDGV.Columns[0].ReadOnly = true;
            employeeDGV.Columns[0].ReadOnly = true;
        }

        // Update functions - Customer/Employee
        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // Check if correct column and row are selected
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < rowCount)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Get new value
                string newValue = row.Cells[e.ColumnIndex].Value?.ToString();

                // Get cell id
                int id = Convert.ToInt32(row.Cells[0].Value);

                // Persist data to DB
                if (dataGridView == customerDGV)
                {
                    UpdateCustomerData(id, e.ColumnIndex, newValue);
                }
                else if (dataGridView == employeeDGV)
                {
                    UpdateEmployeeData(id, e.ColumnIndex, newValue);
                }
            }
        }

        private void UpdateCustomerData(int customerId, int columnIndex, string newValue)
        {
            // Find customer in db
            Customer customer = context.Customers.Find(customerId);

            // Update corresponding fields
            switch (columnIndex)
            {
                case 1:
                    // Validation for customer name
                    if (!string.IsNullOrEmpty(newValue))
                    {
                    customer.Name = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if name is empty
                    }
                    break;
                case 2:
                    // Validation for customer surname
                    if (!string.IsNullOrEmpty(newValue))
                    {
                    customer.Surname = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Surname cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if surname is empty
                    }
                    break;
                case 3:
                    // Validation for customer phone number
                    if (!string.IsNullOrEmpty(newValue) && IsValidPhoneNumber(newValue))
                    {
                    customer.PhoneNumber = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid phone number format. Please use format: 123 123 123.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if phone number is invalid
                    }
                    break;
                case 4:
                    // Validation for customer email address
                    if (!string.IsNullOrEmpty(newValue) && newValue.Contains("@"))
                    {
                    customer.Email = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if email address is invalid
                    }
                    break;
                default:
                    break;
            }

            // Save changes
            context.SaveChanges();
        }

        private void UpdateEmployeeData(int employeeId, int columnIndex, string newValue)
        {
            Debug.WriteLine("Updating employee");
            // Find employee in db
            Employee employee = context.Employees.Find(employeeId);

            // Update corresponding fields
            switch (columnIndex)
            {
                case 1:
                    // Validation for employee name
                    if (!string.IsNullOrEmpty(newValue))
                    {
                    employee.Name = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if name is empty
                    }
                    break;
                case 2:
                    // Validation for employee surname
                    if (!string.IsNullOrEmpty(newValue))
                    {
                    employee.Surname = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Surname cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if surname is empty
                    }
                    break;
                case 3:
                    // Validation for employee phone number
                    if (!string.IsNullOrEmpty(newValue) && IsValidPhoneNumber(newValue))
                    {
                    employee.PhoneNumber = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid phone number format. Please use format: 123 123 123.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if phone number is invalid
                    }
                    break;
                case 4:
                    // Validation for employee email address
                    if (!string.IsNullOrEmpty(newValue) && newValue.Contains("@"))
                    {
                    employee.Email = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if email address is invalid
                    }
                    break;
                case 5:
                    // Validation for employee type
                    if (Enum.TryParse(newValue, out EmployeeType employeeType))
                    {
                        employee.employeeType = employeeType;
                    }
                    else
                    {
                        MessageBox.Show("Invalid employee type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if employee type is invalid
                    }
                    break;
                case 6:
                    // Validation for access code
                    if (int.TryParse(newValue, out int accessCode))
                    {
                        employee.AccessCode = accessCode;
                    }
                    else
                    {
                        MessageBox.Show("Invalid access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if access code is invalid
                    }
                    break;
                default:
                    break;
            }

            // Save changes
            context.SaveChanges();
        }

        // Validation function for phone number format
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Remove any non-digit characters
            string digitsOnly = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // Check if the formatted phone number has 9 digits and contains spaces
            return digitsOnly.Length == 9 && phoneNumber.Length == 11 && phoneNumber[3] == ' ' && phoneNumber[7] == ' ';
        }
        // ----------------------

        // Delete functions - Customer/Employee
        private void DeleteCustomer(int customerId)
        {
            Debug.WriteLine("Removing customer with id: " + customerId);
            // Find customer in db
            Customer customer = context.Customers.Find(customerId);

            // Check if customer exists
            if (customer != null)
            {
                // Remove customer from db
                context.Customers.Remove(customer);

                // Save changes
                context.SaveChanges();
            }
        }

        private void DeleteEmployee(int employeeId)
        {
            // Find employee in db
            Employee employee = context.Employees.Find(employeeId);

            // Check if employee exists
            if (employee != null)
            {
                // Remove employee from db
                context.Employees.Remove(employee);

                // Save changes
                context.SaveChanges();
            }
        }

        private void DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Delete key was pressed
            if (e.KeyCode == Keys.Delete)
            {
                DataGridView dataGridView = (DataGridView)sender;
                Debug.WriteLine("Selected datagridview: " + dataGridView);

                // Get selected row
                DataGridViewRow selectedRow = dataGridView.CurrentRow;

                // Check if any row is selected
                if (selectedRow != null)
                {
                    // Get row ID
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);

                    // Check which table is it and remove it from DB
                    if (dataGridView == customerDGV)
                    {
                        Debug.WriteLine("Customerid to delete: " + id);
                        DeleteCustomer(id);
                    }
                    else if (dataGridView == employeeDGV)
                    {
                        DeleteEmployee(id);
                    }

                    // Remove it from DataGridView
                    dataGridView.Rows.Remove(selectedRow);
                }
            }
        }
        // ----------------------

        // Create functions - Customer/Employee
        // DISCLAMER!!! After providing each box one needs to switch to other cell (not in row for adding)

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (option.Text.Equals("Customers"))
            {
                SaveNewCustomers();
            }
            else if (option.Text.Equals("Employees"))
            {
                SaveNewEmployees();
            }
        }
        private void SaveNewCustomers()
        {
            Debug.WriteLine("Saving customer");
            int newRowCounter = customerDGV.NewRowIndex; // Fetches last row id, but i treat it like row counter
            Debug.WriteLine("New customer row index: " + newRowCounter);
            Debug.WriteLine("Row count fetched from db at option: " + rowCount);

            List<Customer> newCustomers = new List<Customer>(); // Collection of multiple new users

            for (int i = rowCount; i < newRowCounter; i++) // It operates between indexes from db and new ones
            {
                Debug.WriteLine("Looping in for");

                DataGridViewRow row = customerDGV.Rows[i]; // Get row by its index

                Debug.WriteLine("New names: " + row.Cells[1].Value);

                string name = Convert.ToString(row.Cells[1].Value);
                string surname = Convert.ToString(row.Cells[2].Value);
                string phoneNumber = Convert.ToString(row.Cells[3].Value);
                string email = Convert.ToString(row.Cells[4].Value);

                // Validation for name
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop the process if name is empty
                }

                // Validation for surname
                if (string.IsNullOrEmpty(surname))
                {
                    MessageBox.Show("Surname cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop the process if surname is empty
                }

                // Validation for phone number
                if (string.IsNullOrEmpty(phoneNumber) || !IsValidPhoneNumber(phoneNumber))
                {
                    MessageBox.Show("Invalid phone number format. Please use format: 123 123 123.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop the process if phone number is invalid
                }

                // Validation for email
                if (string.IsNullOrEmpty(email) && !email.Contains("@"))
                {
                    MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop the process if email is invalid
                }

                Customer newCustomer = new Customer
                {
                    Name = name,
                    Surname = surname,
                    PhoneNumber = phoneNumber,
                    Email = email
                };

                Debug.WriteLine($"New customer: {newCustomer.Name}, {newCustomer.Surname}, {newCustomer.PhoneNumber}, {newCustomer.Email}");

                newCustomers.Add(newCustomer);
            }

            context.Customers.AddRange(newCustomers); // Add new customers to context
            context.SaveChanges(); // Persist changes
            GetDBContents(option.Text); // Refresh DGV
        }
        // TODO
        private void SaveNewEmployees()
        {
            Debug.WriteLine("Saving employees");
            int newRowCounter = employeeDGV.NewRowIndex; 
            Debug.WriteLine("New employee row index: " + newRowCounter);
            Debug.WriteLine("Row count fetched from db at option: " + rowCount);

            List<Employee> newEmployees = new List<Employee>(); 

            for (int i = rowCount; i < newRowCounter; i++) 
            {
                Debug.WriteLine("Looping in for");

                DataGridViewRow row = employeeDGV.Rows[i]; 

                Debug.WriteLine("New names: " + row.Cells[1].Value);

                Employee newEmployee = new Employee
                {
                    Name = Convert.ToString(row.Cells[1].Value),
                    Surname = Convert.ToString(row.Cells[2].Value),
                    PhoneNumber = Convert.ToString(row.Cells[3].Value),
                    Email = Convert.ToString(row.Cells[4].Value),
                    //employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), Convert.ToString(row.Cells[5].Value)), // Zakładam, że to jest poprawione gdzieś indziej
                    employeeType = EmployeeType.cashier, // temporary - still throws error
                    AccessCode = Convert.ToInt32(row.Cells[6].Value)
                };

                Debug.WriteLine($"New employee: {newEmployee.Name}, {newEmployee.Surname}, {newEmployee.PhoneNumber}, {newEmployee.Email}, {newEmployee.employeeType}, {newEmployee.AccessCode}");

                newEmployees.Add(newEmployee);
            }

            context.Employees.AddRange(newEmployees);
            context.SaveChanges();
            GetDBContents(option.Text); 
        }

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDBContents(option.Text);
        }
    }
}
