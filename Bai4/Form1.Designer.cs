namespace Bai4
{
    partial class FManageFaculty
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdFaculty = new TextBox();
            txtTotalFaculty = new TextBox();
            txtNameFaculty = new TextBox();
            dgvInforFaculty = new DataGridView();
            col_IdFaculty = new DataGridViewTextBoxColumn();
            col_NameFaculty = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInforFaculty).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(305, 21);
            label1.Name = "label1";
            label1.Size = new Size(185, 31);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHOA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 76);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã khoa :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 76);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khoa :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 130);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Tổng khoa :";
            // 
            // txtIdFaculty
            // 
            txtIdFaculty.Location = new Point(153, 73);
            txtIdFaculty.Name = "txtIdFaculty";
            txtIdFaculty.ReadOnly = true;
            txtIdFaculty.Size = new Size(194, 27);
            txtIdFaculty.TabIndex = 4;
            // 
            // txtTotalFaculty
            // 
            txtTotalFaculty.Location = new Point(153, 127);
            txtTotalFaculty.Name = "txtTotalFaculty";
            txtTotalFaculty.ReadOnly = true;
            txtTotalFaculty.Size = new Size(194, 27);
            txtTotalFaculty.TabIndex = 5;
            // 
            // txtNameFaculty
            // 
            txtNameFaculty.Location = new Point(453, 76);
            txtNameFaculty.Name = "txtNameFaculty";
            txtNameFaculty.ReadOnly = true;
            txtNameFaculty.Size = new Size(277, 27);
            txtNameFaculty.TabIndex = 6;
            // 
            // dgvInforFaculty
            // 
            dgvInforFaculty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforFaculty.Columns.AddRange(new DataGridViewColumn[] { col_IdFaculty, col_NameFaculty });
            dgvInforFaculty.Location = new Point(63, 194);
            dgvInforFaculty.Name = "dgvInforFaculty";
            dgvInforFaculty.RowHeadersWidth = 51;
            dgvInforFaculty.Size = new Size(667, 334);
            dgvInforFaculty.TabIndex = 7;
            dgvInforFaculty.CellClick += dgvInforFaculty_CellClick;
            // 
            // col_IdFaculty
            // 
            col_IdFaculty.DataPropertyName = "makhoa";
            col_IdFaculty.HeaderText = "Mã Khoa";
            col_IdFaculty.MinimumWidth = 6;
            col_IdFaculty.Name = "col_IdFaculty";
            col_IdFaculty.Width = 125;
            // 
            // col_NameFaculty
            // 
            col_NameFaculty.DataPropertyName = "tenkhoa";
            col_NameFaculty.HeaderText = "Tên Khoa";
            col_NameFaculty.MinimumWidth = 6;
            col_NameFaculty.Name = "col_NameFaculty";
            col_NameFaculty.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(63, 537);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(177, 537);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(291, 537);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(405, 537);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(519, 537);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(633, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FManageFaculty
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 578);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvInforFaculty);
            Controls.Add(txtNameFaculty);
            Controls.Add(txtTotalFaculty);
            Controls.Add(txtIdFaculty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FManageFaculty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khoa";
            Load += FManageFaculty_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInforFaculty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdFaculty;
        private TextBox txtTotalFaculty;
        private TextBox txtNameFaculty;
        private DataGridView dgvInforFaculty;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
        private Button btnSave;
        private Button btnCancel;
        private Button btnExit;
        private DataGridViewTextBoxColumn col_IdFaculty;
        private DataGridViewTextBoxColumn col_NameFaculty;
    }
}
