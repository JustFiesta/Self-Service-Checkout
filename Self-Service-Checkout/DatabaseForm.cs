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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex <= rowCount)
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
                    if (!string.IsNullOrEmpty(newValue))
                    {
                    customer.PhoneNumber = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Phone number cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if phone number is empty
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
                    if (!string.IsNullOrEmpty(newValue))
                    {
                    employee.PhoneNumber = newValue;
                    }
                    else
                    {
                        MessageBox.Show("Phone number cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop the update if phone number is empty
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
        // ----------------------

        // Delete functions - Customer/Employee

        // TODO
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

        // TODO
        private void SaveNewCustomers()
        {
            foreach (DataGridViewRow row in customerDGV.Rows)
            {
                if (row.IsNewRow) continue;

                Customer newCustomer = new Customer
                {
                    Name = Convert.ToString(row.Cells[1].Value),
                    Surname = Convert.ToString(row.Cells[2].Value),
                    PhoneNumber = Convert.ToString(row.Cells[3].Value),
                    Email = Convert.ToString(row.Cells[4].Value)
                };

                Debug.WriteLine(newCustomer.Name, newCustomer.Surname, newCustomer.PhoneNumber, newCustomer.Email);

                context.Customers.Add(newCustomer);
            }

            context.SaveChanges();
            GetDBContents(option.Text); // Odśwież wyświetlanie danych
        }
        // TODO
        private void SaveNewEmployees()
        {
            foreach (DataGridViewRow row in employeeDGV.Rows)
            {
                if (row.IsNewRow) continue;

                Employee newEmployee = new Employee
                {
                    Name = Convert.ToString(row.Cells[1].Value),
                    Surname = Convert.ToString(row.Cells[2].Value),
                    PhoneNumber = Convert.ToString(row.Cells[3].Value),
                    Email = Convert.ToString(row.Cells[4].Value),
                    /*employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), Convert.ToString(row.Cells[5].Value)),*/
                    employeeType = EmployeeType.cashier,
                    AccessCode = Convert.ToInt32(row.Cells[6].Value)
                };

                Debug.WriteLine(newEmployee.Name, newEmployee.Surname, newEmployee.PhoneNumber, newEmployee.Email, newEmployee.employeeType, newEmployee.AccessCode);

                context.Employees.Add(newEmployee);
            }

            context.SaveChanges();
            GetDBContents(option.Text); // Odśwież wyświetlanie danych
        }

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDBContents(option.Text);
        }
    }
}
