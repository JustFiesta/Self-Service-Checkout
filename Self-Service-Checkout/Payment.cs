using Microsoft.EntityFrameworkCore;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Checkout
{
    public partial class Payment : Form
    {
        private mainForm _mainForm;
        private SscdbContext _context;
        private int? _customerId;
        public Payment(string name, int id)
        {

            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<SscdbContext>();
            _context = new SscdbContext(optionsBuilder.Options);

            _customerId = id;

            _mainForm = mainForm.Instance;
            RoundButton(cardButton, 20);
            RoundButton(blikButton, 20);
            RoundButton(blikConfirmButton, 20);

            //display the customer's name at checkout
            if (!string.IsNullOrEmpty(name))
            {
                clientNameLabel.Visible = true;
                clientNameLabel.Text = name + " !";
            }
            else
            {
                clientNameLabel.Visible = false;
            }

            //calculat discount on purchases
            //5% - new customers
            //3% - regular customers
            decimal amount = amountToPay();
            if (LoyaltyCard.discount5)
            {
                amount = amount * 0.95M;
                amountToPayLabel.Text = amount.ToString("0.00") + "€";
            }
            else if (LoyaltyCard.discount3)
            {
                amount = amount * 0.97M;
                amountToPayLabel.Text = amount.ToString("0.00") + "€";
            }
            else
            {
                amountToPayLabel.Text = amount.ToString("0.00") + "€";
            }
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

        //function for calculate amount to pay, discount too
        private decimal amountToPay()
        {
            string textValue = _mainForm.AmountLabel;
            string numericText = RemoveCurrencySymbols(textValue);
            decimal amount = decimal.Parse(numericText);
            return amount;
        }
        //function for remove currency symbol in amount - €
        private string RemoveCurrencySymbols(string text)
        {
            char[] charsToRemove = { '€', ' ' };
            foreach (char c in charsToRemove)
            {
                text = text.Replace(c.ToString(), "");
            }

            return text;
        }

        //function for pay by card 
        private void cardButton_Click(object sender, EventArgs e)
        {
            blikPanel.Visible = false;
            cardPanel.Visible = true;
            asyncForCardButton();
        }
        //excessive use of panels caused display errors
        //so I used a separate function, this way fixes this error
        private async void asyncForCardButton()
        {
            await Task.Delay(3000);
            cardPanel.Visible = false;
            endPanel.Visible = true;

            transactionSave();

            await Task.Delay(2500);
            RestartApplication();
        }

        //function for pay by blik code
        private void blikButton_Click(object sender, EventArgs e)
        {
            blikPanel.Visible = true;
        }

        //function for confirm pay, after enter blik code
        private async void blikConfirmButton_Click(object sender, EventArgs e)
        {
            string input = blikInput.Text.Trim();
            //blik code checking
            if (input.Length == 6 && IsNumeric(input))
            {
                await Task.Delay(500);
                blikPanel.Visible=false;
                cardPanel.Visible=false;
                endPanel.Visible = true;

                transactionSave();

                await Task.Delay(2500);
                RestartApplication();
            }
            else
            {
                blikLabel.Visible = true;
            }
        }

        //function to check the correctness of the blik code
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        //function to restart the application
        private void RestartApplication()
        {
            // restarting current app
            Application.Restart();
            Environment.Exit(0); // terminate current process
        }

        private void transactionSave()
        {
            Transaction transaction = new Transaction();
            transaction.TotalAmount = double.Parse(amountToPay().ToString());
            transaction.Date = DateTime.Now;
            if(_customerId == 0)
            {
                transaction.CustomerFk = null;
            } else
            {
                transaction.CustomerFk = _customerId;
            }
            transaction.EmployeesFk = LoginFlag.emploeeID;

            Debug.WriteLine(amountToPay());
            
            // Add the transaction to the context
            _context.Transactions.Add(transaction);

            // Save changes to the database
            _context.SaveChanges();
        }
    }
}
