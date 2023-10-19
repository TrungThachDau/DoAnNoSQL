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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            ;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            XuLyDangNhap xuLyDangNhap = new XuLyDangNhap();

            if (xuLyDangNhap.KiemTraDangNhap(username, password) == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
				FormTrangChu f = new FormTrangChu();
                f.menuStrip1.Items["menuThongKe"].Visible = false;
                f.menuStrip1.Items["tàiKToolStripMenuItem"].Visible=false;
                f.Show();
                this.Hide();
            }
            else if (xuLyDangNhap.KiemTraDangNhap(username, password) == 2)
            {
                MessageBox.Show("Đăng nhập thành công");
				FormTrangChu f = new FormTrangChu();
                f.Show();
                this.Hide();
			}
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
