namespace Bai5
{
    partial class FManageEmployee
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
            lsbDepartment = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIdNV = new TextBox();
            txtNameNV = new TextBox();
            txtBirthday = new TextBox();
            txtPhone = new TextBox();
            txtIdDepartment = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnAccept = new Button();
            btnCancel = new Button();
            btnRemove = new Button();
            dgvManageEmployee = new DataGridView();
            label7 = new Label();
            col_ID = new DataGridViewTextBoxColumn();
            col_Name = new DataGridViewTextBoxColumn();
            col_Birthday = new DataGridViewTextBoxColumn();
            col_phone = new DataGridViewTextBoxColumn();
            col_IdDepartment = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvManageEmployee).BeginInit();
            SuspendLayout();
            // 
            // lsbDepartment
            // 
            lsbDepartment.FormattingEnabled = true;
            lsbDepartment.Location = new Point(24, 59);
            lsbDepartment.Name = "lsbDepartment";
            lsbDepartment.Size = new Size(242, 264);
            lsbDepartment.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 1;
            label1.Text = "Danh sách phòng ban";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 59);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã NV :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 303);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Mã PB :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 120);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 4;
            label4.Text = "Tên NV :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 181);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày sinh :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 242);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 6;
            label6.Text = "Số ĐT :";
            // 
            // txtIdNV
            // 
            txtIdNV.Location = new Point(431, 59);
            txtIdNV.Name = "txtIdNV";
            txtIdNV.Size = new Size(279, 27);
            txtIdNV.TabIndex = 7;
            // 
            // txtNameNV
            // 
            txtNameNV.Location = new Point(431, 118);
            txtNameNV.Name = "txtNameNV";
            txtNameNV.Size = new Size(279, 27);
            txtNameNV.TabIndex = 8;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(431, 177);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(279, 27);
            txtBirthday.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(431, 236);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(279, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtIdDepartment
            // 
            txtIdDepartment.Location = new Point(431, 295);
            txtIdDepartment.Name = "txtIdDepartment";
            txtIdDepartment.Size = new Size(279, 27);
            txtIdDepartment.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 338);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(172, 338);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(320, 338);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 14;
            btnAccept.Text = "Chấp nhận";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(468, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(616, 338);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // dgvManageEmployee
            // 
            dgvManageEmployee.BackgroundColor = SystemColors.ButtonHighlight;
            dgvManageEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageEmployee.Columns.AddRange(new DataGridViewColumn[] { col_ID, col_Name, col_Birthday, col_phone, col_IdDepartment });
            dgvManageEmployee.Location = new Point(28, 416);
            dgvManageEmployee.Name = "dgvManageEmployee";
            dgvManageEmployee.RowHeadersWidth = 51;
            dgvManageEmployee.Size = new Size(682, 203);
            dgvManageEmployee.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 385);
            label7.Name = "label7";
            label7.Size = new Size(209, 28);
            label7.TabIndex = 19;
            label7.Text = "Danh sách nhân viên";
            // 
            // col_ID
            // 
            col_ID.HeaderText = "Mã nhân viên";
            col_ID.MinimumWidth = 6;
            col_ID.Name = "col_ID";
            col_ID.Width = 125;
            // 
            // col_Name
            // 
            col_Name.HeaderText = "Tên nhân viên";
            col_Name.MinimumWidth = 6;
            col_Name.Name = "col_Name";
            col_Name.Width = 125;
            // 
            // col_Birthday
            // 
            col_Birthday.HeaderText = "Ngày sinh";
            col_Birthday.MinimumWidth = 6;
            col_Birthday.Name = "col_Birthday";
            col_Birthday.Width = 125;
            // 
            // col_phone
            // 
            col_phone.HeaderText = "Số điện thoại";
            col_phone.MinimumWidth = 6;
            col_phone.Name = "col_phone";
            col_phone.Width = 125;
            // 
            // col_IdDepartment
            // 
            col_IdDepartment.HeaderText = "Mã phòng ban";
            col_IdDepartment.MinimumWidth = 6;
            col_IdDepartment.Name = "col_IdDepartment";
            col_IdDepartment.Width = 125;
            // 
            // FManageEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 648);
            Controls.Add(label7);
            Controls.Add(dgvManageEmployee);
            Controls.Add(btnRemove);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtIdDepartment);
            Controls.Add(txtPhone);
            Controls.Add(txtBirthday);
            Controls.Add(txtNameNV);
            Controls.Add(txtIdNV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lsbDepartment);
            Name = "FManageEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvManageEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtIdNV;
        private TextBox txtNameNV;
        private TextBox txtBirthday;
        private TextBox txtPhone;
        private TextBox txtIdDepartment;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnAccept;
        private Button btnCancel;
        private Button btnRemove;
        private DataGridView dgvManageEmployee;
        private Label label7;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewTextBoxColumn col_Birthday;
        private DataGridViewTextBoxColumn col_phone;
        private DataGridViewTextBoxColumn col_IdDepartment;
    }
}
