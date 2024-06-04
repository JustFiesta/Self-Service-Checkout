namespace Self_Service_Checkout
{
    partial class ProductManagament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagament));
            textBoxProductName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxWeight = new TextBox();
            textBoxBarcode = new TextBox();
            comboBoxProductType = new ComboBox();
            buttonAddProduct = new Button();
            listViewProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            buttonUpdateProduct = new Button();
            buttonDeleteProduct = new Button();
            textBoxProductId = new TextBox();
            button1 = new Button();
            buttonSearchById = new Button();
            logoBox = new PictureBox();
            clearLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxProductName.Location = new Point(35, 633);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Product Name";
            textBoxProductName.Size = new Size(100, 25);
            textBoxProductName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 9.75F);
            textBoxPrice.Location = new Point(155, 633);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Price";
            textBoxPrice.Size = new Size(100, 25);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Segoe UI", 9.75F);
            textBoxWeight.Location = new Point(278, 633);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.PlaceholderText = "Weight";
            textBoxWeight.Size = new Size(100, 25);
            textBoxWeight.TabIndex = 3;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Font = new Font("Segoe UI", 9.75F);
            textBoxBarcode.Location = new Point(402, 633);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.PlaceholderText = "Barcode";
            textBoxBarcode.Size = new Size(100, 25);
            textBoxBarcode.TabIndex = 4;
            // 
            // comboBoxProductType
            // 
            comboBoxProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductType.FormattingEnabled = true;
            comboBoxProductType.Items.AddRange(new object[] { "fruit", "vegetable", "breadstuff", "meat", "drink", "dairy", "sweet", "frozen_food", "alcohol", "energy_drink" });
            comboBoxProductType.Location = new Point(518, 635);
            comboBoxProductType.Name = "comboBoxProductType";
            comboBoxProductType.Size = new Size(121, 23);
            comboBoxProductType.TabIndex = 5;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = Color.DarkGreen;
            buttonAddProduct.FlatAppearance.BorderSize = 0;
            buttonAddProduct.FlatStyle = FlatStyle.Flat;
            buttonAddProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonAddProduct.ForeColor = Color.White;
            buttonAddProduct.Location = new Point(406, 682);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(115, 58);
            buttonAddProduct.TabIndex = 6;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = false;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewProducts.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listViewProducts.FullRowSelect = true;
            listViewProducts.Location = new Point(28, 85);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(733, 532);
            listViewProducts.TabIndex = 7;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            listViewProducts.SelectedIndexChanged += listViewProducts_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Product name";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Weight";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Barcode";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "type";
            columnHeader6.Width = 100;
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.BackColor = Color.RoyalBlue;
            buttonUpdateProduct.FlatAppearance.BorderSize = 0;
            buttonUpdateProduct.FlatStyle = FlatStyle.Flat;
            buttonUpdateProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonUpdateProduct.ForeColor = Color.White;
            buttonUpdateProduct.Location = new Point(269, 682);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(115, 58);
            buttonUpdateProduct.TabIndex = 9;
            buttonUpdateProduct.Text = "Save";
            buttonUpdateProduct.UseVisualStyleBackColor = false;
            buttonUpdateProduct.Click += buttonUpdateProduct_Click;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.BackColor = Color.Red;
            buttonDeleteProduct.FlatAppearance.BorderSize = 0;
            buttonDeleteProduct.FlatStyle = FlatStyle.Flat;
            buttonDeleteProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            buttonDeleteProduct.ForeColor = Color.White;
            buttonDeleteProduct.Location = new Point(670, 682);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(115, 58);
            buttonDeleteProduct.TabIndex = 10;
            buttonDeleteProduct.Text = "Delete";
            buttonDeleteProduct.UseVisualStyleBackColor = false;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // textBoxProductId
            // 
            textBoxProductId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxProductId.Location = new Point(269, 21);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.PlaceholderText = "id";
            textBoxProductId.Size = new Size(100, 33);
            textBoxProductId.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 682);
            button1.Name = "button1";
            button1.Size = new Size(115, 58);
            button1.TabIndex = 13;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonSearchById
            // 
            buttonSearchById.BackColor = Color.RoyalBlue;
            buttonSearchById.FlatAppearance.BorderSize = 0;
            buttonSearchById.FlatStyle = FlatStyle.Flat;
            buttonSearchById.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSearchById.ForeColor = Color.White;
            buttonSearchById.Location = new Point(390, 5);
            buttonSearchById.Name = "buttonSearchById";
            buttonSearchById.Size = new Size(144, 63);
            buttonSearchById.TabIndex = 14;
            buttonSearchById.Text = "Search";
            buttonSearchById.UseVisualStyleBackColor = false;
            buttonSearchById.Click += buttonSearchById_Click;
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(695, 1);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(90, 90);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 15;
            logoBox.TabStop = false;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            clearLabel.ForeColor = Color.RoyalBlue;
            clearLabel.Location = new Point(661, 633);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(110, 25);
            clearLabel.TabIndex = 18;
            clearLabel.Text = "Clear Fields";
            clearLabel.Click += clearLabel_Click;
            // 
            // ProductManagament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(797, 752);
            Controls.Add(clearLabel);
            Controls.Add(listViewProducts);
            Controls.Add(logoBox);
            Controls.Add(buttonSearchById);
            Controls.Add(button1);
            Controls.Add(textBoxProductId);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(textBoxProductName);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxBarcode);
            Controls.Add(comboBoxProductType);
            Controls.Add(buttonAddProduct);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductManagament";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Button buttonAddProduct;
        private ListView listViewProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button buttonUpdateProduct;
        private Button buttonDeleteProduct;
        private ColumnHeader columnHeader6;
        private TextBox textBoxProductId;
        private Button button1;
        private Button buttonSearchById;
        private PictureBox logoBox;
        private Label clearLabel;
    }
}