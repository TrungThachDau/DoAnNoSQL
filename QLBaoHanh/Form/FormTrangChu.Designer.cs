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
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			menuBaoHanh = new System.Windows.Forms.ToolStripMenuItem();
			menuSanpham = new System.Windows.Forms.ToolStripMenuItem();
			menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
			menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
			tàiKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuBaoHanh, menuSanpham, menuKhachHang, menuThongKe, tàiKToolStripMenuItem });
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			menuStrip1.Size = new System.Drawing.Size(1255, 30);
			menuStrip1.TabIndex = 2;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
			// 
			// menuBaoHanh
			// 
			menuBaoHanh.Name = "menuBaoHanh";
			menuBaoHanh.Size = new System.Drawing.Size(85, 24);
			menuBaoHanh.Text = "Bảo hành";
			menuBaoHanh.Click += menuBaoHanh_Click;
			// 
			// menuSanpham
			// 
			menuSanpham.Name = "menuSanpham";
			menuSanpham.Size = new System.Drawing.Size(89, 24);
			menuSanpham.Text = "Sản phẩm";
			menuSanpham.Click += menuSanpham_Click;
			// 
			// menuKhachHang
			// 
			menuKhachHang.Name = "menuKhachHang";
			menuKhachHang.Size = new System.Drawing.Size(100, 24);
			menuKhachHang.Text = "Khách hàng";
			menuKhachHang.Click += menuKhachHang_Click;
			// 
			// menuThongKe
			// 
			menuThongKe.Name = "menuThongKe";
			menuThongKe.Size = new System.Drawing.Size(84, 24);
			menuThongKe.Text = "Thống kê";
			menuThongKe.Click += menuThongKe_Click;
			// 
			// tàiKToolStripMenuItem
			// 
			tàiKToolStripMenuItem.Name = "tàiKToolStripMenuItem";
			tàiKToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			tàiKToolStripMenuItem.Text = "Tài khoản";
			tàiKToolStripMenuItem.Click += tàiKToolStripMenuItem_Click;
			// 
			// FormTrangChu
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1255, 834);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			Name = "FormTrangChu";
			ShowIcon = false;
			Text = "Trang chủ";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			FormClosing += FormTrangChu_FormClosing;
			Load += FormTrangChu_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuBaoHanh;
		private System.Windows.Forms.ToolStripMenuItem menuSanpham;
		private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
		public System.Windows.Forms.ToolStripMenuItem menuThongKe;
		public System.Windows.Forms.ToolStripMenuItem tàiKToolStripMenuItem;
	}
}