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
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
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
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(793, 748);
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
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
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
    }
}