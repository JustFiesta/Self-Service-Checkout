namespace Self_Service_Checkout
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            logoBox = new PictureBox();
            backButton = new Button();
            label1 = new Label();
            cardButton = new Button();
            blikButton = new Button();
            label2 = new Label();
            clientNameLabel = new Label();
            label3 = new Label();
            amountToPayLabel = new Label();
            blikPanel = new Panel();
            blikLabel = new Label();
            blikConfirmButton = new Button();
            blikInput = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            cardPanel = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            endPanel = new Panel();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            blikPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            endPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(661, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(120, 120);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 10;
            logoBox.TabStop = false;
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
            backButton.TabIndex = 18;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(72, 187);
            label1.Name = "label1";
            label1.Size = new Size(566, 65);
            label1.TabIndex = 19;
            label1.Text = "Select payment method";
            // 
            // cardButton
            // 
            cardButton.BackColor = Color.RoyalBlue;
            cardButton.FlatAppearance.BorderColor = Color.LightBlue;
            cardButton.FlatStyle = FlatStyle.Flat;
            cardButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cardButton.ForeColor = Color.White;
            cardButton.Image = Properties.Resources.credit_card;
            cardButton.ImageAlign = ContentAlignment.MiddleLeft;
            cardButton.Location = new Point(72, 296);
            cardButton.Name = "cardButton";
            cardButton.Padding = new Padding(5, 0, 5, 0);
            cardButton.Size = new Size(277, 155);
            cardButton.TabIndex = 20;
            cardButton.Text = "Card payment";
            cardButton.TextAlign = ContentAlignment.MiddleRight;
            cardButton.UseVisualStyleBackColor = false;
            cardButton.Click += cardButton_Click;
            // 
            // blikButton
            // 
            blikButton.BackColor = Color.RoyalBlue;
            blikButton.FlatAppearance.BorderColor = Color.LightBlue;
            blikButton.FlatStyle = FlatStyle.Flat;
            blikButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            blikButton.ForeColor = Color.White;
            blikButton.Image = Properties.Resources.blik_new;
            blikButton.ImageAlign = ContentAlignment.MiddleLeft;
            blikButton.Location = new Point(389, 296);
            blikButton.Name = "blikButton";
            blikButton.Padding = new Padding(5, 0, 0, 0);
            blikButton.Size = new Size(277, 155);
            blikButton.TabIndex = 21;
            blikButton.Text = "BLIK";
            blikButton.UseVisualStyleBackColor = false;
            blikButton.Click += blikButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(72, 101);
            label2.Name = "label2";
            label2.Size = new Size(148, 65);
            label2.TabIndex = 22;
            label2.Text = "Hello";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            clientNameLabel.ForeColor = Color.MidnightBlue;
            clientNameLabel.Location = new Point(235, 101);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new Size(0, 65);
            clientNameLabel.TabIndex = 23;
            clientNameLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(72, 540);
            label3.Name = "label3";
            label3.Size = new Size(394, 65);
            label3.TabIndex = 24;
            label3.Text = "Amount to pay: ";
            // 
            // amountToPayLabel
            // 
            amountToPayLabel.AutoSize = true;
            amountToPayLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            amountToPayLabel.ForeColor = Color.MidnightBlue;
            amountToPayLabel.Location = new Point(462, 540);
            amountToPayLabel.Name = "amountToPayLabel";
            amountToPayLabel.Size = new Size(0, 65);
            amountToPayLabel.TabIndex = 25;
            // 
            // blikPanel
            // 
            blikPanel.Controls.Add(blikLabel);
            blikPanel.Controls.Add(blikConfirmButton);
            blikPanel.Controls.Add(blikInput);
            blikPanel.Controls.Add(panel1);
            blikPanel.Controls.Add(pictureBox1);
            blikPanel.Controls.Add(label4);
            blikPanel.Location = new Point(59, 104);
            blikPanel.Name = "blikPanel";
            blikPanel.Size = new Size(617, 433);
            blikPanel.TabIndex = 26;
            blikPanel.Visible = false;
            // 
            // blikLabel
            // 
            blikLabel.AutoSize = true;
            blikLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            blikLabel.ForeColor = Color.Red;
            blikLabel.Location = new Point(21, 339);
            blikLabel.Name = "blikLabel";
            blikLabel.Size = new Size(416, 65);
            blikLabel.TabIndex = 28;
            blikLabel.Text = "Invalid blik code!";
            blikLabel.Visible = false;
            // 
            // blikConfirmButton
            // 
            blikConfirmButton.BackColor = Color.RoyalBlue;
            blikConfirmButton.FlatAppearance.BorderSize = 0;
            blikConfirmButton.FlatStyle = FlatStyle.Flat;
            blikConfirmButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            blikConfirmButton.ForeColor = Color.White;
            blikConfirmButton.Location = new Point(36, 244);
            blikConfirmButton.Name = "blikConfirmButton";
            blikConfirmButton.Size = new Size(309, 77);
            blikConfirmButton.TabIndex = 27;
            blikConfirmButton.Text = "CONFIRM";
            blikConfirmButton.UseVisualStyleBackColor = false;
            blikConfirmButton.Click += blikConfirmButton_Click;
            // 
            // blikInput
            // 
            blikInput.BackColor = Color.LightBlue;
            blikInput.BorderStyle = BorderStyle.None;
            blikInput.Font = new Font("Segoe UI Semibold", 29F, FontStyle.Bold, GraphicsUnit.Point, 238);
            blikInput.ForeColor = Color.MidnightBlue;
            blikInput.Location = new Point(140, 149);
            blikInput.Name = "blikInput";
            blikInput.Size = new Size(287, 52);
            blikInput.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(36, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 2);
            panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.blik_new;
            pictureBox1.Location = new Point(36, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(21, 39);
            label4.Name = "label4";
            label4.Size = new Size(453, 65);
            label4.TabIndex = 23;
            label4.Text = "Enter the blik code";
            // 
            // cardPanel
            // 
            cardPanel.Controls.Add(pictureBox3);
            cardPanel.Controls.Add(label7);
            cardPanel.Location = new Point(62, 90);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(614, 427);
            cardPanel.TabIndex = 13;
            cardPanel.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Image = Properties.Resources.payment;
            pictureBox3.Location = new Point(222, 247);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(169, 154);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(18, 94);
            label7.Name = "label7";
            label7.Size = new Size(573, 144);
            label7.TabIndex = 30;
            label7.Text = "Please place the card \r\non the terminal";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endPanel
            // 
            endPanel.Controls.Add(label6);
            endPanel.Controls.Add(pictureBox2);
            endPanel.Controls.Add(label5);
            endPanel.Location = new Point(12, 2);
            endPanel.Name = "endPanel";
            endPanel.Size = new Size(783, 721);
            endPanel.TabIndex = 29;
            endPanel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(187, 668);
            label6.Name = "label6";
            label6.Size = new Size(426, 37);
            label6.TabIndex = 12;
            label6.Text = "The receipt is being printed.....";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(660, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 50F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(29, 235);
            label5.Name = "label5";
            label5.Size = new Size(718, 178);
            label5.TabIndex = 0;
            label5.Text = "Payment completed \r\nsuccessfully";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(793, 748);
            Controls.Add(endPanel);
            Controls.Add(cardPanel);
            Controls.Add(blikPanel);
            Controls.Add(amountToPayLabel);
            Controls.Add(label3);
            Controls.Add(clientNameLabel);
            Controls.Add(label2);
            Controls.Add(blikButton);
            Controls.Add(cardButton);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            blikPanel.ResumeLayout(false);
            blikPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            endPanel.ResumeLayout(false);
            endPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoBox;
        private Button backButton;
        private Label label1;
        private Button cardButton;
        private Button blikButton;
        private Label label2;
        private Label clientNameLabel;
        private Label label3;
        private Label amountToPayLabel;
        private Panel blikPanel;
        private Label label4;
        private TextBox blikInput;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button blikConfirmButton;
        private Label blikLabel;
        private Panel endPanel;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private Panel cardPanel;
        private Label label7;
        private PictureBox pictureBox3;
    }
}