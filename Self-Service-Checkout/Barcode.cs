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
    public partial class Barcode : Form
    {
        public Barcode()
        {
            InitializeComponent();
        }

        //super special function that removes applications running in the background
        private void barcode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            // Zmiana obrazka przycisku na wersję "hover" przy najechaniu myszką
            backButton.Image = Properties.Resources.backHover;

        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            // Powrót do domyślnego obrazka przycisku po zjechaniu myszką
            backButton.Image = Properties.Resources.back;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
