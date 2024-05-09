﻿using System;
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

        public Payment(string name)
        {
            InitializeComponent();
            _mainForm = mainForm.Instance;
            RoundButton(cardButton, 20);
            RoundButton(blikButton, 20);

            if(!string.IsNullOrEmpty(name) ) 
            {
                clientNameLabel.Visible = true;
                clientNameLabel.Text = name+" !";
            }
            else
            {
                clientNameLabel.Visible = false;
            }

            decimal amount = amountToPay();
            if(LoyaltyCard.discount5)
            {
                amount = amount * 0.95M;
                amountToPayLabel.Text = amount.ToString("0.00") + "€";
            }
            else if(LoyaltyCard.discount3)
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
        private string RemoveCurrencySymbols(string text)
        {
            char[] charsToRemove = { '€',' ' };
            foreach (char c in charsToRemove)
            {
                text = text.Replace(c.ToString(), "");
            }

            return text;
        }
    }
}