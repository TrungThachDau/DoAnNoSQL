namespace QLBaoHanh
{
    partial class FormSanPham
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
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtMaSp = new System.Windows.Forms.TextBox();
            txtTenSp = new System.Windows.Forms.TextBox();
            txtImei = new System.Windows.Forms.TextBox();
            txtGia = new System.Windows.Forms.TextBox();
            txtNSX = new System.Windows.Forms.TextBox();
            txtTSKT = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dtpNgayKichHoat = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btn_Huy = new System.Windows.Forms.Button();
            btn_Thoat = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column7, Column4, Column3, Column6, Column5 });
            dataGridView1.Location = new System.Drawing.Point(15, 92);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1040, 395);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Masp";
            Column1.HeaderText = "Mã";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            Column1.Width = 140;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Tensp";
            Column2.HeaderText = "Tên";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ImeiSanPham";
            Column7.HeaderText = "Imei";
            Column7.MinimumWidth = 7;
            Column7.Name = "Column7";
            Column7.Width = 140;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Thongsokythuat";
            Column4.HeaderText = "Thông số kỹ thuật";
            Column4.MinimumWidth = 7;
            Column4.Name = "Column4";
            Column4.Width = 140;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Gia";
            Column3.HeaderText = "Giá";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            Column3.Width = 140;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Ngaykichhoatbaohanh";
            Column6.HeaderText = "Ngày kích hoạt";
            Column6.MinimumWidth = 7;
            Column6.Name = "Column6";
            Column6.Width = 140;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Nhasanxuat";
            Column5.HeaderText = "Nhà sản xuất";
            Column5.MinimumWidth = 7;
            Column5.Name = "Column5";
            Column5.Width = 140;
            // 
            // txtMaSp
            // 
            txtMaSp.Location = new System.Drawing.Point(122, 508);
            txtMaSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMaSp.Name = "txtMaSp";
            txtMaSp.Size = new System.Drawing.Size(215, 22);
            txtMaSp.TabIndex = 1;
            // 
            // txtTenSp
            // 
            txtTenSp.Location = new System.Drawing.Point(462, 508);
            txtTenSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new System.Drawing.Size(212, 22);
            txtTenSp.TabIndex = 2;
            // 
            // txtImei
            // 
            txtImei.Location = new System.Drawing.Point(802, 514);
            txtImei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtImei.Name = "txtImei";
            txtImei.Size = new System.Drawing.Size(253, 22);
            txtImei.TabIndex = 3;
            // 
            // txtGia
            // 
            txtGia.Location = new System.Drawing.Point(462, 571);
            txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtGia.Name = "txtGia";
            txtGia.Size = new System.Drawing.Size(212, 22);
            txtGia.TabIndex = 5;
            // 
            // txtNSX
            // 
            txtNSX.Location = new System.Drawing.Point(122, 568);
            txtNSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNSX.Name = "txtNSX";
            txtNSX.Size = new System.Drawing.Size(215, 22);
            txtNSX.TabIndex = 6;
            // 
            // txtTSKT
            // 
            txtTSKT.Location = new System.Drawing.Point(142, 621);
            txtTSKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTSKT.Multiline = true;
            txtTSKT.Name = "txtTSKT";
            txtTSKT.Size = new System.Drawing.Size(921, 70);
            txtTSKT.TabIndex = 7;
            txtTSKT.TextChanged += textBox7_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 512);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 16);
            label1.TabIndex = 8;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(343, 514);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 16);
            label2.TabIndex = 9;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(680, 517);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 16);
            label3.TabIndex = 10;
            label3.Text = "Imei";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(343, 577);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 16);
            label4.TabIndex = 11;
            label4.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(16, 571);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 16);
            label5.TabIndex = 12;
            label5.Text = "Nhà sản xuất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(680, 574);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(96, 16);
            label6.TabIndex = 13;
            label6.Text = "Ngày kích hoạt";
            // 
            // dtpNgayKichHoat
            // 
            dtpNgayKichHoat.Location = new System.Drawing.Point(802, 569);
            dtpNgayKichHoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpNgayKichHoat.Name = "dtpNgayKichHoat";
            dtpNgayKichHoat.Size = new System.Drawing.Size(253, 22);
            dtpNgayKichHoat.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(16, 624);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(112, 16);
            label7.TabIndex = 15;
            label7.Text = "Thông số kỹ thuật";
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(51, 725);
            btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(130, 38);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(267, 725);
            btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(144, 38);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(480, 725);
            btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(149, 38);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btn_Huy
            // 
            btn_Huy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Huy.Location = new System.Drawing.Point(680, 725);
            btn_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new System.Drawing.Size(126, 38);
            btn_Huy.TabIndex = 19;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new System.Drawing.Point(853, 725);
            btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new System.Drawing.Size(181, 38);
            btn_Thoat.TabIndex = 20;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(409, 29);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(173, 33);
            label8.TabIndex = 21;
            label8.Text = "SẢN PHẨM";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1075, 775);
            Controls.Add(label8);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_Huy);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label7);
            Controls.Add(dtpNgayKichHoat);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTSKT);
            Controls.Add(txtNSX);
            Controls.Add(txtGia);
            Controls.Add(txtImei);
            Controls.Add(txtTenSp);
            Controls.Add(txtMaSp);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FormSanPham";
            ShowIcon = false;
            Text = "Sản phẩm";
            Load += FormSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.TextBox txtTSKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayKichHoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label8;
    }
}