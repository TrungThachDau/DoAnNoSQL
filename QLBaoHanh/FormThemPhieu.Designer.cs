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
            cbbSanPham.Location = new System.Drawing.Point(263, 91);
            cbbSanPham.Name = "cbbSanPham";
            cbbSanPham.Size = new System.Drawing.Size(278, 31);
            cbbSanPham.TabIndex = 0;
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new System.Drawing.Point(264, 167);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new System.Drawing.Size(277, 31);
            cbbKhachHang.TabIndex = 1;
            // 
            // dtpNgayYeuCau
            // 
            dtpNgayYeuCau.Location = new System.Drawing.Point(264, 234);
            dtpNgayYeuCau.Name = "dtpNgayYeuCau";
            dtpNgayYeuCau.Size = new System.Drawing.Size(279, 30);
            dtpNgayYeuCau.TabIndex = 2;
            // 
            // txtMoTaLoi
            // 
            txtMoTaLoi.Location = new System.Drawing.Point(263, 298);
            txtMoTaLoi.Name = "txtMoTaLoi";
            txtMoTaLoi.Size = new System.Drawing.Size(278, 30);
            txtMoTaLoi.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Location = new System.Drawing.Point(264, 383);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(105, 32);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18.2686558F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(263, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 46);
            label1.TabIndex = 5;
            label1.Text = "THÊM PHIẾU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(116, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 23);
            label2.TabIndex = 6;
            label2.Text = "Sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(116, 170);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 23);
            label3.TabIndex = 7;
            label3.Text = "Khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(116, 240);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(114, 23);
            label4.TabIndex = 8;
            label4.Text = "Ngày yêu cầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(116, 298);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 23);
            label5.TabIndex = 9;
            label5.Text = "Mô tả lỗi";
            // 
            // FormThemPhieu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(679, 473);
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
            Name = "FormThemPhieu";
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