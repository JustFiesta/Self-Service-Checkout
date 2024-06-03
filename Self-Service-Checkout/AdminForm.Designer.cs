namespace Self_Service_Checkout
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            logoBox = new PictureBox();
            label1 = new Label();
            databaseButton = new Button();
            reportButton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(340, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(110, 110);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 5;
            logoBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(67, 125);
            label1.Name = "label1";
            label1.Size = new Size(653, 65);
            label1.TabIndex = 6;
            label1.Text = "Choose what you want to do";
            // 
            // databaseButton
            // 
            databaseButton.BackColor = Color.RoyalBlue;
            databaseButton.FlatAppearance.BorderColor = Color.LightBlue;
            databaseButton.FlatStyle = FlatStyle.Flat;
            databaseButton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            databaseButton.ForeColor = Color.White;
            databaseButton.Image = Properties.Resources.database;
            databaseButton.ImageAlign = ContentAlignment.MiddleLeft;
            databaseButton.Location = new Point(186, 222);
            databaseButton.Name = "databaseButton";
            databaseButton.Size = new Size(405, 143);
            databaseButton.TabIndex = 7;
            databaseButton.Text = "Database management";
            databaseButton.TextAlign = ContentAlignment.MiddleRight;
            databaseButton.UseVisualStyleBackColor = false;
            databaseButton.Click += databaseButton_Click;
            // 
            // reportButton
            // 
            reportButton.BackColor = Color.RoyalBlue;
            reportButton.FlatAppearance.BorderColor = Color.LightBlue;
            reportButton.FlatStyle = FlatStyle.Flat;
            reportButton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            reportButton.ForeColor = Color.White;
            reportButton.Image = Properties.Resources.reports;
            reportButton.ImageAlign = ContentAlignment.MiddleLeft;
            reportButton.Location = new Point(186, 405);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(405, 143);
            reportButton.TabIndex = 8;
            reportButton.Text = "Reports";
            reportButton.TextAlign = ContentAlignment.MiddleRight;
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(0, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 5);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wifi;
            pictureBox1.Location = new Point(30, 642);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(136, 689);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 11;
            label2.Text = "WiFi ON : SSC_WiFi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(569, 661);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 13;
            label3.Text = "Payment: Works";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.receipt;
            pictureBox2.Location = new Point(469, 647);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(569, 707);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 14;
            label4.Text = "Paper left: 800m";
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
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 60);
            backButton.TabIndex = 15;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(793, 748);
            Controls.Add(backButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(reportButton);
            Controls.Add(databaseButton);
            Controls.Add(label1);
            Controls.Add(logoBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoBox;
        private Label label1;
        private Button databaseButton;
        private Button reportButton;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Button backButton;
    }
}