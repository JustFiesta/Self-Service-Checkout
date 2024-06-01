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


        //function for employee login validation
        private void loginButton_Click(object sender, EventArgs e)
        {
            //creating new context - db connection class
            SscdbContext context = new SscdbContext();

            //checking if input fields are empty or not
            if(nameInput.Text.Equals("") || codeInput.Text.Equals(""))
            {
                //if yes, error message
                info1Label.Visible = true;
            } 
            else
            {
                //if not empty, creating null employee object for validation
                Employee employee = null;

                //try catch for parsing input fields to int32
                try
                {
                    //finding employee with given ID, if employee doesnt exist sets employee to null
                    employee = context.Employees.Find(Int32.Parse(nameInput.Text));

                    //checking if employee is null and access code is matching
                    if (employee != null && employee.AccessCode == Int32.Parse(codeInput.Text))
                    {
                        if(welcomeForm.isManagement)
                        {
                            //setting admin flag if employee type is admin
                            if (employee.employeeType.Equals("admin"))
                            {
                                LoginFlag.flag = true;
                                Debug.WriteLine("Admin logged");
                                AdminForm adminForm = new AdminForm();
                                adminForm.ShowDialog();
                                this.Close();

                                info2Label.Visible = false;
                                info1Label.Visible = false; 
                            }
                            else
                            {
                                info2Label.Visible = true;
                            }
                        }
                        else
                        {
                            //type of window you want to open after succesfull login
                            CartManagementForm cartManagementForm = new CartManagementForm();
                            cartManagementForm.ShowDialog();
                            this.Close();

                            info2Label.Visible = false;
                            info1Label.Visible = false;
                        }
                    }
                    else
                    {
                        //error if employee is null and code doesnt match
                        info1Label.Visible = true;
                    }
                } 
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    //error message if parsing make exception
                    info1Label.Visible = true;
                }
            }
        }
    }


    //proposal for login flag like this?
    public class LoginFlag
    {
        //false if no admin permission
        public static Boolean flag = false;
    }
}
