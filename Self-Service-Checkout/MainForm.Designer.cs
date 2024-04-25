namespace Self_Service_Checkout
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            adminButton = new Button();
            list = new ListView();
            column_name = new ColumnHeader();
            column_price = new ColumnHeader();
            column_quantity = new ColumnHeader();
            logoBox = new PictureBox();
            finishButton = new Button();
            vegetableButton = new Button();
            fruitButton = new Button();
            breadstuffButton = new Button();
            meatButton = new Button();
            drinkButton = new Button();
            dairyButton = new Button();
            sweetButton = new Button();
            frozenfoodButton = new Button();
            alcoholButton = new Button();
            energydrinkButton = new Button();
            barcodeButton = new Button();
            panel1 = new Panel();
            amountLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            confirmationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.Red;
            adminButton.BackgroundImage = Properties.Resources.admin_approve;
            adminButton.BackgroundImageLayout = ImageLayout.Zoom;
            adminButton.FlatAppearance.BorderColor = Color.LightBlue;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.Location = new Point(3, 3);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(70, 70);
            adminButton.TabIndex = 6;
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            // 
            // list
            // 
            list.Activation = ItemActivation.TwoClick;
            list.AutoArrange = false;
            list.BackColor = Color.RoyalBlue;
            list.Columns.AddRange(new ColumnHeader[] { column_name, column_price, column_quantity });
            list.Font = new Font("Segoe UI", 13.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            list.ForeColor = Color.Black;
            list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            list.HideSelection = true;
            list.Location = new Point(12, 79);
            list.MultiSelect = false;
            list.Name = "list";
            list.OwnerDraw = true;
            list.Scrollable = false;
            list.Size = new Size(390, 623);
            list.TabIndex = 7;
            list.UseCompatibleStateImageBehavior = false;
            list.View = View.Details;
            // 
            // column_name
            // 
            column_name.Text = "Product ";
            column_name.Width = 200;
            // 
            // column_price
            // 
            column_price.Text = "Price";
            column_price.Width = 80;
            // 
            // column_quantity
            // 
            column_quantity.Text = "Quantity";
            column_quantity.Width = 110;
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(667, 3);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(110, 110);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 8;
            logoBox.TabStop = false;
            // 
            // finishButton
            // 
            finishButton.BackColor = Color.RoyalBlue;
            finishButton.BackgroundImage = Properties.Resources.credit_card;
            finishButton.BackgroundImageLayout = ImageLayout.None;
            finishButton.FlatAppearance.BorderColor = Color.LightBlue;
            finishButton.FlatStyle = FlatStyle.Flat;
            finishButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            finishButton.ForeColor = Color.Transparent;
            finishButton.Location = new Point(432, 624);
            finishButton.Name = "finishButton";
            finishButton.Padding = new Padding(10, 0, 0, 0);
            finishButton.Size = new Size(219, 78);
            finishButton.TabIndex = 9;
            finishButton.Text = "Finish and pay";
            finishButton.TextAlign = ContentAlignment.MiddleRight;
            finishButton.UseVisualStyleBackColor = false;
            // 
            // vegetableButton
            // 
            vegetableButton.BackColor = Color.White;
            vegetableButton.BackgroundImage = Properties.Resources.vegetables;
            vegetableButton.BackgroundImageLayout = ImageLayout.None;
            vegetableButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            vegetableButton.FlatAppearance.BorderSize = 2;
            vegetableButton.FlatStyle = FlatStyle.Flat;
            vegetableButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            vegetableButton.Location = new Point(432, 142);
            vegetableButton.Margin = new Padding(0);
            vegetableButton.Name = "vegetableButton";
            vegetableButton.RightToLeft = RightToLeft.No;
            vegetableButton.Size = new Size(149, 75);
            vegetableButton.TabIndex = 10;
            vegetableButton.Text = "vegetables";
            vegetableButton.TextAlign = ContentAlignment.MiddleRight;
            vegetableButton.UseVisualStyleBackColor = false;
            vegetableButton.Click += vegetableButton_Click;
            // 
            // fruitButton
            // 
            fruitButton.BackColor = Color.White;
            fruitButton.BackgroundImage = Properties.Resources.fruits;
            fruitButton.BackgroundImageLayout = ImageLayout.None;
            fruitButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            fruitButton.FlatAppearance.BorderSize = 2;
            fruitButton.FlatStyle = FlatStyle.Flat;
            fruitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            fruitButton.Location = new Point(612, 142);
            fruitButton.Name = "fruitButton";
            fruitButton.Size = new Size(149, 75);
            fruitButton.TabIndex = 11;
            fruitButton.Text = "fruits";
            fruitButton.TextAlign = ContentAlignment.MiddleRight;
            fruitButton.UseVisualStyleBackColor = false;
            fruitButton.Click += fruitButton_Click;
            // 
            // breadstuffButton
            // 
            breadstuffButton.BackColor = Color.White;
            breadstuffButton.BackgroundImage = Properties.Resources.bread;
            breadstuffButton.BackgroundImageLayout = ImageLayout.None;
            breadstuffButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            breadstuffButton.FlatAppearance.BorderSize = 2;
            breadstuffButton.FlatStyle = FlatStyle.Flat;
            breadstuffButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            breadstuffButton.Location = new Point(432, 235);
            breadstuffButton.Margin = new Padding(0);
            breadstuffButton.Name = "breadstuffButton";
            breadstuffButton.RightToLeft = RightToLeft.No;
            breadstuffButton.Size = new Size(149, 75);
            breadstuffButton.TabIndex = 12;
            breadstuffButton.Text = "breadstuff";
            breadstuffButton.TextAlign = ContentAlignment.MiddleRight;
            breadstuffButton.UseVisualStyleBackColor = false;
            breadstuffButton.Click += breadstuffButton_Click;
            // 
            // meatButton
            // 
            meatButton.BackColor = Color.White;
            meatButton.BackgroundImage = Properties.Resources.meat;
            meatButton.BackgroundImageLayout = ImageLayout.None;
            meatButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            meatButton.FlatAppearance.BorderSize = 2;
            meatButton.FlatStyle = FlatStyle.Flat;
            meatButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            meatButton.Location = new Point(612, 235);
            meatButton.Margin = new Padding(0);
            meatButton.Name = "meatButton";
            meatButton.RightToLeft = RightToLeft.No;
            meatButton.Size = new Size(149, 75);
            meatButton.TabIndex = 13;
            meatButton.Text = "meat products";
            meatButton.TextAlign = ContentAlignment.MiddleRight;
            meatButton.UseVisualStyleBackColor = false;
            meatButton.Click += meatButton_Click;
            // 
            // drinkButton
            // 
            drinkButton.BackColor = Color.White;
            drinkButton.BackgroundImage = Properties.Resources.drink;
            drinkButton.BackgroundImageLayout = ImageLayout.None;
            drinkButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            drinkButton.FlatAppearance.BorderSize = 2;
            drinkButton.FlatStyle = FlatStyle.Flat;
            drinkButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            drinkButton.Location = new Point(432, 329);
            drinkButton.Margin = new Padding(0);
            drinkButton.Name = "drinkButton";
            drinkButton.RightToLeft = RightToLeft.No;
            drinkButton.Size = new Size(149, 75);
            drinkButton.TabIndex = 14;
            drinkButton.Text = "drinks";
            drinkButton.TextAlign = ContentAlignment.MiddleRight;
            drinkButton.UseVisualStyleBackColor = false;
            drinkButton.Click += drinkButton_Click;
            // 
            // dairyButton
            // 
            dairyButton.BackColor = Color.White;
            dairyButton.BackgroundImage = Properties.Resources.dairy;
            dairyButton.BackgroundImageLayout = ImageLayout.None;
            dairyButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            dairyButton.FlatAppearance.BorderSize = 2;
            dairyButton.FlatStyle = FlatStyle.Flat;
            dairyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dairyButton.Location = new Point(612, 330);
            dairyButton.Margin = new Padding(0);
            dairyButton.Name = "dairyButton";
            dairyButton.RightToLeft = RightToLeft.No;
            dairyButton.Size = new Size(149, 75);
            dairyButton.TabIndex = 15;
            dairyButton.Text = "milk products";
            dairyButton.TextAlign = ContentAlignment.MiddleRight;
            dairyButton.UseVisualStyleBackColor = false;
            dairyButton.Click += dairyButton_Click;
            // 
            // sweetButton
            // 
            sweetButton.BackColor = Color.White;
            sweetButton.BackgroundImage = Properties.Resources.sweet;
            sweetButton.BackgroundImageLayout = ImageLayout.None;
            sweetButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            sweetButton.FlatAppearance.BorderSize = 2;
            sweetButton.FlatStyle = FlatStyle.Flat;
            sweetButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            sweetButton.Location = new Point(432, 432);
            sweetButton.Margin = new Padding(0);
            sweetButton.Name = "sweetButton";
            sweetButton.RightToLeft = RightToLeft.No;
            sweetButton.Size = new Size(149, 75);
            sweetButton.TabIndex = 16;
            sweetButton.Text = "sweet";
            sweetButton.TextAlign = ContentAlignment.MiddleRight;
            sweetButton.UseVisualStyleBackColor = false;
            sweetButton.Click += sweetButton_Click;
            // 
            // frozenfoodButton
            // 
            frozenfoodButton.BackColor = Color.White;
            frozenfoodButton.BackgroundImage = Properties.Resources.frozen_food;
            frozenfoodButton.BackgroundImageLayout = ImageLayout.None;
            frozenfoodButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            frozenfoodButton.FlatAppearance.BorderSize = 2;
            frozenfoodButton.FlatStyle = FlatStyle.Flat;
            frozenfoodButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            frozenfoodButton.Location = new Point(612, 432);
            frozenfoodButton.Margin = new Padding(0);
            frozenfoodButton.Name = "frozenfoodButton";
            frozenfoodButton.RightToLeft = RightToLeft.No;
            frozenfoodButton.Size = new Size(149, 75);
            frozenfoodButton.TabIndex = 17;
            frozenfoodButton.Text = "frozen food";
            frozenfoodButton.TextAlign = ContentAlignment.MiddleRight;
            frozenfoodButton.UseVisualStyleBackColor = false;
            frozenfoodButton.Click += frozenfoodButton_Click;
            // 
            // alcoholButton
            // 
            alcoholButton.BackColor = Color.White;
            alcoholButton.BackgroundImage = Properties.Resources.alcohol;
            alcoholButton.BackgroundImageLayout = ImageLayout.None;
            alcoholButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            alcoholButton.FlatAppearance.BorderSize = 2;
            alcoholButton.FlatStyle = FlatStyle.Flat;
            alcoholButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            alcoholButton.Location = new Point(432, 533);
            alcoholButton.Margin = new Padding(0);
            alcoholButton.Name = "alcoholButton";
            alcoholButton.RightToLeft = RightToLeft.No;
            alcoholButton.Size = new Size(149, 75);
            alcoholButton.TabIndex = 18;
            alcoholButton.Text = "alcohol";
            alcoholButton.TextAlign = ContentAlignment.MiddleRight;
            alcoholButton.UseVisualStyleBackColor = false;
            alcoholButton.Click += alcoholButton_Click;
            // 
            // energydrinkButton
            // 
            energydrinkButton.BackColor = Color.White;
            energydrinkButton.BackgroundImage = Properties.Resources.energy_drink;
            energydrinkButton.BackgroundImageLayout = ImageLayout.None;
            energydrinkButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            energydrinkButton.FlatAppearance.BorderSize = 2;
            energydrinkButton.FlatStyle = FlatStyle.Flat;
            energydrinkButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            energydrinkButton.Location = new Point(612, 534);
            energydrinkButton.Margin = new Padding(0);
            energydrinkButton.Name = "energydrinkButton";
            energydrinkButton.RightToLeft = RightToLeft.No;
            energydrinkButton.Size = new Size(149, 75);
            energydrinkButton.TabIndex = 19;
            energydrinkButton.Text = "energy drink";
            energydrinkButton.TextAlign = ContentAlignment.MiddleRight;
            energydrinkButton.UseVisualStyleBackColor = false;
            energydrinkButton.Click += energydrinkButton_Click;
            // 
            // barcodeButton
            // 
            barcodeButton.BackColor = Color.Transparent;
            barcodeButton.BackgroundImage = Properties.Resources.barcode;
            barcodeButton.BackgroundImageLayout = ImageLayout.Stretch;
            barcodeButton.FlatAppearance.BorderSize = 0;
            barcodeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            barcodeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            barcodeButton.FlatStyle = FlatStyle.Flat;
            barcodeButton.Location = new Point(667, 624);
            barcodeButton.Name = "barcodeButton";
            barcodeButton.Size = new Size(80, 78);
            barcodeButton.TabIndex = 20;
            barcodeButton.TextAlign = ContentAlignment.BottomCenter;
            barcodeButton.UseVisualStyleBackColor = false;
            barcodeButton.Click += barcodeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(amountLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 664);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 38);
            panel1.TabIndex = 21;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.BackColor = Color.Transparent;
            amountLabel.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            amountLabel.ForeColor = Color.White;
            amountLabel.Location = new Point(258, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(78, 30);
            amountLabel.TabIndex = 1;
            amountLabel.Text = "0.00 €";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 0;
            label1.Text = "Amount:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(33, 656);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 5);
            panel2.TabIndex = 22;
            // 
            // confirmationLabel
            // 
            confirmationLabel.AutoSize = true;
            confirmationLabel.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            confirmationLabel.ForeColor = Color.Red;
            confirmationLabel.Location = new Point(432, 93);
            confirmationLabel.Name = "confirmationLabel";
            confirmationLabel.Size = new Size(244, 31);
            confirmationLabel.TabIndex = 23;
            confirmationLabel.Text = "Proof of age required";
            confirmationLabel.Visible = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(785, 740);
            Controls.Add(confirmationLabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(barcodeButton);
            Controls.Add(energydrinkButton);
            Controls.Add(alcoholButton);
            Controls.Add(frozenfoodButton);
            Controls.Add(sweetButton);
            Controls.Add(dairyButton);
            Controls.Add(drinkButton);
            Controls.Add(meatButton);
            Controls.Add(breadstuffButton);
            Controls.Add(fruitButton);
            Controls.Add(vegetableButton);
            Controls.Add(finishButton);
            Controls.Add(logoBox);
            Controls.Add(list);
            Controls.Add(adminButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminButton;
        private ColumnHeader column_name;
        private ColumnHeader column_price;
        private PictureBox logoBox;
        private Button finishButton;
        private Button vegetableButton;
        private Button fruitButton;
        private Button breadstuffButton;
        private Button meatButton;
        private Button drinkButton;
        private Button dairyButton;
        private Button sweetButton;
        private Button frozenfoodButton;
        private Button alcoholButton;
        private Button energydrinkButton;
        private Button barcodeButton;
        private ColumnHeader column_quantity;
        private Panel panel1;
        private Label label1;
        private Label amountLabel;
        private Panel panel2;
        private Label confirmationLabel;
        public ListView list;
    }
}
