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
    public partial class CartManagementForm : Form
    {
        public CartManagementForm()
        {
            InitializeComponent();
        }

        //super special function that removes applications running in the background
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //changing the image when you hover over the button
        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.backHover;
        }
        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.delete;
        }
        private void Save_Button_MouseEnter(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.save;
        }
        //changing the image when you leave the button
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.back;
        }
        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.deleteHover;
        }
        private void SaveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.Image = Properties.Resources.saveHover;
        }

        //turning off the window after pressing the back button
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //function for checkboxes
        private void checkBoxYES_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYES.Checked)
            {
                checkBoxNO.Checked = false;
            }
        }
        private void checkBoxNO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNO.Checked)
            {
                checkBoxYES.Checked = false;
            }
        }
    }
}
