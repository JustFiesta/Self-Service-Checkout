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
    public partial class TransactionManagement : Form
    {
        private SscdbContext _context;

        public TransactionManagement()
        {
            InitializeComponent();

            RoundButton(searchButton, 20);

            var optionsBuilder = new DbContextOptionsBuilder<SscdbContext>();
            _context = new SscdbContext(optionsBuilder.Options);
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


        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInputId.Text, out int customerId))
            {
                var transactions = await _context.GetTransactionByIdAsync(customerId);
                if (transactions != null && transactions.Any())
                {
                    DisplayTransaction(transactions);
                }
                else
                {
                    MessageBox.Show("No transactions found for the given customer ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid product ID.");
            }
        }

        //DISPLAY transaction by customer
        private void DisplayTransaction(List<Transaction> transactions)
        {
            listViewTransactions.Items.Clear();

            foreach (var transaction in transactions)
            {
                var item = new ListViewItem(new[]
                {
                    transaction.Id.ToString(),
                    transaction.Date.ToString(),
                    transaction.TotalAmount.ToString(),
                    transaction.EmployeesFk.ToString()

                });

                listViewTransactions.Items.Add(item);
            }
        }
    }
}
