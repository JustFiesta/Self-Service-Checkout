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
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(785, 740);
            Controls.Add(adminButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Self-Service-Checkout";
            ResumeLayout(false);
        }

        #endregion

        private Button adminButton;
    }
}
