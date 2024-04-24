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
        private string[] selected_item = new string[3];
        private mainForm _mainForm;

        public ProductsList(string category)
        {
            InitializeComponent();
            selectedCategory += category;
            productType.Text = selectedCategory;
            _mainForm = mainForm.Instance;
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

        //function to adding one product after double clicking
        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Sprawdzamy, czy kliknięto poprawną komórkę
            {
                DataGridViewRow selectedRow = dataView.Rows[e.RowIndex]; // Pobieramy kliknięty wiersz

                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();
                mainForm.list.Items.Add(new ListViewItem(new string[] { productName,price, "1" }));
                this.Close();
            }
        }

        //Function of adding a product via a button
        private void cardButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataView.CurrentRow;

            if (selected_item.Length != 0 && IsValidInput(maskedTextBox1.Text))
            {
                selected_item[0] = selectedRow.Cells["ProductName"].Value.ToString();
                selected_item[1] = selectedRow.Cells["Price"].Value.ToString();
                selected_item[2] = maskedTextBox1.Text; // ustawiamy ilość
                mainForm.list.Items.Add(new ListViewItem(selected_item));

                //calculating cart total amount
                _mainForm.CalculateTotalPrice();
                this.Close();
            }
        }

        // Function for validating the entered product quantity
        private bool IsValidInput(string input)
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(input) && decimal.TryParse(input, out decimal value) && value >= 0)
            {
                if (value <= 50) 
                {
                    isValid = true;
                    infoLabel.Visible = false; 
                }
                else
                {
                    infoLabel.Visible = true; 
                    infoLabel.Text = "The quantity exceeds the limit!"; 
                }
            }
            else
            {
                infoLabel.Visible = true; 
                infoLabel.Text = "Please enter a valid non-negative number!"; 
            }
            return isValid;
        }

    }
}
