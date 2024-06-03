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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            listViewProducts.FullRowSelect = true;
            listViewProducts.GridLines = true;
            listViewProducts.Location = new Point(45, 43);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(798, 574);
            listViewProducts.TabIndex = 0;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(45, 673);
            button1.Name = "button1";
            button1.Size = new Size(142, 75);
            button1.TabIndex = 0;
            button1.Text = "dodaj produkt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(331, 664);
            button2.Name = "button2";
            button2.Size = new Size(154, 92);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(689, 664);
            button3.Name = "button3";
            button3.Size = new Size(154, 92);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // ProductManagament
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 753);
            Controls.Add(textBoxProductName);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxBarcode);
            Controls.Add(comboBoxProductType);
            Controls.Add(buttonAddProduct);
            Controls.Add(listViewProducts);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ProductManagament";
            Text = "ProductManagament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}