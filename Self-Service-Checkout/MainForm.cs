using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Self_Service_Checkout.Models;

namespace Self_Service_Checkout
{
    public partial class mainForm : Form
    {
        public static mainForm Instance { get; private set; }
        public mainForm()
        {
            InitializeComponent();
            //special place for initialization
            this.FormClosed += mainForm_FormClosed;
            //list.ColumnWidthChanging += list_ColumnWidthChanging;
            //list.DrawColumnHeader += list_DrawColumnHeader;
            //list.DrawItem += list_DrawItem;
            //list.OwnerDraw = true;
            Instance = this;

            RoundButton(finishButton, 20);
        }
        public List<string> prohibitedProductsInCart = new List<string>();

        //super special function that removes applications running in the background
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
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
        private void barcodeButton_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            barcode.Show();
        }
        //
        //  section for forwarding the appropriate product category to display
        //
        private void vegetableButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Vegetables");
        }
        private void fruitButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Fruits");
        }
        private void breadstuffButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Breadstuff");
        }
        private void meatButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Meat products");
        }
        private void drinkButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Drinks");
        }
        private void dairyButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Milk Products");
        }
        private void sweetButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Sweet");
        }
        private void frozenfoodButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Frozen Food");
        }
        private void alcoholButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Alcohol");
        }
        private void energydrinkButton_Click(object sender, EventArgs e)
        {
            OpenProductList("Energy Drinks");
        }
        private void OpenProductList(string category)
        {
            ProductsList productsList = new ProductsList(category);
            productsList.Show();
        }

        //function for calculate total price of shopping cart
        public void CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in ListViewTest.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells[2].Value);
                decimal price = Convert.ToDecimal(row.Cells[1].Value);
                totalPrice += quantity * price;
            }
            amountLabel.Text = $"{totalPrice}€";
        }

        // Function to update quantity in main ListViewTest
        public void UpdateProductQuantity(int rowIndex, int newQuantity)
        {
            // Doublecheck row index
            if (rowIndex >= 0 && rowIndex < ListViewTest.Rows.Count)
            {
                // Update product quantity
                ListViewTest.Rows[rowIndex].Cells["Quantity"].Value = newQuantity;
            }

            UpdateCart(); // update cart
        }

        // Function to update cart state
        public void UpdateCart()
        {
            // Calculate price
            CalculateTotalPrice();

            // Refresh DataGridView
            ListViewTest.Refresh();
        }

        // Remove product at given index 
        public void RemoveProductFromCart(int index)
        {
            if (index >= 0 && index < ListViewTest.Rows.Count)
            {
                ListViewTest.Rows.RemoveAt(index);
                UpdateCart();
            }
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
