using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Self_Service_Checkout
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //special place for initialization
            this.FormClosed += mainForm_FormClosed;
            list.ColumnWidthChanging += list_ColumnWidthChanging;
            list.DrawColumnHeader += list_DrawColumnHeader;
            list.DrawItem += list_DrawItem;
            list.OwnerDraw = true;

            //blocking the selection of options in the list
            list.ItemSelectionChanged += (sender, e) =>
            {
                if (list.SelectedItems.Count > 0)
                {
                    list.SelectedItems[0].Selected = false;
                }
            };

            RoundButton(finishButton, 20);
            //TESTING
            AddElem();
        }

        //super special function that removes applications running in the background
        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // blocking header expansion
        private void list_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = list.Columns[e.ColumnIndex].Width;
        }
        // header font, background color
        private void list_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, new Font("Segoe UI", 17, FontStyle.Bold), Brushes.White, e.Bounds);
        }

        // adding products with default settings
        private void list_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true; // Rysowanie elementu z domyœlnymi ustawieniami
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
        // ONLY FOR TESTING !
        private void AddElem()
        {
            // Dodanie przyk³adowych elementów do listy
            string[] item1 = new string[] { "Laptop", "1000" };
            string[] item2 = new string[] { "Smartphone", "800" };
            string[] item3 = new string[] { "Tablet", "500" };
            string[] item4 = new string[] { "Potato", "10.99" };

            // Dodanie elementów do kontrolki ListView
            list.Items.Add(new ListViewItem(item1));
            list.Items.Add(new ListViewItem(item2));
            list.Items.Add(new ListViewItem(item3));
            list.Items.Add(new ListViewItem(item4));
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
            Console.WriteLine("IM HERE");
            ProductsList productsList = new ProductsList(category);
            productsList.Show();
        }
    }
}
