using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Checkout
{
    public partial class ProductsList : Form
    {
        private string selectedCategory;

        public ProductsList(string category)
        {
            InitializeComponent();
            selectedCategory += category;
            productType.Text = selectedCategory;
        }
        //super special function that removes applications running in the background
        private void productList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //changing the image when you hover over the button
        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.backHover;
        }
        private void cardButton_MouseEnter(object sender, EventArgs e)
        {
            cardButton.Image = Properties.Resources.cardHover;
        }

        //changing the image when you leave the button
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.back;
        }
        private void cardButton_MouseLeave(object sender, EventArgs e)
        {
            cardButton.Image = Properties.Resources.card;
        }

        //turning off the window after pressing the back button
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
