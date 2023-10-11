using QLBaoHanh.Model;
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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtDiachi.Clear();
            
            txtSDT.Clear();
            txtPhai.Clear();
            txtTenKH.Focus();
        }
        public void LoadKhachHang()
        {
            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            dataGridView1.DataSource = mongoDBHelper.DocKhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text;
            string diaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string ngsinh = dtpngsinh.Value.ToString("dd/MM/yyyy");
            string phai = txtPhai.Text;
            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            mongoDBHelper.InsertDocument<KhachHang>("kh", new KhachHang
            {
                TenKH = tenKH,
                DiaChi = diaChi,
                DienThoai = sdt,
                Phai = phai,
                NgaySinh = ngsinh
            });
            LoadKhachHang();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTenKH.Text = row.Cells[0].Value.ToString();
                txtDiachi.Text = row.Cells[1].Value.ToString();
                dtpngsinh.Text = row.Cells[2].Value.ToString();
                txtPhai.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenkh = txtTenKH.Text;
            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            mongoDBHelper.DeleteOneDocument<KhachHang>("kh", "TenKhachHang", tenkh);
            LoadKhachHang();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text;
            string diaChi = txtDiachi.Text;
            string sdt = txtSDT.Text;
            string phai = txtPhai.Text;
            string ngsinh = dtpngsinh.Value.ToString("dd-MM-yyyy");
            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            mongoDBHelper.UpdateOneDocument<KhachHang>("kh", "TenKhachHang", tenKH, new KhachHang
            {
                TenKH = tenKH,
                DiaChi = diaChi,
                DienThoai = sdt,
                Phai = phai,
                NgaySinh = ngsinh
            });
            LoadKhachHang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
