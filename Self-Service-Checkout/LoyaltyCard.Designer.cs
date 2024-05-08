namespace Self_Service_Checkout
{
    partial class LoyaltyCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoyaltyCard));
            logoBox = new PictureBox();
            label1 = new Label();
            yesButton = new Button();
            noButton = new Button();
            newButton = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(668, 0);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(120, 120);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 9;
            logoBox.TabStop = false;
            logoBox.Click += logoBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(85, 184);
            label1.Name = "label1";
            label1.Size = new Size(647, 65);
            label1.TabIndex = 10;
            label1.Text = "Do you have a loyalty card?";
            // 
            // yesButton
            // 
            yesButton.BackColor = Color.RoyalBlue;
            yesButton.FlatAppearance.BorderColor = Color.LightBlue;
            yesButton.FlatStyle = FlatStyle.Flat;
            yesButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            yesButton.ForeColor = Color.Transparent;
            yesButton.Location = new Point(192, 270);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(178, 76);
            yesButton.TabIndex = 11;
            yesButton.Text = "YES";
            yesButton.UseVisualStyleBackColor = false;
            // 
            // noButton
            // 
            noButton.BackColor = Color.RoyalBlue;
            noButton.FlatAppearance.BorderColor = Color.LightBlue;
            noButton.FlatStyle = FlatStyle.Flat;
            noButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            noButton.ForeColor = Color.Transparent;
            noButton.Location = new Point(428, 270);
            noButton.Name = "noButton";
            noButton.Size = new Size(178, 76);
            noButton.TabIndex = 12;
            noButton.Text = "NO";
            noButton.UseVisualStyleBackColor = false;
            // 
            // newButton
            // 
            newButton.BackColor = Color.RoyalBlue;
            newButton.FlatAppearance.BorderColor = Color.LightBlue;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            newButton.ForeColor = Color.Transparent;
            newButton.Location = new Point(192, 366);
            newButton.Name = "newButton";
            newButton.Size = new Size(414, 76);
            newButton.TabIndex = 13;
            newButton.Text = "I want to set up a loyalty card";
            newButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(95, 664);
            label2.Name = "label2";
            label2.Size = new Size(564, 25);
            label2.TabIndex = 14;
            label2.Text = "The loyalty card entitles you to a 3% discount on each purchase.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(106, 689);
            label3.Name = "label3";
            label3.Size = new Size(541, 25);
            label3.TabIndex = 15;
            label3.Text = "Creating a loyalty card gives you a 5% discount on your start!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.discount;
            pictureBox1.Location = new Point(653, 646);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightBlue;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.ControlText;
            backButton.Image = Properties.Resources.back;
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 50);
            backButton.TabIndex = 17;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // LoyaltyCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(789, 744);
            Controls.Add(backButton);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(newButton);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(label1);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoyaltyCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoBox;
        private Label label1;
        private Button yesButton;
        private Button noButton;
        private Button newButton;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button backButton;
    }
}