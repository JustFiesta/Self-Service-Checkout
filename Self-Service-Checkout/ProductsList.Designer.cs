namespace Self_Service_Checkout
{
    partial class ProductsList
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsList));
            panel1 = new Panel();
            label1 = new Label();
            backButton = new Button();
            logoBox = new PictureBox();
            productType = new Label();
            dataView = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            panel2 = new Panel();
            infoLabel = new Label();
            cardButton = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(logoBox);
            panel1.Controls.Add(productType);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 116);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 76);
            label1.Name = "label1";
            label1.Size = new Size(501, 25);
            label1.TabIndex = 12;
            label1.Text = "Select a product from the list and then enter the quantity";
            // 
            // backButton
            // 
            backButton.BackColor = Color.RoyalBlue;
            backButton.BackgroundImage = Properties.Resources.back;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 50);
            backButton.TabIndex = 11;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseLeave += BackButton_MouseLeave;
            backButton.MouseHover += BackButton_MouseEnter;
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(663, 0);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(110, 110);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 9;
            logoBox.TabStop = false;
            // 
            // productType
            // 
            productType.AutoSize = true;
            productType.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            productType.ForeColor = Color.White;
            productType.Location = new Point(76, 32);
            productType.Name = "productType";
            productType.Size = new Size(257, 44);
            productType.TabIndex = 2;
            productType.Text = "Product Type";
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToResizeColumns = false;
            dataView.AllowUserToResizeRows = false;
            dataView.AutoGenerateColumns = false;
            dataView.BackgroundColor = Color.LightBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Columns.AddRange(new DataGridViewColumn[] { ProductName, Price, Weight, Barcode });
            dataView.DataSource = productBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataView.DefaultCellStyle = dataGridViewCellStyle6;
            dataView.Dock = DockStyle.Fill;
            dataView.GridColor = SystemColors.MenuText;
            dataView.Location = new Point(0, 116);
            dataView.Margin = new Padding(30);
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.RowHeadersVisible = false;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(785, 624);
            dataView.TabIndex = 1;
            dataView.CellDoubleClick += dataView_CellDoubleClick;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            ProductName.HeaderText = "Product";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.DataPropertyName = "Price";
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            Price.DefaultCellStyle = dataGridViewCellStyle3;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            Weight.DefaultCellStyle = dataGridViewCellStyle4;
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // Barcode
            // 
            Barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Barcode.DataPropertyName = "Barcode";
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            Barcode.DefaultCellStyle = dataGridViewCellStyle5;
            Barcode.HeaderText = "Barcode";
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(infoLabel);
            panel2.Controls.Add(cardButton);
            panel2.Controls.Add(maskedTextBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 649);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 91);
            panel2.TabIndex = 2;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            infoLabel.ForeColor = Color.White;
            infoLabel.Location = new Point(291, 36);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(58, 21);
            infoLabel.TabIndex = 14;
            infoLabel.Text = "label3";
            infoLabel.Visible = false;
            // 
            // cardButton
            // 
            cardButton.BackColor = Color.Transparent;
            cardButton.BackgroundImage = Properties.Resources.card;
            cardButton.BackgroundImageLayout = ImageLayout.Center;
            cardButton.FlatAppearance.BorderColor = Color.White;
            cardButton.FlatAppearance.BorderSize = 4;
            cardButton.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            cardButton.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            cardButton.FlatStyle = FlatStyle.Flat;
            cardButton.Location = new Point(649, 8);
            cardButton.Name = "cardButton";
            cardButton.Size = new Size(80, 80);
            cardButton.TabIndex = 13;
            cardButton.UseVisualStyleBackColor = false;
            cardButton.Click += cardButton_Click;
            cardButton.MouseLeave += cardButton_MouseLeave;
            cardButton.MouseHover += cardButton_MouseEnter;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.AccessibleRole = AccessibleRole.None;
            maskedTextBox1.BackColor = Color.LightBlue;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 14F);
            maskedTextBox1.Location = new Point(225, 34);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(60, 32);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 29);
            label2.Name = "label2";
            label2.Size = new Size(205, 37);
            label2.TabIndex = 0;
            label2.Text = "Enter quantity: ";
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(785, 740);
            Controls.Add(panel2);
            Controls.Add(dataView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label productType;
        private DataGridView dataView;
        private PictureBox logoBox;
        private Button backButton;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Button cardButton;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Barcode;
        private Label infoLabel;
    }
}