using Self_Service_Checkout.Data;
using Self_Service_Checkout.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Self_Service_Checkout
{
    public partial class Barcode : Form
    {
        private SscdbContext context = new SscdbContext();
        private mainForm _mainForm;
        public Barcode()
        {
            InitializeComponent();
            RoundButton(confirmButton, 20);
            RoundButton(cancelButton, 20);
            _mainForm = mainForm.Instance;
        }

        //super special function that removes applications running in the background
        private void barcode_FormClosed(object sender, FormClosedEventArgs e)
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

        //turning off the window after pressing the back button
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //resetting text in inputs
        private void cancelButton_Click(object sender, EventArgs e)
        {
            barcodeInput.ResetText();
            quantityInput.ResetText();
            infoLabel.Text = "";
            infoLabel.Visible = false;
        }

        //function for rounding buttons
        private void RoundButton(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(btn.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(btn.Width - radius * 2, btn.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, btn.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            btn.Region = new Region(path);
        }

        //function for adding a product using barcode
        private void confirmButton_Click(object sender, EventArgs e)
        {
            // validation and display of appropriate message
            bool isValid = ValidateInput(barcodeInput.Text, "Barcode is required", "Barcode should contain only non-negative digits", "Barcode should have 6 digits", true) &&
                           ValidateInput(quantityInput.Text, "Quantity is required", "Quantity should contain only non-negative digits", "Quantity should not exceed 50", false);
            if (!isValid) return;

            int barcode = int.Parse(barcodeInput.Text);
            int quantity = int.Parse(quantityInput.Text);

            var product = (from p in context.Products where p.Barcode == barcode select p).FirstOrDefault();
            if (product != null)
            {
                infoLabel.Visible = true;
                infoLabel.Text = $"{product.ProductName} has been added to your cart";

                //fixed adding product via barcode
                _mainForm.ListViewTest.Rows.Add(product.ProductName, product.Price, quantity);

                //calculating cart total amount
                _mainForm.CalculateTotalPrice();
            }
            else
            {
                infoLabel.Visible = true;
                infoLabel.Text = "Product not found!";
            }
        }

        //function for checking the barcodeInput and quantityInput fields
        private bool ValidateInput(string input, string requiredMessage, string digitMessage, string maxLengthMessage, bool isBarcode)
        {
            if (string.IsNullOrEmpty(input))
            {
                infoLabel.Visible = true;
                infoLabel.Text = requiredMessage;
                return false;
            }

            if (!input.All(char.IsDigit))
            {
                infoLabel.Visible = true;
                infoLabel.Text = digitMessage;
                return false;
            }

            int value;
            if (!int.TryParse(input, out value) || value < 0)
            {
                infoLabel.Visible = true;
                infoLabel.Text = digitMessage;
                return false;
            }

            if (isBarcode && input.Length != 6)
            {
                infoLabel.Visible = true;
                infoLabel.Text = maxLengthMessage;
                return false;
            }

            return true;
        }

    }
}
