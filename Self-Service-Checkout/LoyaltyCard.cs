using Self_Service_Checkout.Data;
using Self_Service_Checkout.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Checkout
{
    public partial class LoyaltyCard : Form
    {
        internal string newName;
        public static bool discount3;
        public static bool discount5;

        public LoyaltyCard()
        {
            InitializeComponent();
            RoundButton(yesButton, 20);
            RoundButton(noButton, 20);
            RoundButton(newButton, 20);
            RoundButton(confirmButton, 20);
            RoundButton(clearButton, 20);
            RoundButton(newClearButton, 20);
            RoundButton(newConfirmButton, 20);
        }

        //super special function that removes applications running in the background
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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


        //view panel for client who have loyalty card
        private void yesButton_Click(object sender, EventArgs e)
        {
            yesPanel.Visible = true;
            discount3 = true;
            discount5 = false;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            discount3 = true;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            phoneInput.Clear();
        }



        //view panel for client who dont have loyalty card
        private void noButton_Click(object sender, EventArgs e)
        {
            string emptyName = "";
            discount3 = false;
            discount5 = false;
            this.Hide();
            Payment paymentForm = new Payment(emptyName);
            paymentForm.ShowDialog();
        }




        //view panel for client who want a loyalty card
        private void newButton_Click(object sender, EventArgs e)
        {
            newPanel.Visible = true;
        }
        private void newClearButton_Click(object sender, EventArgs e)
        {
            newNameInput.Clear();
            newSurnameInput.Clear();
            newPhoneInput.Clear();
            newEmailInput.Clear();
        }


        //confirm client data
        private void newConfirmButton_Click(object sender, EventArgs e)
        {
            if (validateClientData())
            {
                addClientToDB();

               //set 5% discount
                discount3 = false;
                discount5 = true;

                //clear all fields
                newClearButton.PerformClick();
                //open payment window with client name
                OpenPayment(newName);
 
            }
        }

        private bool validateClientData()
        {
            //check if inputs contains whitespace
            if (string.IsNullOrWhiteSpace(newNameInput.Text) ||
                string.IsNullOrWhiteSpace(newSurnameInput.Text) ||
                string.IsNullOrWhiteSpace(newPhoneInput.Text) ||
                string.IsNullOrWhiteSpace(newEmailInput.Text))
            {
                MessageBox.Show("Please fill all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // check if name and surname are correct
            if (ContainsDigits(newNameInput.Text) || ContainsDigits(newSurnameInput.Text))
            {
                MessageBox.Show("Name and surname should not contain digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // check if phone number is correct
            if (!IsValidPhoneNumber(newPhoneInput.Text))
            {
                MessageBox.Show("Phone namuber must contain only 9 digits and be in this format: XXX XXX XXX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // check if email address is correct
            if (!IsValidEmail(newEmailInput.Text))
            {
                MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // everything is okey
            MessageBox.Show("Clients details are correct.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        // check if there is a digit in text input
        private bool ContainsDigits(string text)
        {
            return text.Any(char.IsDigit);
        }

        // check if phone number is only digits
        private bool IsValidPhoneNumber(string phone)
        {
            phone = phone.Replace(" ", "");
            // check if only digits 
            if (!phone.All(char.IsDigit))
            {
                return false;
            }
            return phone.Length == 9 && phone.All(char.IsDigit);
        }

        //check if email input contains @ and . ???
        private bool IsValidEmail(string email)
        {
            // check if contains special characters
            return email.Contains("@") && email.Contains(".") && email.Length > 5;
        }


        //method to add " " after 3 chars
        private void newPhoneInput_TextChanged(object sender, EventArgs e)
        {
            if (newPhoneInput.Text.Length == 3)
            {
                newPhoneInput.Text += " ";
            }
            if (newPhoneInput.Text.Length == 7)
            {
                newPhoneInput.Text += " ";
            }
            newPhoneInput.SelectionStart = newPhoneInput.Text.Length;
            newPhoneInput.Focus();
        }


        //method to add new customer to db
        private void addClientToDB()
        {
            SscdbContext context = new SscdbContext();
            var newCustomer = new Customer { Name = newNameInput.Text, Surname = newSurnameInput.Text, PhoneNumber = newPhoneInput.Text, Email = newEmailInput.Text };
            context.Customers.Add(newCustomer);
            context.SaveChanges();
            newName = newNameInput.Text;
        }

        private void OpenPayment(string name)
        {
            Debug.WriteLine("discount5 FIRST: " + discount5);
            Debug.WriteLine("discount3 FIRST: " + discount3);
            this.Hide();
            Payment paymentForm = new Payment(name);
            paymentForm.ShowDialog();
        }
    }
}
