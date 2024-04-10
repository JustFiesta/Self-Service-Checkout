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
            barcodeLabel = new Label();
            barcodeInput = new MaskedTextBox();
            quantityInput = new MaskedTextBox();
            quantityLabel = new Label();
            logoBox = new PictureBox();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            barcodeLabel.ForeColor = Color.MidnightBlue;
            barcodeLabel.Location = new Point(46, 95);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new Size(118, 21);
            barcodeLabel.TabIndex = 0;
            barcodeLabel.Text = "enter barcode:";
            // 
            // barcodeInput
            // 
            barcodeInput.BackColor = SystemColors.ButtonFace;
            barcodeInput.BorderStyle = BorderStyle.FixedSingle;
            barcodeInput.Location = new Point(188, 95);
            barcodeInput.Name = "barcodeInput";
            barcodeInput.Size = new Size(100, 23);
            barcodeInput.TabIndex = 1;
            // 
            // quantityInput
            // 
            quantityInput.BackColor = SystemColors.ButtonFace;
            quantityInput.BorderStyle = BorderStyle.FixedSingle;
            quantityInput.Location = new Point(188, 143);
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(100, 23);
            quantityInput.TabIndex = 3;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            quantityLabel.ForeColor = Color.MidnightBlue;
            quantityLabel.Location = new Point(46, 143);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(117, 21);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "enter quantity:";
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
            // Barcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(434, 412);
            Controls.Add(backButton);
            Controls.Add(logoBox);
            Controls.Add(quantityInput);
            Controls.Add(quantityLabel);
            Controls.Add(barcodeInput);
            Controls.Add(barcodeLabel);
            Name = "Barcode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barcode";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label barcodeLabel;
        private MaskedTextBox barcodeInput;
        private MaskedTextBox quantityInput;
        private Label quantityLabel;
        private PictureBox logoBox;
        private Button backButton;
    }
}