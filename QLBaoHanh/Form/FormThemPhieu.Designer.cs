namespace QLBaoHanh
{
    partial class FormThemPhieu
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
            cbbSanPham = new System.Windows.Forms.ComboBox();
            cbbKhachHang = new System.Windows.Forms.ComboBox();
            dtpNgayYeuCau = new System.Windows.Forms.DateTimePicker();
            txtMoTaLoi = new System.Windows.Forms.TextBox();
            btnLuu = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbbSanPham
            // 
            cbbSanPham.FormattingEnabled = true;
            cbbSanPham.Location = new System.Drawing.Point(205, 59);
            cbbSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbbSanPham.Name = "cbbSanPham";
            cbbSanPham.Size = new System.Drawing.Size(217, 23);
            cbbSanPham.TabIndex = 0;
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new System.Drawing.Point(205, 109);
            cbbKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new System.Drawing.Size(216, 23);
            cbbKhachHang.TabIndex = 1;
            // 
            // dtpNgayYeuCau
            // 
            dtpNgayYeuCau.Location = new System.Drawing.Point(205, 153);
            dtpNgayYeuCau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dtpNgayYeuCau.Name = "dtpNgayYeuCau";
            dtpNgayYeuCau.Size = new System.Drawing.Size(218, 23);
            dtpNgayYeuCau.TabIndex = 2;
            // 
            // txtMoTaLoi
            // 
            txtMoTaLoi.Location = new System.Drawing.Point(205, 194);
            txtMoTaLoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtMoTaLoi.Name = "txtMoTaLoi";
            txtMoTaLoi.Size = new System.Drawing.Size(217, 23);
            txtMoTaLoi.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Location = new System.Drawing.Point(205, 250);
            btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(82, 21);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18.2686558F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(205, 6);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 35);
            label1.TabIndex = 5;
            label1.Text = "THÊM PHIẾU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(90, 65);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(90, 111);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 15);
            label3.TabIndex = 7;
            label3.Text = "Khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(90, 157);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 15);
            label4.TabIndex = 8;
            label4.Text = "Ngày yêu cầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(90, 194);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "Mô tả lỗi";
            // 
            // FormThemPhieu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(528, 308);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLuu);
            Controls.Add(txtMoTaLoi);
            Controls.Add(dtpNgayYeuCau);
            Controls.Add(cbbKhachHang);
            Controls.Add(cbbSanPham);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "FormThemPhieu";
            ShowIcon = false;
            Text = "Thêm phiếu";
            Load += FormThemPhieu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgayYeuCau;
        private System.Windows.Forms.TextBox txtMoTaLoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}