﻿namespace QLBaoHanh
{
    partial class FormKhachHang
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
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtTenKH = new System.Windows.Forms.TextBox();
            txtSDT = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnCapnhat = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            dtpngsinh = new System.Windows.Forms.DateTimePicker();
            cbbTinh = new System.Windows.Forms.ComboBox();
            cbbGioiTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.DarkRed;
            label1.Location = new System.Drawing.Point(473, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 35);
            label1.TabIndex = 0;
            label1.Text = "KHÁCH HÀNG";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Col1, Col2, Col3, Col4, Col5 });
            dataGridView1.Location = new System.Drawing.Point(10, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(1047, 354);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Col1
            // 
            Col1.DataPropertyName = "TenKhachHang";
            Col1.HeaderText = "Tên khách hàng";
            Col1.MinimumWidth = 8;
            Col1.Name = "Col1";
            Col1.Width = 150;
            // 
            // Col2
            // 
            Col2.DataPropertyName = "Diachi";
            Col2.HeaderText = "Địa chỉ";
            Col2.MinimumWidth = 8;
            Col2.Name = "Col2";
            Col2.Width = 150;
            // 
            // Col3
            // 
            Col3.DataPropertyName = "SDT";
            Col3.HeaderText = "Số điện thoại";
            Col3.MinimumWidth = 8;
            Col3.Name = "Col3";
            Col3.Width = 150;
            // 
            // Col4
            // 
            Col4.DataPropertyName = "Ngaysinh";
            Col4.HeaderText = "Ngày sinh";
            Col4.MinimumWidth = 8;
            Col4.Name = "Col4";
            Col4.Width = 150;
            // 
            // Col5
            // 
            Col5.DataPropertyName = "Phai";
            Col5.HeaderText = "Giới tính";
            Col5.MinimumWidth = 8;
            Col5.Name = "Col5";
            Col5.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(243, 443);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 21);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(243, 501);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 21);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(243, 555);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 21);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label5.Location = new System.Drawing.Point(243, 604);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 21);
            label5.TabIndex = 5;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label6.Location = new System.Drawing.Point(243, 662);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 21);
            label6.TabIndex = 6;
            label6.Text = "Giới tính";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new System.Drawing.Point(400, 443);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new System.Drawing.Size(275, 30);
            txtTenKH.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(400, 550);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(275, 30);
            txtSDT.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnThem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnThem.Location = new System.Drawing.Point(696, 439);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(100, 44);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnXoa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnXoa.Location = new System.Drawing.Point(696, 491);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(100, 44);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCapnhat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnCapnhat.Location = new System.Drawing.Point(696, 544);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new System.Drawing.Size(100, 43);
            btnCapnhat.TabIndex = 14;
            btnCapnhat.Text = "Sửa";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnThoat.Location = new System.Drawing.Point(694, 652);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(102, 44);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHuy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnHuy.Location = new System.Drawing.Point(696, 593);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(100, 44);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dtpngsinh
            // 
            dtpngsinh.Location = new System.Drawing.Point(400, 603);
            dtpngsinh.Name = "dtpngsinh";
            dtpngsinh.Size = new System.Drawing.Size(275, 30);
            dtpngsinh.TabIndex = 18;
            // 
            // cbbTinh
            // 
            cbbTinh.FormattingEnabled = true;
            cbbTinh.Location = new System.Drawing.Point(400, 496);
            cbbTinh.Name = "cbbTinh";
            cbbTinh.Size = new System.Drawing.Size(275, 31);
            cbbTinh.TabIndex = 19;
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Location = new System.Drawing.Point(402, 659);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new System.Drawing.Size(273, 31);
            cbbGioiTinh.TabIndex = 20;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1066, 724);
            Controls.Add(cbbGioiTinh);
            Controls.Add(cbbTinh);
            Controls.Add(dtpngsinh);
            Controls.Add(btnHuy);
            Controls.Add(btnThoat);
            Controls.Add(btnCapnhat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKH);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FormKhachHang";
            ShowIcon = false;
            Text = "Khách hàng";
            Load += FormKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DateTimePicker dtpngsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.ComboBox cbbTinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
    }
}