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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            adminButton = new Button();
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
            panel2 = new Panel();
            label1 = new Label();
            confirmationLabel = new Label();
            ListViewTest = new DataGridView();
            productBindingSource = new BindingSource(components);
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListViewTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.Red;
            adminButton.BackgroundImage = Properties.Resources.admin_approve;
            adminButton.BackgroundImageLayout = ImageLayout.Zoom;
            adminButton.FlatAppearance.BorderColor = Color.LightBlue;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.Location = new Point(12, 3);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(70, 70);
            adminButton.TabIndex = 6;
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(684, -3);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(100, 100);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 8;
            logoBox.TabStop = false;
            // 
            // finishButton
            // 
            finishButton.BackColor = Color.RoyalBlue;
            finishButton.BackgroundImageLayout = ImageLayout.None;
            finishButton.FlatAppearance.BorderColor = Color.LightBlue;
            finishButton.FlatStyle = FlatStyle.Flat;
            finishButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 238);
            finishButton.ForeColor = Color.Transparent;
            finishButton.Image = Properties.Resources.credit_card;
            finishButton.ImageAlign = ContentAlignment.MiddleLeft;
            finishButton.Location = new Point(410, 615);
            finishButton.Name = "finishButton";
            finishButton.Padding = new Padding(10, 0, 5, 0);
            finishButton.Size = new Size(266, 87);
            finishButton.TabIndex = 9;
            finishButton.Text = "Finish and pay";
            finishButton.TextAlign = ContentAlignment.MiddleRight;
            finishButton.UseVisualStyleBackColor = false;
            // 
            // vegetableButton
            // 
            vegetableButton.BackColor = Color.White;
            vegetableButton.BackgroundImageLayout = ImageLayout.None;
            vegetableButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            vegetableButton.FlatAppearance.BorderSize = 2;
            vegetableButton.FlatStyle = FlatStyle.Flat;
            vegetableButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            vegetableButton.Image = Properties.Resources.vegetables;
            vegetableButton.ImageAlign = ContentAlignment.MiddleLeft;
            vegetableButton.Location = new Point(410, 93);
            vegetableButton.Margin = new Padding(0);
            vegetableButton.Name = "vegetableButton";
            vegetableButton.RightToLeft = RightToLeft.No;
            vegetableButton.Size = new Size(176, 93);
            vegetableButton.TabIndex = 10;
            vegetableButton.Text = "vegetables";
            vegetableButton.TextAlign = ContentAlignment.MiddleRight;
            vegetableButton.UseVisualStyleBackColor = false;
            vegetableButton.Click += vegetableButton_Click;
            // 
            // fruitButton
            // 
            fruitButton.BackColor = Color.White;
            fruitButton.BackgroundImageLayout = ImageLayout.None;
            fruitButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            fruitButton.FlatAppearance.BorderSize = 2;
            fruitButton.FlatStyle = FlatStyle.Flat;
            fruitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            fruitButton.Image = Properties.Resources.fruits;
            fruitButton.ImageAlign = ContentAlignment.MiddleLeft;
            fruitButton.Location = new Point(597, 93);
            fruitButton.Name = "fruitButton";
            fruitButton.Size = new Size(176, 93);
            fruitButton.TabIndex = 11;
            fruitButton.Text = "fruits";
            fruitButton.TextAlign = ContentAlignment.MiddleRight;
            fruitButton.UseVisualStyleBackColor = false;
            fruitButton.Click += fruitButton_Click;
            // 
            // breadstuffButton
            // 
            breadstuffButton.BackColor = Color.White;
            breadstuffButton.BackgroundImageLayout = ImageLayout.None;
            breadstuffButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            breadstuffButton.FlatAppearance.BorderSize = 2;
            breadstuffButton.FlatStyle = FlatStyle.Flat;
            breadstuffButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            breadstuffButton.Image = Properties.Resources.bread;
            breadstuffButton.ImageAlign = ContentAlignment.MiddleLeft;
            breadstuffButton.Location = new Point(410, 196);
            breadstuffButton.Margin = new Padding(0);
            breadstuffButton.Name = "breadstuffButton";
            breadstuffButton.RightToLeft = RightToLeft.No;
            breadstuffButton.Size = new Size(176, 93);
            breadstuffButton.TabIndex = 12;
            breadstuffButton.Text = "breadstuff";
            breadstuffButton.TextAlign = ContentAlignment.MiddleRight;
            breadstuffButton.UseVisualStyleBackColor = false;
            breadstuffButton.Click += breadstuffButton_Click;
            // 
            // meatButton
            // 
            meatButton.BackColor = Color.White;
            meatButton.BackgroundImageLayout = ImageLayout.None;
            meatButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            meatButton.FlatAppearance.BorderSize = 2;
            meatButton.FlatStyle = FlatStyle.Flat;
            meatButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            meatButton.Image = Properties.Resources.meat;
            meatButton.ImageAlign = ContentAlignment.MiddleLeft;
            meatButton.Location = new Point(597, 196);
            meatButton.Margin = new Padding(0);
            meatButton.Name = "meatButton";
            meatButton.RightToLeft = RightToLeft.No;
            meatButton.Size = new Size(176, 93);
            meatButton.TabIndex = 13;
            meatButton.Text = "meat products";
            meatButton.TextAlign = ContentAlignment.MiddleRight;
            meatButton.UseVisualStyleBackColor = false;
            meatButton.Click += meatButton_Click;
            // 
            // drinkButton
            // 
            drinkButton.BackColor = Color.White;
            drinkButton.BackgroundImageLayout = ImageLayout.None;
            drinkButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            drinkButton.FlatAppearance.BorderSize = 2;
            drinkButton.FlatStyle = FlatStyle.Flat;
            drinkButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            drinkButton.Image = Properties.Resources.drink;
            drinkButton.ImageAlign = ContentAlignment.MiddleLeft;
            drinkButton.Location = new Point(410, 301);
            drinkButton.Margin = new Padding(0);
            drinkButton.Name = "drinkButton";
            drinkButton.RightToLeft = RightToLeft.No;
            drinkButton.Size = new Size(176, 93);
            drinkButton.TabIndex = 14;
            drinkButton.Text = "drinks";
            drinkButton.TextAlign = ContentAlignment.MiddleRight;
            drinkButton.UseVisualStyleBackColor = false;
            drinkButton.Click += drinkButton_Click;
            // 
            // dairyButton
            // 
            dairyButton.BackColor = Color.White;
            dairyButton.BackgroundImageLayout = ImageLayout.None;
            dairyButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            dairyButton.FlatAppearance.BorderSize = 2;
            dairyButton.FlatStyle = FlatStyle.Flat;
            dairyButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dairyButton.Image = Properties.Resources.dairy;
            dairyButton.ImageAlign = ContentAlignment.MiddleLeft;
            dairyButton.Location = new Point(597, 301);
            dairyButton.Margin = new Padding(0);
            dairyButton.Name = "dairyButton";
            dairyButton.RightToLeft = RightToLeft.No;
            dairyButton.Size = new Size(176, 93);
            dairyButton.TabIndex = 15;
            dairyButton.Text = "milk products";
            dairyButton.TextAlign = ContentAlignment.MiddleRight;
            dairyButton.UseVisualStyleBackColor = false;
            dairyButton.Click += dairyButton_Click;
            // 
            // sweetButton
            // 
            sweetButton.BackColor = Color.White;
            sweetButton.BackgroundImageLayout = ImageLayout.None;
            sweetButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            sweetButton.FlatAppearance.BorderSize = 2;
            sweetButton.FlatStyle = FlatStyle.Flat;
            sweetButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            sweetButton.Image = Properties.Resources.sweet;
            sweetButton.ImageAlign = ContentAlignment.MiddleLeft;
            sweetButton.Location = new Point(410, 403);
            sweetButton.Margin = new Padding(0);
            sweetButton.Name = "sweetButton";
            sweetButton.RightToLeft = RightToLeft.No;
            sweetButton.Size = new Size(176, 93);
            sweetButton.TabIndex = 16;
            sweetButton.Text = "sweet";
            sweetButton.TextAlign = ContentAlignment.MiddleRight;
            sweetButton.UseVisualStyleBackColor = false;
            sweetButton.Click += sweetButton_Click;
            // 
            // frozenfoodButton
            // 
            frozenfoodButton.BackColor = Color.White;
            frozenfoodButton.BackgroundImageLayout = ImageLayout.None;
            frozenfoodButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            frozenfoodButton.FlatAppearance.BorderSize = 2;
            frozenfoodButton.FlatStyle = FlatStyle.Flat;
            frozenfoodButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            frozenfoodButton.Image = Properties.Resources.frozen_food;
            frozenfoodButton.ImageAlign = ContentAlignment.MiddleLeft;
            frozenfoodButton.Location = new Point(597, 403);
            frozenfoodButton.Margin = new Padding(0);
            frozenfoodButton.Name = "frozenfoodButton";
            frozenfoodButton.RightToLeft = RightToLeft.No;
            frozenfoodButton.Size = new Size(176, 93);
            frozenfoodButton.TabIndex = 17;
            frozenfoodButton.Text = "frozen food";
            frozenfoodButton.TextAlign = ContentAlignment.MiddleRight;
            frozenfoodButton.UseVisualStyleBackColor = false;
            frozenfoodButton.Click += frozenfoodButton_Click;
            // 
            // alcoholButton
            // 
            alcoholButton.BackColor = Color.White;
            alcoholButton.BackgroundImageLayout = ImageLayout.None;
            alcoholButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            alcoholButton.FlatAppearance.BorderSize = 2;
            alcoholButton.FlatStyle = FlatStyle.Flat;
            alcoholButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            alcoholButton.Image = Properties.Resources.alcohol;
            alcoholButton.ImageAlign = ContentAlignment.MiddleLeft;
            alcoholButton.Location = new Point(410, 507);
            alcoholButton.Margin = new Padding(0);
            alcoholButton.Name = "alcoholButton";
            alcoholButton.RightToLeft = RightToLeft.No;
            alcoholButton.Size = new Size(176, 93);
            alcoholButton.TabIndex = 18;
            alcoholButton.Text = "alcohol";
            alcoholButton.TextAlign = ContentAlignment.MiddleRight;
            alcoholButton.UseVisualStyleBackColor = false;
            alcoholButton.Click += alcoholButton_Click;
            // 
            // energydrinkButton
            // 
            energydrinkButton.BackColor = Color.White;
            energydrinkButton.BackgroundImageLayout = ImageLayout.None;
            energydrinkButton.FlatAppearance.BorderColor = Color.RoyalBlue;
            energydrinkButton.FlatAppearance.BorderSize = 2;
            energydrinkButton.FlatStyle = FlatStyle.Flat;
            energydrinkButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 238);
            energydrinkButton.Image = Properties.Resources.energy_drink;
            energydrinkButton.ImageAlign = ContentAlignment.MiddleLeft;
            energydrinkButton.Location = new Point(597, 507);
            energydrinkButton.Margin = new Padding(0);
            energydrinkButton.Name = "energydrinkButton";
            energydrinkButton.RightToLeft = RightToLeft.No;
            energydrinkButton.Size = new Size(176, 93);
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
            barcodeButton.Location = new Point(693, 621);
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 657);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 45);
            panel1.TabIndex = 21;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.BackColor = Color.Transparent;
            amountLabel.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            amountLabel.ForeColor = Color.White;
            amountLabel.Location = new Point(256, 10);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(78, 30);
            amountLabel.TabIndex = 1;
            amountLabel.Text = "0.00 €";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(23, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 5);
            panel2.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 10);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 0;
            label1.Text = "Amount:";
            // 
            // confirmationLabel
            // 
            confirmationLabel.AutoSize = true;
            confirmationLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            confirmationLabel.ForeColor = Color.Red;
            confirmationLabel.Location = new Point(101, 32);
            confirmationLabel.Name = "confirmationLabel";
            confirmationLabel.Size = new Size(322, 41);
            confirmationLabel.TabIndex = 23;
            confirmationLabel.Text = "Proof of age required";
            confirmationLabel.Visible = false;
            // 
            // ListViewTest
            // 
            ListViewTest.AllowUserToAddRows = false;
            ListViewTest.AllowUserToDeleteRows = false;
            ListViewTest.AllowUserToResizeColumns = false;
            ListViewTest.AllowUserToResizeRows = false;
            ListViewTest.BackgroundColor = Color.RoyalBlue;
            ListViewTest.BorderStyle = BorderStyle.None;
            ListViewTest.CellBorderStyle = DataGridViewCellBorderStyle.None;
            ListViewTest.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            ListViewTest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ListViewTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ListViewTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListViewTest.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Quantity });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ListViewTest.DefaultCellStyle = dataGridViewCellStyle2;
            ListViewTest.EditMode = DataGridViewEditMode.EditProgrammatically;
            ListViewTest.Enabled = false;
            ListViewTest.EnableHeadersVisualStyles = false;
            ListViewTest.GridColor = Color.RoyalBlue;
            ListViewTest.Location = new Point(12, 93);
            ListViewTest.Name = "ListViewTest";
            ListViewTest.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ListViewTest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ListViewTest.RowHeadersVisible = false;
            ListViewTest.ScrollBars = ScrollBars.None;
            ListViewTest.Size = new Size(390, 578);
            ListViewTest.TabIndex = 24;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.FillWeight = 45F;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.FillWeight = 60F;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(785, 740);
            Controls.Add(panel1);
            Controls.Add(ListViewTest);
            Controls.Add(confirmationLabel);
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
            Controls.Add(adminButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListViewTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adminButton;
        private PictureBox logoBox;
        public Button finishButton;
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
        private Panel panel1;
        private Label label1;
        private Label amountLabel;
        private Panel panel2;
        public Label confirmationLabel;
        public DataGridView ListViewTest;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
    }
}
