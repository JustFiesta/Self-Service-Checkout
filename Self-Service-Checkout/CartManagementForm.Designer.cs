namespace Self_Service_Checkout
{
    partial class CartManagementForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartManagementForm));
            panel1 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            saveButton = new PictureBox();
            deleteButton = new PictureBox();
            panel12 = new Panel();
            panel11 = new Panel();
            textBox3 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel10 = new Panel();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel8 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            productLabel = new Label();
            label5 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            backButton = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            cashierList = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label4 = new Label();
            checkBoxNO = new CheckBox();
            checkBoxYES = new CheckBox();
            label1 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saveButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteButton).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashierList).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(productLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 637);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 111);
            panel1.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RoyalBlue;
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(textBox2);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(793, 111);
            panel7.TabIndex = 19;
            // 
            // panel9
            // 
            panel9.BackColor = Color.RoyalBlue;
            panel9.Controls.Add(saveButton);
            panel9.Controls.Add(deleteButton);
            panel9.Controls.Add(panel12);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(textBox3);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(label12);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(793, 111);
            panel9.TabIndex = 19;
            // 
            // saveButton
            // 
            saveButton.Image = Properties.Resources.saveHover;
            saveButton.Location = new Point(678, 19);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(80, 80);
            saveButton.SizeMode = PictureBoxSizeMode.Zoom;
            saveButton.TabIndex = 21;
            saveButton.TabStop = false;
            saveButton.Click += saveButton_Click;
            saveButton.MouseEnter += Save_Button_MouseEnter;
            saveButton.MouseLeave += SaveButton_MouseLeave;
            // 
            // deleteButton
            // 
            deleteButton.Image = Properties.Resources.deleteHover;
            deleteButton.Location = new Point(566, 19);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(80, 80);
            deleteButton.SizeMode = PictureBoxSizeMode.Zoom;
            deleteButton.TabIndex = 20;
            deleteButton.TabStop = false;
            deleteButton.Click += deleteButton_Click;
            deleteButton.MouseEnter += DeleteButton_MouseEnter;
            deleteButton.MouseLeave += DeleteButton_MouseLeave;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Location = new Point(304, 71);
            panel12.Name = "panel12";
            panel12.Size = new Size(210, 2);
            panel12.TabIndex = 19;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(12, 71);
            panel11.Name = "panel11";
            panel11.Size = new Size(255, 2);
            panel11.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.RoyalBlue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Black", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(408, 42);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 31);
            textBox3.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.ForeColor = Color.White;
            label10.Location = new Point(304, 42);
            label10.Name = "label10";
            label10.Size = new Size(109, 31);
            label10.TabIndex = 17;
            label10.Text = "Quantity:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.ForeColor = Color.White;
            label11.Location = new Point(177, 42);
            label11.Name = "label11";
            label11.Size = new Size(20, 31);
            label11.TabIndex = 16;
            label11.Text = " ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.ForeColor = Color.White;
            label12.Location = new Point(12, 42);
            label12.Name = "label12";
            label12.Size = new Size(176, 31);
            label12.TabIndex = 15;
            label12.Text = "Product Name: ";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(801, 5);
            panel10.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(408, 42);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 31);
            textBox2.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(304, 42);
            label7.Name = "label7";
            label7.Size = new Size(109, 31);
            label7.TabIndex = 17;
            label7.Text = "Quantity:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.White;
            label8.Location = new Point(177, 42);
            label8.Name = "label8";
            label8.Size = new Size(90, 31);
            label8.TabIndex = 16;
            label8.Text = "Banana";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 42);
            label9.Name = "label9";
            label9.Size = new Size(176, 31);
            label9.TabIndex = 15;
            label9.Text = "Product Name: ";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(801, 5);
            panel8.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(304, 42);
            label6.Name = "label6";
            label6.Size = new Size(109, 31);
            label6.TabIndex = 17;
            label6.Text = "Quantity:";
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            productLabel.ForeColor = Color.White;
            productLabel.Location = new Point(177, 42);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(90, 31);
            productLabel.TabIndex = 16;
            productLabel.Text = "Banana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 42);
            label5.Name = "label5";
            label5.Size = new Size(176, 31);
            label5.TabIndex = 15;
            label5.Text = "Product Name: ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(801, 5);
            panel5.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 111);
            panel2.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(0, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(793, 5);
            panel4.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 76);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 12;
            // 
            // backButton
            // 
            backButton.BackColor = Color.RoyalBlue;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = Properties.Resources.back;
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 50);
            backButton.TabIndex = 11;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(663, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 110);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 32);
            label3.Name = "label3";
            label3.Size = new Size(355, 44);
            label3.TabIndex = 2;
            label3.Text = "Cart Management";
            // 
            // cashierList
            // 
            cashierList.AllowUserToAddRows = false;
            cashierList.AllowUserToDeleteRows = false;
            cashierList.AllowUserToResizeColumns = false;
            cashierList.AllowUserToResizeRows = false;
            cashierList.BackgroundColor = Color.LightBlue;
            cashierList.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            cashierList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            cashierList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierList.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Quantity });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            cashierList.DefaultCellStyle = dataGridViewCellStyle2;
            cashierList.Dock = DockStyle.Left;
            cashierList.GridColor = SystemColors.MenuText;
            cashierList.Location = new Point(0, 111);
            cashierList.Margin = new Padding(30);
            cashierList.Name = "cashierList";
            cashierList.ReadOnly = true;
            cashierList.RowHeadersVisible = false;
            cashierList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cashierList.Size = new Size(593, 526);
            cashierList.TabIndex = 14;
            cashierList.CellClick += cashierList_CellClick;
            // 
            // Product
            // 
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Product.FillWeight = 150F;
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(checkBoxNO);
            panel3.Controls.Add(checkBoxYES);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(593, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 526);
            panel3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 483);
            label4.MaximumSize = new Size(190, 150);
            label4.Name = "label4";
            label4.Size = new Size(185, 40);
            label4.TabIndex = 18;
            label4.Text = "Selling alcohol to minors may result in imprisonment";
            // 
            // checkBoxNO
            // 
            checkBoxNO.AutoSize = true;
            checkBoxNO.FlatStyle = FlatStyle.Flat;
            checkBoxNO.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            checkBoxNO.ForeColor = Color.White;
            checkBoxNO.Location = new Point(33, 216);
            checkBoxNO.Name = "checkBoxNO";
            checkBoxNO.Size = new Size(71, 44);
            checkBoxNO.TabIndex = 17;
            checkBoxNO.Text = "No";
            checkBoxNO.UseVisualStyleBackColor = true;
            checkBoxNO.CheckedChanged += checkBoxNO_CheckedChanged;
            // 
            // checkBoxYES
            // 
            checkBoxYES.AutoSize = true;
            checkBoxYES.FlatStyle = FlatStyle.Flat;
            checkBoxYES.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            checkBoxYES.ForeColor = Color.White;
            checkBoxYES.Location = new Point(33, 157);
            checkBoxYES.Name = "checkBoxYES";
            checkBoxYES.Size = new Size(77, 44);
            checkBoxYES.TabIndex = 16;
            checkBoxYES.Text = "Yes";
            checkBoxYES.UseVisualStyleBackColor = true;
            checkBoxYES.CheckedChanged += checkBoxYES_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 107);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 15;
            label1.Text = "Confirm age?";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 526);
            panel6.TabIndex = 0;
            // 
            // CartManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(793, 748);
            Controls.Add(panel3);
            Controls.Add(cashierList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saveButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashierList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button backButton;
        private PictureBox pictureBox2;
        private Label label3;
        private DataGridView cashierList;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Label label1;
        private CheckBox checkBoxNO;
        private CheckBox checkBoxYES;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
        private Label productLabel;
        private Label label5;
        private Panel panel7;
        private Panel panel9;
        private Panel panel12;
        private Panel panel11;
        private TextBox textBox3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel10;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel8;
        private PictureBox deleteButton;
        private PictureBox saveButton;
    }
}