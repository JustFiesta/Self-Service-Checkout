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

            if (category.Equals("Customers"))
            {
                customers = context.Customers.ToList();
                customerDGV.Rows.AddRange(customers.Select(c => ConvertCustomerToRow(c)).ToArray());

                customerDGV.Visible = true;
                employeeDGV.Visible = false;
                return customers;
            }

            if (category.Equals("Employees"))
            {
                employees = context.Employees.ToList();
                employeeDGV.Rows.AddRange(employees.Select(e => ConvertEmployeeToRow(e)).ToArray());

                employeeDGV.Visible = true;
                customerDGV.Visible = false;
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

            // Get DB contents for corresponding option
            GetDBContents(option.Text);
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if cell was changed
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
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

        // Edit functions - Customer/Employee
        private void UpdateCustomerData(int customerId, int columnIndex, string newValue)
        {
            // Find customer in db
            Customer customer = context.Customers.Find(customerId);

            // Update corresponding
            switch (columnIndex)
            {
                case 1:
                    customer.Name = newValue;
                    break;
                case 2:
                    customer.Surname = newValue;
                    break;
                case 3:
                    customer.PhoneNumber = newValue;
                    break;
                case 4:
                    customer.Email = newValue;
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
                    employee.Name = newValue;
                    break;
                case 2:
                    employee.Surname = newValue;
                    break;
                case 3:
                    employee.PhoneNumber = newValue;
                    break;
                case 4:
                    employee.Email = newValue;
                    break;
                case 5:
                    if (Enum.TryParse(newValue, out EmployeeType employeeType))
                    {
                        employee.employeeType = employeeType;
                    }
                    else
                    {
                        MessageBox.Show("Invalid employee type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 6:
                    if (int.TryParse(newValue, out int accessCode))
                    {
                        employee.AccessCode = accessCode;
                    }
                    else
                    {
                        MessageBox.Show("Invalid access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }

            // Save changes
            context.SaveChanges();
        }
        // ----------------------

        // Update functions - Customer/Employee


        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDBContents(option.Text);
        }
    }
}
