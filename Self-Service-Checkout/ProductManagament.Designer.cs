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
            button1 = new Button();
            buttonUpdateProduct = new Button();
            buttonDeleteProduct = new Button();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(130, 623);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Product Name";
            textBoxProductName.Size = new Size(100, 23);
            textBoxProductName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(236, 623);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Price";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(342, 623);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.PlaceholderText = "Weight";
            textBoxWeight.Size = new Size(100, 23);
            textBoxWeight.TabIndex = 3;
            // 
            // textBoxBarcode
            // 
            textBoxBarcode.Location = new Point(448, 623);
            textBoxBarcode.Name = "textBoxBarcode";
            textBoxBarcode.PlaceholderText = "Barcode";
            textBoxBarcode.Size = new Size(100, 23);
            textBoxBarcode.TabIndex = 4;
            // 
            // comboBoxProductType
            // 
            comboBoxProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductType.FormattingEnabled = true;
            comboBoxProductType.Items.AddRange(new object[] { "fruit", "vegetable", "breadstuff", "meat", "drink", "dairy", "sweet", "frozen food", "alcohol", "energy drink" });
            comboBoxProductType.Location = new Point(554, 624);
            comboBoxProductType.Name = "comboBoxProductType";
            comboBoxProductType.Size = new Size(121, 23);
            comboBoxProductType.TabIndex = 5;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(681, 623);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(75, 23);
            buttonAddProduct.TabIndex = 6;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewProducts.Location = new Point(45, 72);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(774, 545);
            listViewProducts.TabIndex = 7;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            listViewProducts.SelectedIndexChanged += listViewProducts_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(83, 697);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Wyświetl";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.Location = new Point(323, 704);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(75, 23);
            buttonUpdateProduct.TabIndex = 9;
            buttonUpdateProduct.Text = "Zapisz zmiany";
            buttonUpdateProduct.UseVisualStyleBackColor = true;
            buttonUpdateProduct.Click += buttonUpdateProduct_Click;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(621, 698);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(75, 23);
            buttonDeleteProduct.TabIndex = 10;
            buttonDeleteProduct.Text = "Usuń";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // ProductManagament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 753);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(button1);
            Controls.Add(listViewProducts);
            Controls.Add(textBoxProductName);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxBarcode);
            Controls.Add(comboBoxProductType);
            Controls.Add(buttonAddProduct);
            Name = "ProductManagament";
            Text = "ProductManagament";
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
        private Button button1;
        private Button buttonUpdateProduct;
        private Button buttonDeleteProduct;
    }
}