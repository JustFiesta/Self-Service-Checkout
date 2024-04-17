using Self_Service_Checkout.Data;
using Self_Service_Checkout.Models;
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

namespace Self_Service_Checkout
{
    public partial class ProductsList : Form
    {
        private string selectedCategory;
        private SscdbContext context = new SscdbContext();

        public ProductsList(string category)
        {
            InitializeComponent();
            selectedCategory += category;
            productType.Text = selectedCategory;

            dataView.DataSource = GetProducts(selectedCategory);
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


        //function to get list of products
        private List<Product> GetProducts(string cat)
        {
            List<Product> products = null;

            switch (cat)
            {
                case "Vegetables":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.vegetable select p).ToList();
                    break;
                case "Fruits":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.fruit select p).ToList();
                    break;
                case "Breadstuff":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.breadstuff select p).ToList();
                    break;
                case "Meat products":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.meat select p).ToList();
                    break;
                case "Drinks":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.drink select p).ToList();
                    break;
                case "Sweet":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.sweet select p).ToList();
                    break;
                case "Frozen Food":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.frozen_food select p).ToList();
                    break;
                case "Alcohol":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.alcohol select p).ToList();
                    break;
                case "Energy Drinks":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.energy_drink select p).ToList();
                    break;
                case "Milk Products":
                    products = (from p in context.Products where p.ProductCategory == Product_Category.dairy select p).ToList();
                    break;
                default:
                    break;
            }
            return products;
        }

        //function to view data by double-clicking specified cell
        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // check if correct cell was clicked
            {
                DataGridViewRow selectedRow = dataView.Rows[e.RowIndex]; // get clicked row

                // data from clicked row
                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                string productPrice = selectedRow.Cells["Price"].Value.ToString();
                string productBarcode = selectedRow.Cells["Barcode"].Value.ToString();

                // message content
                string message = $"Product name: {productName}\nPrice: {productPrice}\nBarcode: {productBarcode}";

                // popupwindow
                MessageBox.Show(message, "Product information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
