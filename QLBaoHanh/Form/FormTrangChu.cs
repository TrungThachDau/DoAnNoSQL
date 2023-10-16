using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBaoHanh
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void menuSanpham_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            f.MdiParent = this;
            f.Show();
        }

        public void menuBaoHanh_Click(object sender, EventArgs e)
        {
            FormPhieuBaoHanh f = new FormPhieuBaoHanh();
            f.MdiParent = this;
            f.Show();
        }

        public void menuThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe f = new FormThongKe();
            f.MdiParent = this;
            f.Show();
        }

        public void menuKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void tàiKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaiKhoan f = new FormTaiKhoan();
            f.MdiParent = this;
            f.Show();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
