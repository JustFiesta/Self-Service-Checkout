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
            adminButton.Location = new Point(3, 4);
            adminButton.Margin = new Padding(3, 4, 3, 4);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(80, 93);
            adminButton.TabIndex = 6;
            adminButton.UseVisualStyleBackColor = false;
            // 
            // list
            // 
            list.Activation = ItemActivation.TwoClick;
            list.AutoArrange = false;
            list.BackColor = Color.RoyalBlue;
            list.Columns.AddRange(new ColumnHeader[] { column_name, column_price });
            list.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            list.HideSelection = true;
            list.Location = new Point(14, 119);
            list.Margin = new Padding(3, 4, 3, 4);
            list.MultiSelect = false;
            list.Name = "list";
            list.Scrollable = false;
            list.Size = new Size(430, 816);
            list.TabIndex = 7;
            list.UseCompatibleStateImageBehavior = false;
            list.View = View.Details;
            // 
            // column_name
            // 
            column_name.Text = "Product ";
            column_name.Width = 280;
            // 
            // column_price
            // 
            column_price.Text = "Price";
            column_price.Width = 150;
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(762, 4);
            logoBox.Margin = new Padding(3, 4, 3, 4);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(126, 147);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 8;
            logoBox.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(897, 987);
            Controls.Add(logoBox);
            Controls.Add(list);
            Controls.Add(adminButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
