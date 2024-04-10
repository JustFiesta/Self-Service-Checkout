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
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
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
            // 
            // list
            // 
            list.Activation = ItemActivation.TwoClick;
            list.AutoArrange = false;
            list.BackColor = Color.RoyalBlue;
            list.Columns.AddRange(new ColumnHeader[] { column_name, column_price });
            list.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            list.ForeColor = Color.Black;
            list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            list.HideSelection = true;
            list.Location = new Point(12, 89);
            list.MultiSelect = false;
            list.Name = "list";
            list.OwnerDraw = true;
            list.Scrollable = false;
            list.Size = new Size(377, 613);
            list.TabIndex = 7;
            list.UseCompatibleStateImageBehavior = false;
            list.View = View.Details;
            // 
            // column_name
            // 
            column_name.Text = "Product ";
            column_name.Width = 260;
            // 
            // column_price
            // 
            column_price.Text = "Price";
            column_price.Width = 170;
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
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(785, 740);
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
            ResumeLayout(false);
        }

        #endregion

        private Button adminButton;
        private ListView list;
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
    }
}
