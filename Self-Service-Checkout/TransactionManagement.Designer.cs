namespace Self_Service_Checkout
{
    partial class TransactionManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionManagement));
            logoBox = new PictureBox();
            textBoxInputId = new TextBox();
            searchButton = new Button();
            listViewTransactions = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(675, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(110, 110);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 6;
            logoBox.TabStop = false;
            // 
            // textBoxInputId
            // 
            textBoxInputId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxInputId.Location = new Point(257, 82);
            textBoxInputId.Name = "textBoxInputId";
            textBoxInputId.PlaceholderText = "id";
            textBoxInputId.Size = new Size(100, 33);
            textBoxInputId.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.RoyalBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(386, 72);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(169, 50);
            searchButton.TabIndex = 8;
            searchButton.Text = "search by id";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // listViewTransactions
            // 
            listViewTransactions.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewTransactions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listViewTransactions.Location = new Point(97, 181);
            listViewTransactions.Name = "listViewTransactions";
            listViewTransactions.Size = new Size(596, 489);
            listViewTransactions.TabIndex = 9;
            listViewTransactions.UseCompatibleStateImageBehavior = false;
            listViewTransactions.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Total amount";
            columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Employee";
            columnHeader4.Width = 160;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightBlue;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Image = Properties.Resources.back;
            backButton.Location = new Point(3, -1);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 60);
            backButton.TabIndex = 16;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // TransactionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(797, 752);
            Controls.Add(backButton);
            Controls.Add(listViewTransactions);
            Controls.Add(searchButton);
            Controls.Add(textBoxInputId);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TransactionManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoBox;
        private TextBox textBoxInputId;
        private Button searchButton;
        private ListView listViewTransactions;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button backButton;
    }
}