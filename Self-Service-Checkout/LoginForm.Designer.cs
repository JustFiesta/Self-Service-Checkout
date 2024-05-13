namespace Self_Service_Checkout
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            logoBox = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            loginButton = new Button();
            backButton = new Button();
            nameInput = new TextBox();
            codeInput = new TextBox();
            clearLabel = new Label();
            showPassCheckbox = new CheckBox();
            info1Label = new Label();
            info2Label = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(309, 43);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(167, 167);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 9;
            logoBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(297, 213);
            label1.Name = "label1";
            label1.Size = new Size(188, 65);
            label1.TabIndex = 10;
            label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.person;
            pictureBox1.Location = new Point(229, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(229, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 2);
            panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.access_code;
            pictureBox2.Location = new Point(229, 438);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(229, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 2);
            panel2.TabIndex = 12;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.RoyalBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(229, 580);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(367, 54);
            loginButton.TabIndex = 13;
            loginButton.Text = "LOG IN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightBlue;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = Properties.Resources.back;
            backButton.Location = new Point(2, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 60);
            backButton.TabIndex = 14;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // nameInput
            // 
            nameInput.BackColor = Color.LightBlue;
            nameInput.BorderStyle = BorderStyle.None;
            nameInput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nameInput.ForeColor = Color.MidnightBlue;
            nameInput.Location = new Point(309, 356);
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(287, 34);
            nameInput.TabIndex = 15;
            // 
            // codeInput
            // 
            codeInput.BackColor = Color.LightBlue;
            codeInput.BorderStyle = BorderStyle.None;
            codeInput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            codeInput.ForeColor = Color.MidnightBlue;
            codeInput.Location = new Point(309, 453);
            codeInput.Multiline = true;
            codeInput.Name = "codeInput";
            codeInput.PasswordChar = '●';
            codeInput.Size = new Size(287, 34);
            codeInput.TabIndex = 16;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            clearLabel.ForeColor = Color.RoyalBlue;
            clearLabel.Location = new Point(229, 518);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(110, 25);
            clearLabel.TabIndex = 17;
            clearLabel.Text = "Clear Fields";
            clearLabel.Click += clearLabel_Click;
            // 
            // showPassCheckbox
            // 
            showPassCheckbox.AutoSize = true;
            showPassCheckbox.FlatStyle = FlatStyle.Flat;
            showPassCheckbox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline);
            showPassCheckbox.ForeColor = Color.RoyalBlue;
            showPassCheckbox.Location = new Point(418, 517);
            showPassCheckbox.Name = "showPassCheckbox";
            showPassCheckbox.Size = new Size(185, 29);
            showPassCheckbox.TabIndex = 18;
            showPassCheckbox.Text = "Show Access Code";
            showPassCheckbox.UseVisualStyleBackColor = true;
            showPassCheckbox.CheckedChanged += showPassCheckbox_CheckedChanged;
            // 
            // info1Label
            // 
            info1Label.AutoSize = true;
            info1Label.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            info1Label.ForeColor = Color.Red;
            info1Label.Location = new Point(181, 653);
            info1Label.Name = "info1Label";
            info1Label.Size = new Size(459, 59);
            info1Label.TabIndex = 19;
            info1Label.Text = "Invalid login details!";
            info1Label.Visible = false;
            // 
            // info2Label
            // 
            info2Label.AutoSize = true;
            info2Label.Font = new Font("Segoe UI Black", 32F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            info2Label.ForeColor = Color.Red;
            info2Label.Location = new Point(132, 653);
            info2Label.Name = "info2Label";
            info2Label.Size = new Size(568, 59);
            info2Label.TabIndex = 20;
            info2Label.Text = "ONLY ADMIN FUNCTION!";
            info2Label.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(789, 744);
            Controls.Add(info2Label);
            Controls.Add(info1Label);
            Controls.Add(showPassCheckbox);
            Controls.Add(clearLabel);
            Controls.Add(codeInput);
            Controls.Add(nameInput);
            Controls.Add(backButton);
            Controls.Add(loginButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button loginButton;
        private Button backButton;
        private TextBox nameInput;
        private TextBox codeInput;
        private Label clearLabel;
        private CheckBox showPassCheckbox;
        private Label info1Label;
        private Label info2Label;
    }
}