namespace QLBaoHanh
{
    partial class FormPhieuBaoHanh
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NgayYeuCauBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_search = new System.Windows.Forms.TextBox();
            btn_Thoat = new System.Windows.Forms.Button();
            btn_Huy = new System.Windows.Forms.Button();
            btn_sua = new System.Windows.Forms.Button();
            btn_them = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            txtMaBH = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtNgayYC = new System.Windows.Forms.TextBox();
            txtTenKH = new System.Windows.Forms.TextBox();
            txtDiaChi = new System.Windows.Forms.TextBox();
            txtSDT = new System.Windows.Forms.TextBox();
            txtSanPham = new System.Windows.Forms.TextBox();
            txtIMEI = new System.Windows.Forms.TextBox();
            txtNgayKichHoat = new System.Windows.Forms.TextBox();
            txtMoTaLoi = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            cbbTinhTrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column3, NgayYeuCauBH, Column1, Column5, Column6 });
            dataGridView1.Location = new System.Drawing.Point(39, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(782, 529);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Ma";
            Column3.HeaderText = "Mã";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // NgayYeuCauBH
            // 
            NgayYeuCauBH.DataPropertyName = "NgayYeuCauBH";
            NgayYeuCauBH.HeaderText = "Ngày yêu cầu";
            NgayYeuCauBH.MinimumWidth = 7;
            NgayYeuCauBH.Name = "NgayYeuCauBH";
            NgayYeuCauBH.Width = 140;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TenKhachHang";
            Column1.HeaderText = "Khách hàng";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.Width = 160;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TinhTrangXuLy";
            Column5.HeaderText = "Tình trạng";
            Column5.MinimumWidth = 7;
            Column5.Name = "Column5";
            Column5.Width = 140;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "NgayCapNhat";
            Column6.HeaderText = "Ngày cập nhật";
            Column6.MinimumWidth = 7;
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(474, 67);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(522, 52);
            label1.TabIndex = 1;
            label1.Text = "BẢO HÀNH SẢN PHẨM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(39, 188);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 29);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(170, 188);
            txt_search.Margin = new System.Windows.Forms.Padding(5);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(388, 30);
            txt_search.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new System.Drawing.Point(606, 879);
            btn_Thoat.Margin = new System.Windows.Forms.Padding(5);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new System.Drawing.Size(136, 58);
            btn_Thoat.TabIndex = 4;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new System.Drawing.Point(422, 879);
            btn_Huy.Margin = new System.Windows.Forms.Padding(5);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new System.Drawing.Size(136, 58);
            btn_Huy.TabIndex = 5;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new System.Drawing.Point(791, 879);
            btn_sua.Margin = new System.Windows.Forms.Padding(5);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new System.Drawing.Size(136, 58);
            btn_sua.TabIndex = 6;
            btn_sua.Text = "Xem chi tiết";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new System.Drawing.Point(981, 879);
            btn_them.Margin = new System.Windows.Forms.Padding(5);
            btn_them.Name = "btn_them";
            btn_them.Size = new System.Drawing.Size(136, 58);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm phiếu";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(889, 202);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 23);
            label3.TabIndex = 8;
            label3.Text = "Mã bảo hành";
            // 
            // txtMaBH
            // 
            txtMaBH.Location = new System.Drawing.Point(1025, 198);
            txtMaBH.Name = "txtMaBH";
            txtMaBH.ReadOnly = true;
            txtMaBH.Size = new System.Drawing.Size(335, 30);
            txtMaBH.TabIndex = 9;
            txtMaBH.Text = "xxx";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(889, 277);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(114, 23);
            label5.TabIndex = 12;
            label5.Text = "Ngày yêu cầu";
            // 
            // txtNgayYC
            // 
            txtNgayYC.Location = new System.Drawing.Point(1025, 270);
            txtNgayYC.Name = "txtNgayYC";
            txtNgayYC.ReadOnly = true;
            txtNgayYC.Size = new System.Drawing.Size(335, 30);
            txtNgayYC.TabIndex = 13;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new System.Drawing.Point(1025, 334);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new System.Drawing.Size(335, 30);
            txtTenKH.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(1025, 400);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(335, 30);
            txtDiaChi.TabIndex = 15;
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(1025, 461);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(335, 30);
            txtSDT.TabIndex = 16;
            // 
            // txtSanPham
            // 
            txtSanPham.Location = new System.Drawing.Point(1025, 524);
            txtSanPham.Name = "txtSanPham";
            txtSanPham.ReadOnly = true;
            txtSanPham.Size = new System.Drawing.Size(335, 30);
            txtSanPham.TabIndex = 17;
            // 
            // txtIMEI
            // 
            txtIMEI.Location = new System.Drawing.Point(1025, 590);
            txtIMEI.Name = "txtIMEI";
            txtIMEI.ReadOnly = true;
            txtIMEI.Size = new System.Drawing.Size(335, 30);
            txtIMEI.TabIndex = 18;
            // 
            // txtNgayKichHoat
            // 
            txtNgayKichHoat.Location = new System.Drawing.Point(1025, 655);
            txtNgayKichHoat.Name = "txtNgayKichHoat";
            txtNgayKichHoat.ReadOnly = true;
            txtNgayKichHoat.Size = new System.Drawing.Size(335, 30);
            txtNgayKichHoat.TabIndex = 19;
            // 
            // txtMoTaLoi
            // 
            txtMoTaLoi.Location = new System.Drawing.Point(1025, 724);
            txtMoTaLoi.Name = "txtMoTaLoi";
            txtMoTaLoi.Size = new System.Drawing.Size(335, 30);
            txtMoTaLoi.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(900, 341);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 23);
            label4.TabIndex = 22;
            label4.Text = "Khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(926, 407);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 23);
            label6.TabIndex = 23;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(949, 461);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(39, 23);
            label7.TabIndex = 24;
            label7.Text = "SDT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(901, 527);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 23);
            label8.TabIndex = 25;
            label8.Text = "Sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(944, 593);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(44, 23);
            label9.TabIndex = 26;
            label9.Text = "IMEI";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(874, 655);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(125, 23);
            label10.TabIndex = 27;
            label10.Text = "Ngày kích hoạt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(910, 727);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(78, 23);
            label11.TabIndex = 28;
            label11.Text = "Mô tả lỗi";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(874, 796);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(129, 23);
            label12.TabIndex = 29;
            label12.Text = "Tình trạng xử lý";
            // 
            // cbbTinhTrang
            // 
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Items.AddRange(new object[] { "Đang xử lý", "Chưa xử lý" });
            cbbTinhTrang.Location = new System.Drawing.Point(1032, 803);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new System.Drawing.Size(328, 31);
            cbbTinhTrang.TabIndex = 30;
            // 
            // FormPhieuBaoHanh
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1396, 1027);
            Controls.Add(cbbTinhTrang);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtMoTaLoi);
            Controls.Add(txtNgayKichHoat);
            Controls.Add(txtIMEI);
            Controls.Add(txtSanPham);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKH);
            Controls.Add(txtNgayYC);
            Controls.Add(label5);
            Controls.Add(txtMaBH);
            Controls.Add(label3);
            Controls.Add(btn_them);
            Controls.Add(btn_sua);
            Controls.Add(btn_Huy);
            Controls.Add(btn_Thoat);
            Controls.Add(txt_search);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormPhieuBaoHanh";
            ShowIcon = false;
            Text = "Bảo hành";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaBH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayYC;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.TextBox txtNgayKichHoat;
        private System.Windows.Forms.TextBox txtMoTaLoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayYeuCauBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

