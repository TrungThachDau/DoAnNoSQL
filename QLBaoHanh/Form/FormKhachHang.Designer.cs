namespace QLBaoHanh
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
            txtDiachi = new System.Windows.Forms.TextBox();
            txtSDT = new System.Windows.Forms.TextBox();
            txtPhai = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnCapnhat = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            dtpngsinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.DarkRed;
            label1.Location = new System.Drawing.Point(368, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "KHÁCH HÀNG";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Col1, Col2, Col3, Col4, Col5 });
            dataGridView1.Location = new System.Drawing.Point(8, 39);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(814, 231);
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
            label2.Location = new System.Drawing.Point(189, 289);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 16);
            label2.TabIndex = 2;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(189, 327);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 16);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label4.Location = new System.Drawing.Point(189, 362);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 16);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label5.Location = new System.Drawing.Point(189, 394);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 16);
            label5.TabIndex = 5;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label6.Location = new System.Drawing.Point(189, 432);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 16);
            label6.TabIndex = 6;
            label6.Text = "Giới tính";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new System.Drawing.Point(311, 289);
            txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new System.Drawing.Size(215, 23);
            txtTenKH.TabIndex = 7;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new System.Drawing.Point(311, 326);
            txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new System.Drawing.Size(215, 23);
            txtDiachi.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(311, 359);
            txtSDT.Margin = new System.Windows.Forms.Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(215, 23);
            txtSDT.TabIndex = 9;
            // 
            // txtPhai
            // 
            txtPhai.Location = new System.Drawing.Point(311, 429);
            txtPhai.Margin = new System.Windows.Forms.Padding(2);
            txtPhai.Name = "txtPhai";
            txtPhai.Size = new System.Drawing.Size(215, 23);
            txtPhai.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnThem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnThem.Location = new System.Drawing.Point(541, 286);
            btnThem.Margin = new System.Windows.Forms.Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(78, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnXoa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnXoa.Location = new System.Drawing.Point(541, 320);
            btnXoa.Margin = new System.Windows.Forms.Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(78, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCapnhat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnCapnhat.Location = new System.Drawing.Point(541, 355);
            btnCapnhat.Margin = new System.Windows.Forms.Padding(2);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new System.Drawing.Size(78, 28);
            btnCapnhat.TabIndex = 14;
            btnCapnhat.Text = "Sửa";
            btnCapnhat.UseVisualStyleBackColor = true;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnThoat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnThoat.Location = new System.Drawing.Point(540, 425);
            btnThoat.Margin = new System.Windows.Forms.Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(79, 29);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHuy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            btnHuy.Location = new System.Drawing.Point(541, 387);
            btnHuy.Margin = new System.Windows.Forms.Padding(2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(78, 29);
            btnHuy.TabIndex = 17;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dtpngsinh
            // 
            dtpngsinh.Location = new System.Drawing.Point(311, 393);
            dtpngsinh.Margin = new System.Windows.Forms.Padding(2);
            dtpngsinh.Name = "dtpngsinh";
            dtpngsinh.Size = new System.Drawing.Size(215, 23);
            dtpngsinh.TabIndex = 18;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(829, 472);
            Controls.Add(dtpngsinh);
            Controls.Add(btnHuy);
            Controls.Add(btnThoat);
            Controls.Add(btnCapnhat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtPhai);
            Controls.Add(txtSDT);
            Controls.Add(txtDiachi);
            Controls.Add(txtTenKH);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtPhai;
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
    }
}