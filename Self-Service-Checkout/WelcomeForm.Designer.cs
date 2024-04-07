namespace Self_Service_Checkout
{
    partial class welcomeForm
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

        //mouse enter and mouse leave startButton, like a hover
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.CornflowerBlue;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackColor = Color.RoyalBlue;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            mainLabel = new Label();
            informLabel = new Label();
            welcomeLabel = new Label();
            logoBox = new PictureBox();
            startButton = new Button();
            adminButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainLabel.AutoSize = true;
            mainLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            mainLabel.ForeColor = Color.MidnightBlue;
            mainLabel.Location = new Point(51, 116);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(682, 65);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "THE CASH REGISTER IS OPEN";
            // 
            // informLabel
            // 
            informLabel.AutoSize = true;
            informLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            informLabel.Location = new Point(82, 546);
            informLabel.Name = "informLabel";
            informLabel.Size = new Size(609, 32);
            informLabel.TabIndex = 2;
            informLabel.Text = "Scan the first product or press the START button to start";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.Navy;
            welcomeLabel.Location = new Point(243, 492);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(309, 54);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Good morning!";
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(667, 3);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(110, 110);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 4;
            logoBox.TabStop = false;
            // 
            // startButton
            // 
            startButton.BackColor = Color.RoyalBlue;
            startButton.BackgroundImage = Properties.Resources.shopping_cart;
            startButton.BackgroundImageLayout = ImageLayout.None;
            startButton.FlatAppearance.BorderColor = Color.LightBlue;
            startButton.FlatAppearance.BorderSize = 2;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            startButton.ForeColor = Color.Transparent;
            startButton.Location = new Point(312, 611);
            startButton.Name = "startButton";
            startButton.Padding = new Padding(5, 0, 10, 0);
            startButton.Size = new Size(169, 99);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.TextAlign = ContentAlignment.MiddleRight;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            startButton.MouseEnter += Button_MouseEnter;
            startButton.MouseLeave += Button_MouseLeave;
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.Red;
            adminButton.BackgroundImage = Properties.Resources.admin;
            adminButton.BackgroundImageLayout = ImageLayout.Zoom;
            adminButton.FlatAppearance.BorderColor = Color.LightBlue;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.Location = new Point(3, 3);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(70, 70);
            adminButton.TabIndex = 5;
            adminButton.UseVisualStyleBackColor = false;
            // 
            // welcomeForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightBlue;
            ClientSize = new Size(789, 744);
            Controls.Add(adminButton);
            Controls.Add(logoBox);
            Controls.Add(welcomeLabel);
            Controls.Add(informLabel);
            Controls.Add(startButton);
            Controls.Add(mainLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "welcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private Label informLabel;
        private Label welcomeLabel;
        private PictureBox logoBox;
        private Button startButton;
        private Button adminButton;
    }
}