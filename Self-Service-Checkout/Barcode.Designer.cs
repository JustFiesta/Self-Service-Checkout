namespace Self_Service_Checkout
{
    partial class Barcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode));
            label1 = new Label();
            barcodeInput = new MaskedTextBox();
            quantityInput = new MaskedTextBox();
            label2 = new Label();
            logoBox = new PictureBox();
            backButton = new Button();
            infoLabel = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(46, 122);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 0;
            label1.Text = "enter barcode:";
            // 
            // barcodeInput
            // 
            barcodeInput.BackColor = SystemColors.ButtonFace;
            barcodeInput.BorderStyle = BorderStyle.FixedSingle;
            barcodeInput.Font = new Font("Segoe UI", 16F);
            barcodeInput.Location = new Point(225, 120);
            barcodeInput.Name = "barcodeInput";
            barcodeInput.Size = new Size(100, 36);
            barcodeInput.TabIndex = 1;
            // 
            // quantityInput
            // 
            quantityInput.BackColor = SystemColors.ButtonFace;
            quantityInput.BorderStyle = BorderStyle.FixedSingle;
            quantityInput.Font = new Font("Segoe UI", 16F);
            quantityInput.Location = new Point(225, 176);
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(100, 36);
            quantityInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(46, 176);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 2;
            label2.Text = "enter quantity:";
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(323, 6);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(110, 110);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 9;
            logoBox.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightBlue;
            backButton.BackgroundImage = Properties.Resources.back;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 50);
            backButton.TabIndex = 10;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            infoLabel.ForeColor = Color.Red;
            infoLabel.Location = new Point(46, 241);
            infoLabel.MaximumSize = new Size(335, 300);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(335, 30);
            infoLabel.TabIndex = 11;
            infoLabel.Text = "Label that will display messages!";
            infoLabel.Visible = false;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.RoyalBlue;
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(46, 324);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(146, 76);
            confirmButton.TabIndex = 12;
            confirmButton.Text = "CONFIRM";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.RoyalBlue;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(225, 324);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(146, 76);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // Barcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(434, 412);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(infoLabel);
            Controls.Add(backButton);
            Controls.Add(logoBox);
            Controls.Add(quantityInput);
            Controls.Add(label2);
            Controls.Add(barcodeInput);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Barcode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox barcodeInput;
        private MaskedTextBox quantityInput;
        private Label label2;
        private PictureBox logoBox;
        private Button backButton;
        private Label infoLabel;
        private Button confirmButton;
        private Button cancelButton;
    }
}