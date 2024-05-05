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
using Self_Service_Checkout.Models;

namespace Self_Service_Checkout
{
    public partial class CartManagementForm : Form
    {
        private mainForm _mainForm = mainForm.Instance;
        private string[] selected_item = new string[3];

        public CartManagementForm()
        {

            InitializeComponent();
            copyDataGridView();
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
        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.delete;
        }
        private void Save_Button_MouseEnter(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.save;
        }
        //changing the image when you leave the button
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.back;
        }
        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.deleteHover;
        }
        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.saveHover;
        }

        //turning off the window after pressing the back button
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //function for checkboxes
        private void checkBoxYES_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYES.Checked)
            {
                checkBoxNO.Checked = false;
            }
        }
        private void checkBoxNO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNO.Checked)
            {
                checkBoxYES.Checked = false;
            }
        }

        // Function for save buton actions
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Check checkbox input
            if (checkBoxYES.Checked)
            {
                confirmBuyerAge();
            }
            else if (checkBoxNO.Checked)
            {
                removeProhibitedItems();
                confirmBuyerAge(); // disable labels after items were removed
            }

            // Check if quantity field is invalid
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if (int.TryParse(textBox3.Text, out int newQuantity) && newQuantity > 0)
                {
                    updateProductQuantity(newQuantity);
                }
                else if (newQuantity == 0)
                {
                    removeProduct();
                }
                else
                {
                    MessageBox.Show("Invalid quantity. Please enter an integer greater than zero.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Function for confirming buyers age - hide label and enable finalize button
        public void confirmBuyerAge()
        {
            _mainForm.confirmationLabel.Visible = false;
            _mainForm.finishButton.Enabled = true;
        }

        

        // Function to change product quantity
        public void updateProductQuantity(int newQuantity)
        {
            // Get index of selected row
            int selectedRowIndex = cashierList.SelectedCells[0].RowIndex;

            // Update quantity in selected row - in cartManagementForm
            cashierList.SelectedCells[2].Value = newQuantity;

            // Update quantity in selected row - in mainForm
            _mainForm.UpdateProductQuantity(selectedRowIndex, newQuantity);
        }

        // Function for removing products
        private void removeProduct()
        {
            if (cashierList.SelectedRows.Count > 0)
            {
                int selectedIndex = cashierList.SelectedRows[0].Index;

                //remove product fro DataGridView locally
                cashierList.Rows.RemoveAt(selectedIndex);
                cashierList.Refresh();

                //remove product in main cart
                _mainForm.RemoveProductFromCart(selectedIndex);
            }
            else
            {
                // Jeśli żaden wiersz nie jest zaznaczony, wyświetl komunikat lub podejmij odpowiednie działania
                MessageBox.Show("Select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Function for removing all prohibited products from cart
        private void removeProhibitedItems()
        {
            // Iterate thourgh all items in prohibited items list
            foreach (string productName in _mainForm.prohibitedProductsInCart.ToList())
            {
                // Double check if product is in cart
                foreach (DataGridViewRow row in cashierList.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Get row index
                        int rowIndex = row.Index;

                        // Remove item at index in both lists
                        cashierList.Rows.RemoveAt(rowIndex);
                        _mainForm.RemoveProductFromCart(rowIndex);
                    }
                }
            }
        }

        //function to copy rows from another datagridview
        private void copyDataGridView()
        {
            foreach (DataGridViewRow row in _mainForm.ListViewTest.Rows)
            {
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }
                cashierList.Rows.Add(newRow);
            }
        }

        // Function to handle CellClick in Cashier DataGridView
        private void cashierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if correct column was selected
            if (e.RowIndex >= 0)
            {
                // Get vaslues from Product and Quantity fields
                string quantity = cashierList.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                string productName = cashierList.Rows[e.RowIndex].Cells["Product"].Value.ToString();

                // Set fetched values into fields 
                textBox3.Text = quantity;
                label11.Text = productName;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            removeProduct();
        }
    }
}
