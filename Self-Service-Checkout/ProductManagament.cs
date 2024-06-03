using Microsoft.EntityFrameworkCore;
using Self_Service_Checkout.Data;
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
    public partial class ProductManagament : Form
    {
        public ProductManagament()
        {
            InitializeComponent();
        }
        //super special function that removes applications running in the background
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tu sie dzieje magia
        }


    }
}
