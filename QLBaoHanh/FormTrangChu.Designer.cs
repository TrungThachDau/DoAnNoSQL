namespace QLBaoHanh
{
    partial class FormTrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBaoHanh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBaoHanh,
            this.menuSanpham,
            this.menuKhachHang,
            this.menuThongKe,
            this.tàiKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1255, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBaoHanh
            // 
            this.menuBaoHanh.Name = "menuBaoHanh";
            this.menuBaoHanh.Size = new System.Drawing.Size(99, 27);
            this.menuBaoHanh.Text = "Bảo hành";
            this.menuBaoHanh.Click += new System.EventHandler(this.menuBaoHanh_Click);
            // 
            // menuSanpham
            // 
            this.menuSanpham.Name = "menuSanpham";
            this.menuSanpham.Size = new System.Drawing.Size(103, 27);
            this.menuSanpham.Text = "Sản phẩm";
            this.menuSanpham.Click += new System.EventHandler(this.menuSanpham_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(117, 27);
            this.menuKhachHang.Text = "Khách hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(97, 27);
            this.menuThongKe.Text = "Thống kê";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // tàiKToolStripMenuItem
            // 
            this.tàiKToolStripMenuItem.Name = "tàiKToolStripMenuItem";
            this.tàiKToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.tàiKToolStripMenuItem.Text = "Tài khoản";
            this.tàiKToolStripMenuItem.Click += new System.EventHandler(this.tàiKToolStripMenuItem_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 667);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBaoHanh;
        private System.Windows.Forms.ToolStripMenuItem menuSanpham;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem tàiKToolStripMenuItem;
    }
}