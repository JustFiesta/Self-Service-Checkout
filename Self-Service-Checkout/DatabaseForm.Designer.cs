namespace Self_Service_Checkout
{
    partial class DatabaseForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            option = new ComboBox();
            label1 = new Label();
            logoBox = new PictureBox();
            backButton = new Button();
            customerDGV = new DataGridView();
            idUser = new DataGridViewTextBoxColumn();
            nameUser = new DataGridViewTextBoxColumn();
            surnameUser = new DataGridViewTextBoxColumn();
            phonenumberUser = new DataGridViewTextBoxColumn();
            emailUser = new DataGridViewTextBoxColumn();
            employeeDGV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameEmployee = new DataGridViewTextBoxColumn();
            surnameEmployee = new DataGridViewTextBoxColumn();
            phonenumberEmployee = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            employee_type = new DataGridViewTextBoxColumn();
            access_code = new DataGridViewTextBoxColumn();
            saveButton = new PictureBox();
            deleteButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saveButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteButton).BeginInit();
            SuspendLayout();
            // 
            // option
            // 
            option.DropDownStyle = ComboBoxStyle.DropDownList;
            option.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            option.FormattingEnabled = true;
            option.Items.AddRange(new object[] { "Customers", "Employees" });
            option.Location = new Point(399, 39);
            option.Name = "option";
            option.Size = new Size(200, 40);
            option.TabIndex = 0;
            option.SelectedIndexChanged += option_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(118, 32);
            label1.Name = "label1";
            label1.Size = new Size(267, 47);
            label1.TabIndex = 1;
            label1.Text = "Choose option:";
            // 
            // logoBox
            // 
            logoBox.BackgroundImageLayout = ImageLayout.Zoom;
            logoBox.Image = Properties.Resources.logo;
            logoBox.Location = new Point(679, 0);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(120, 120);
            logoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoBox.TabIndex = 10;
            logoBox.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightBlue;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.ControlText;
            backButton.Image = Properties.Resources.back;
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 50);
            backButton.TabIndex = 18;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            backButton.MouseEnter += BackButton_MouseEnter;
            backButton.MouseLeave += BackButton_MouseLeave;
            // 
            // customerDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            customerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            customerDGV.BackgroundColor = Color.LightBlue;
            customerDGV.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            customerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDGV.Columns.AddRange(new DataGridViewColumn[] { idUser, nameUser, surnameUser, phonenumberUser, emailUser });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            customerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            customerDGV.EnableHeadersVisualStyles = false;
            customerDGV.GridColor = Color.Black;
            customerDGV.Location = new Point(-2, 112);
            customerDGV.Name = "customerDGV";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            customerDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.LightBlue;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightBlue;
            customerDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            customerDGV.Size = new Size(801, 572);
            customerDGV.TabIndex = 19;
            customerDGV.Visible = false;
            // 
            // idUser
            // 
            idUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idUser.FillWeight = 50F;
            idUser.HeaderText = "id";
            idUser.Name = "idUser";
            // 
            // nameUser
            // 
            nameUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nameUser.FillWeight = 250F;
            nameUser.HeaderText = "name";
            nameUser.MinimumWidth = 180;
            nameUser.Name = "nameUser";
            nameUser.Width = 180;
            // 
            // surnameUser
            // 
            surnameUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surnameUser.HeaderText = "surname";
            surnameUser.Name = "surnameUser";
            // 
            // phonenumberUser
            // 
            phonenumberUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phonenumberUser.FillWeight = 80F;
            phonenumberUser.HeaderText = "phone number";
            phonenumberUser.Name = "phonenumberUser";
            // 
            // emailUser
            // 
            emailUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailUser.HeaderText = "email";
            emailUser.Name = "emailUser";
            // 
            // employeeDGV
            // 
            dataGridViewCellStyle6.BackColor = Color.LightBlue;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightBlue;
            employeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            employeeDGV.BackgroundColor = Color.LightBlue;
            employeeDGV.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            employeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            employeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, nameEmployee, surnameEmployee, phonenumberEmployee, dataGridViewTextBoxColumn5, employee_type, access_code });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.LightBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            employeeDGV.DefaultCellStyle = dataGridViewCellStyle8;
            employeeDGV.EnableHeadersVisualStyles = false;
            employeeDGV.GridColor = Color.Black;
            employeeDGV.Location = new Point(-2, 112);
            employeeDGV.Name = "employeeDGV";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LightBlue;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            employeeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.LightBlue;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightBlue;
            employeeDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            employeeDGV.Size = new Size(801, 572);
            employeeDGV.TabIndex = 20;
            employeeDGV.Visible = false;
            employeeDGV.CellValueChanged += DataGridView_CellValueChanged;
            employeeDGV.KeyDown += DataGridView_KeyDown;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 50F;
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nameEmployee
            // 
            nameEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            nameEmployee.FillWeight = 250F;
            nameEmployee.HeaderText = "name";
            nameEmployee.MinimumWidth = 120;
            nameEmployee.Name = "nameEmployee";
            nameEmployee.Width = 120;
            // 
            // surnameEmployee
            // 
            surnameEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surnameEmployee.HeaderText = "surname";
            surnameEmployee.Name = "surnameEmployee";
            // 
            // phonenumberEmployee
            // 
            phonenumberEmployee.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phonenumberEmployee.FillWeight = 80F;
            phonenumberEmployee.HeaderText = "phone number";
            phonenumberEmployee.Name = "phonenumberEmployee";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "email";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // employee_type
            // 
            employee_type.HeaderText = "type";
            employee_type.Name = "employee_type";
            // 
            // access_code
            // 
            access_code.HeaderText = "access code";
            access_code.Name = "access_code";
            // 
            // saveButton
            // 
            saveButton.Image = Properties.Resources.saveHover;
            saveButton.Location = new Point(12, 680);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(79, 73);
            saveButton.SizeMode = PictureBoxSizeMode.Zoom;
            saveButton.TabIndex = 22;
            saveButton.TabStop = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Image = Properties.Resources.deleteHover;
            deleteButton.Location = new Point(97, 680);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(83, 73);
            deleteButton.SizeMode = PictureBoxSizeMode.Zoom;
            deleteButton.TabIndex = 23;
            deleteButton.TabStop = false;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(797, 752);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(employeeDGV);
            Controls.Add(customerDGV);
            Controls.Add(backButton);
            Controls.Add(logoBox);
            Controls.Add(label1);
            Controls.Add(option);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DatabaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatabaseForm";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)saveButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox option;
        private Label label1;
        private PictureBox logoBox;
        private Button backButton;
        private DataGridView customerDGV;
        private DataGridViewTextBoxColumn idUser;
        private DataGridViewTextBoxColumn nameUser;
        private DataGridViewTextBoxColumn surnameUser;
        private DataGridViewTextBoxColumn phonenumberUser;
        private DataGridViewTextBoxColumn emailUser;
        private DataGridView employeeDGV;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameEmployee;
        private DataGridViewTextBoxColumn surnameEmployee;
        private DataGridViewTextBoxColumn phonenumberEmployee;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn employee_type;
        private DataGridViewTextBoxColumn access_code;
        private PictureBox saveButton;
        private PictureBox deleteButton;
    }
}