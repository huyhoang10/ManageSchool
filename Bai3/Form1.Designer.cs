namespace Bai3
{
    partial class FSearchStudent
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
            label5 = new Label();
            label6 = new Label();
            cmbMSSV = new ComboBox();
            dtpBirthday = new DateTimePicker();
            txtName = new TextBox();
            txtIdFaculty = new TextBox();
            txtSex = new TextBox();
            gdvInforSubject = new DataGridView();
            col_IdSubject = new DataGridViewTextBoxColumn();
            col_NameSubject = new DataGridViewTextBoxColumn();
            col_Score = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)gdvInforSubject).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(231, 21);
            label1.Name = "label1";
            label1.Size = new Size(370, 31);
            label1.TabIndex = 0;
            label1.Text = "TÌM KIẾM THÔNG TIN SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 80);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập Mã SV :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 142);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 80);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Họ và Tên SV:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 138);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Mã khoa :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 212);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Giới tính :";
            // 
            // cmbMSSV
            // 
            cmbMSSV.FormattingEnabled = true;
            cmbMSSV.Location = new Point(141, 78);
            cmbMSSV.Name = "cmbMSSV";
            cmbMSSV.Size = new Size(184, 28);
            cmbMSSV.TabIndex = 6;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(141, 137);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(184, 27);
            dtpBirthday.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(469, 78);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 8;
            // 
            // txtIdFaculty
            // 
            txtIdFaculty.Location = new Point(469, 135);
            txtIdFaculty.Name = "txtIdFaculty";
            txtIdFaculty.ReadOnly = true;
            txtIdFaculty.Size = new Size(214, 27);
            txtIdFaculty.TabIndex = 9;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(141, 205);
            txtSex.Name = "txtSex";
            txtSex.ReadOnly = true;
            txtSex.Size = new Size(184, 27);
            txtSex.TabIndex = 10;
            // 
            // gdvInforSubject
            // 
            gdvInforSubject.BackgroundColor = SystemColors.ButtonHighlight;
            gdvInforSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvInforSubject.Columns.AddRange(new DataGridViewColumn[] { col_IdSubject, col_NameSubject, col_Score });
            gdvInforSubject.Location = new Point(145, 258);
            gdvInforSubject.Name = "gdvInforSubject";
            gdvInforSubject.RowHeadersWidth = 51;
            gdvInforSubject.Size = new Size(512, 218);
            gdvInforSubject.TabIndex = 11;
            // 
            // col_IdSubject
            // 
            col_IdSubject.DataPropertyName = "mamon";
            col_IdSubject.HeaderText = "Mã Môn Học";
            col_IdSubject.MinimumWidth = 6;
            col_IdSubject.Name = "col_IdSubject";
            col_IdSubject.Width = 125;
            // 
            // col_NameSubject
            // 
            col_NameSubject.DataPropertyName = "tenmon";
            col_NameSubject.HeaderText = "Tên Môn Học";
            col_NameSubject.MinimumWidth = 6;
            col_NameSubject.Name = "col_NameSubject";
            col_NameSubject.Width = 125;
            // 
            // col_Score
            // 
            col_Score.DataPropertyName = "diemthi";
            col_Score.HeaderText = "Điểm Thi";
            col_Score.MinimumWidth = 6;
            col_Score.Name = "col_Score";
            col_Score.Width = 125;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(469, 183);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(589, 183);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FSearchStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 553);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(gdvInforSubject);
            Controls.Add(txtSex);
            Controls.Add(txtIdFaculty);
            Controls.Add(txtName);
            Controls.Add(dtpBirthday);
            Controls.Add(cmbMSSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FSearchStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tìm kiếm thông tin sinh viên";
            Load += FSearchStudent_Load;
            ((System.ComponentModel.ISupportInitialize)gdvInforSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbMSSV;
        private DateTimePicker dtpBirthday;
        private TextBox txtName;
        private TextBox txtIdFaculty;
        private TextBox txtSex;
        private DataGridView gdvInforSubject;
        private Button btnSearch;
        private Button btnExit;
        private DataGridViewTextBoxColumn col_IdSubject;
        private DataGridViewTextBoxColumn col_NameSubject;
        private DataGridViewTextBoxColumn col_Score;
    }
}
