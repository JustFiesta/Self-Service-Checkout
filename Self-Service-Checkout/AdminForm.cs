﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Checkout
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            RoundButton(databaseButton, 20);
            RoundButton(reportButton, 20);
            RoundButton(transactionButton, 20);
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
        //turning off the window after pressing the back button
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatabaseForm databaseForm = new DatabaseForm();
            databaseForm.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductManagament productManagament = new ProductManagament();
            productManagament.ShowDialog();
        }

        //transaction management form
        private void transactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionManagement transactionManagement = new TransactionManagement();
            transactionManagement.ShowDialog();
        }
    }
}
