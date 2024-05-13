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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
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
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 676);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 72);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 676);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 5);
            panel2.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(793, 748);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoBox;
        private Label label1;
        private Button databaseButton;
        private Button reportButton;
        private Panel panel1;
        private Panel panel2;
    }
}