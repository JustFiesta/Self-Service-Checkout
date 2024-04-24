using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Service_Checkout
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            RoundButton(loginButton, 20);
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
        //turning off the window after pressing the back button
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //function for clear fields
        private void clearLabel_Click(object sender, EventArgs e)
        {
            nameInput.Text = "";
            codeInput.Text = "";
        }

        //function for exposure access code
        private void showPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckbox.Checked)
            {
                codeInput.PasswordChar = '\0';
            }
            else
            {
                codeInput.PasswordChar = '●';
            }
        }
        //if the data is correct - a new cart management window
        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
