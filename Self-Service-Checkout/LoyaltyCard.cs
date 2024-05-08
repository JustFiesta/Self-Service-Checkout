using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Checkout
{
    public partial class LoyaltyCard : Form
    {
        public LoyaltyCard()
        {
            InitializeComponent();
            RoundButton(yesButton, 20);
            RoundButton(noButton, 20);
            RoundButton(newButton, 20);
            RoundButton(confirmButton, 20);
            RoundButton(clearButton, 20);
        }

        //super special function that removes applications running in the background
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

        //changing the image when you hover over the button
        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.backHover;
        }
        //changing the image when you leave the button
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.Image = Properties.Resources.back;
        }
        //backButton action - exit current window
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        //view panel for client who have loyalty card
        private void yesButton_Click(object sender, EventArgs e)
        {
            yesPanel.Visible = true;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            phoneInput.Clear();
        }



        //view panel for client who dont have loyalty card
        private void noButton_Click(object sender, EventArgs e)
        {
            // just pay b*tch
        }




        //view panel for client who want a loyalty card
        private void newButton_Click(object sender, EventArgs e)
        {
            newPanel.Visible = true;
        }
        private void newClearButton_Click(object sender, EventArgs e)
        {
            newNameInput.Clear();
            newSurnameInput.Clear();
            newPhoneInput.Clear();
            newEmailInput.Clear();
        }
    }
}
