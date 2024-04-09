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
            list.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            list.HideSelection = true;
            list.Location = new Point(12, 89);
            list.MultiSelect = false;
            list.Name = "list";
            list.Scrollable = false;
            list.Size = new Size(377, 613);
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
            finishButton.FlatAppearance.BorderSize = 2;
            finishButton.FlatStyle = FlatStyle.Flat;
            finishButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            finishButton.ForeColor = Color.Transparent;
            finishButton.Location = new Point(498, 607);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(227, 95);
            finishButton.TabIndex = 9;
            finishButton.Text = "Finish and pay";
            finishButton.TextAlign = ContentAlignment.MiddleRight;
            finishButton.UseVisualStyleBackColor = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(785, 740);
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
    }
}
