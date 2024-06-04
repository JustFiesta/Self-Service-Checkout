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
    public partial class ProductManagament : Form
    {
        private SscdbContext _context;

        public ProductManagament()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<SscdbContext>();
            _context = new SscdbContext(optionsBuilder.Options);

            DisplayProductsAsync();

            //round buttons
            RoundButton(button1, 20);
            RoundButton(buttonDeleteProduct, 20);
            RoundButton(buttonUpdateProduct, 20);
            RoundButton(buttonSearchById, 20);
            RoundButton(buttonAddProduct, 20);
        }

        // Super special function that removes applications running in the background
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

        // Display
        private async Task DisplayProductsAsync()
        {
            var products = await _context.GetAllProductsAsync();
            LogProductsToConsole(products);
            DisplayProducts(products);
        }

        // debug display products
        private void LogProductsToConsole(List<Product> products)
        {
            foreach (var product in products)
            {
                Debug.WriteLine($"ID: {product.Id}, Name: {product.ProductName}, Price: {product.Price}, Weight: {product.Weight}, Barcode: {product.Barcode}, Type: {product.ProductCategory}");
            }
        }

        private void DisplayProducts(List<Product> products)
        {
            listViewProducts.Items.Clear();

            foreach (var product in products)
            {
                var item = new ListViewItem(new[]
                {
                    product.Id.ToString(),
                    product.ProductName,
                    product.Price.ToString("F2"),
                    product.Weight.ToString("F2"),
                    product.Barcode.ToString(),
                    product.ProductCategory.ToString()
                });

                listViewProducts.Items.Add(item);
            }
        }

        // Refresh product list
        private async Task RefreshProductListAsync()
        {
            _context.Dispose();
            var optionsBuilder = new DbContextOptionsBuilder<SscdbContext>();
            _context = new SscdbContext(optionsBuilder.Options);

            await DisplayProductsAsync();
        }

        // Add
        private async void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var productName = textBoxProductName.Text;
                var price = double.Parse(textBoxPrice.Text);
                var weight = double.Parse(textBoxWeight.Text);
                var barcode = int.Parse(textBoxBarcode.Text);
                var productType = comboBoxProductType.SelectedItem.ToString();

                await _context.AddProductAsync(productName, price, weight, barcode, productType);

                await RefreshProductListAsync();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update
        private async void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            var selectedItemId = GetSelectedProductId();
            if (selectedItemId == null)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            try
            {
                var id = selectedItemId.Value;
                var productName = textBoxProductName.Text;
                var price = double.Parse(textBoxPrice.Text);
                var weight = double.Parse(textBoxWeight.Text);
                var barcode = int.Parse(textBoxBarcode.Text);
                var productType = comboBoxProductType.SelectedItem.ToString();

                await _context.UpdateProductAsync(id, productName, price, weight, barcode, productType);

                await RefreshProductListAsync();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete
        private async void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedItemId = GetSelectedProductId();
            if (selectedItemId == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            var confirmation = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    var productId = selectedItemId.Value;
                    await _context.DeleteProductAsync(productId);

                    await RefreshProductListAsync();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Metoda pomocnicza do pobierania ID wybranego produktu z kontrolki ListView
        private int? GetSelectedProductId()
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                return int.Parse(listViewProducts.SelectedItems[0].Text);
            }
            return null;
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                var selectedItem = listViewProducts.SelectedItems[0];
                textBoxProductName.Text = selectedItem.SubItems[1].Text;
                textBoxPrice.Text = selectedItem.SubItems[2].Text;
                textBoxWeight.Text = selectedItem.SubItems[3].Text;
                textBoxBarcode.Text = selectedItem.SubItems[4].Text;
                comboBoxProductType.SelectedItem = selectedItem.SubItems[5].Text;
            }
        }

        // search by id button action
        private async void buttonSearchById_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxProductId.Text, out int productId))
            {
                var products = await _context.GetProductByIdAsync(productId);
                DisplayProducts(products);
            }
            else
            {
                MessageBox.Show("Please enter a valid product ID.");
            }
        }

        // refresh listview
        private async void button1_Click(object sender, EventArgs e)
        {
            textBoxProductId.Text = "";
            await DisplayProductsAsync();

            // Wywołaj metodę GetAllProductsAsync i wyświetl produkty
            var products = await _context.GetAllProductsAsync();

            //Debug
            LogProductsToConsole(products);


            await RefreshProductListAsync();
        }

        //clear all fields
        private void clearLabel_Click(object sender, EventArgs e)
        {
            textBoxProductName.Text = "";
            textBoxPrice.Text = "";
            textBoxBarcode.Text = "";
            textBoxWeight.Text = "";
        }
    }
}