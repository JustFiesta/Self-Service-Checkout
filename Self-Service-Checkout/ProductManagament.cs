using Microsoft.EntityFrameworkCore;
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
    public partial class ProductManagament : Form
    {
        private readonly SscdbContext _context;

        public ProductManagament()
        {
            InitializeComponent();

            // Inicjalizuj kontekst w konstruktorze
            var optionsBuilder = new DbContextOptionsBuilder<SscdbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=SSCDB;Username=postgres;Password=P@ssw0rd");
            _context = new SscdbContext(optionsBuilder.Options);
        }

        // Super special function that removes applications running in the background
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Wywołaj metodę GetAllProductsAsync i wyświetl produkty
            var products = await _context.GetAllProductsAsync();
            LogProductsToConsole(products);
            DisplayProducts(products);
        }

        private void DisplayProducts(List<Product> products)
        {
            // Przykład wyświetlania produktów w kontrolce ListView
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

        // debug pulled products
        private void LogProductsToConsole(List<Product> products)
        {
            foreach (var product in products)
            {
                Debug.WriteLine($"ID: {product.Id}, Name: {product.ProductName}, Price: {product.Price}, Weight: {product.Weight}, Barcode: {product.Barcode}, Type: {product.ProductCategory}");
            }
        }


        private async void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var productName = textBoxProductName.Text;
            var price = double.Parse(textBoxPrice.Text);
            var weight = double.Parse(textBoxWeight.Text);
            var barcode = int.Parse(textBoxBarcode.Text);
            var productType = comboBoxProductType.SelectedItem.ToString();

            // Wywołaj metodę dodawania produktu
            await _context.AddProductAsync(productName, price, weight, barcode, productType);

            // Zaktualizuj wyświetlaną listę produktów
            var products = await _context.GetAllProductsAsync();
            DisplayProducts(products);
        }
    }
}
