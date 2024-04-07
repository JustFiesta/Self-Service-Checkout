using System;
using System.Drawing;
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
            e.Graphics.DrawString(e.Header.Text, new Font("Segoe UI", 25, FontStyle.Bold), Brushes.White, e.Bounds); 
        }

        // adding products with default settings
        private void list_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true; // Rysowanie elementu z domyœlnymi ustawieniami
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
        }
    }
}
