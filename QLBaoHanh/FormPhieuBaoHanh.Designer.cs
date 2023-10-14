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
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_search = new System.Windows.Forms.TextBox();
            btn_Thoat = new System.Windows.Forms.Button();
            btn_Huy = new System.Windows.Forms.Button();
            btn_sua = new System.Windows.Forms.Button();
            btn_them = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column3, NgayYeuCauBH, Column1, Column2, Column4, Column5, Column6 });
            dataGridView1.Location = new System.Drawing.Point(30, 183);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 345);
            dataGridView1.TabIndex = 0;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Ma";
            Column3.HeaderText = "Mã";
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
            // Column2
            // 
            Column2.DataPropertyName = "SanPham";
            Column2.HeaderText = "Sản phẩm";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "MoTaLoi";
            Column4.HeaderText = "Mô tả lỗi";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TinhTrangXuLy";
            Column5.HeaderText = "Tình trạng";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "NgayCapNhat";
            Column6.HeaderText = "Ngày cập nhật";
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(369, 44);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(380, 37);
            label1.TabIndex = 1;
            label1.Text = "BẢO HÀNH SẢN PHẨM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(309, 122);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(444, 122);
            txt_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(303, 23);
            txt_search.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new System.Drawing.Point(471, 573);
            btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new System.Drawing.Size(106, 38);
            btn_Thoat.TabIndex = 4;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new System.Drawing.Point(328, 573);
            btn_Huy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new System.Drawing.Size(106, 38);
            btn_Huy.TabIndex = 5;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new System.Drawing.Point(615, 573);
            btn_sua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new System.Drawing.Size(106, 38);
            btn_sua.TabIndex = 6;
            btn_sua.Text = "Sửa phiếu";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new System.Drawing.Point(763, 573);
            btn_them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_them.Name = "btn_them";
            btn_them.Size = new System.Drawing.Size(106, 38);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm phiếu";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(192, 572);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(99, 39);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Làm mới";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // FormPhieuBaoHanh
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1396, 828);
            Controls.Add(btnLoad);
            Controls.Add(btn_them);
            Controls.Add(btn_sua);
            Controls.Add(btn_Huy);
            Controls.Add(btn_Thoat);
            Controls.Add(txt_search);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FormPhieuBaoHanh";
            ShowIcon = false;
            Text = "Bảo hành";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayYeuCauBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnLoad;
    }
}

