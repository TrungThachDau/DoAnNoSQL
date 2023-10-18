using QLBaoHanh.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //txtDiachi.Clear();

            txtSDT.Clear();
            cbbGioiTinh.ResetText();
            txtTenKH.Focus();
        }

        public void LoadKhachHang()
        {

            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
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
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thêm mới khách hàng '" + txtTenKH.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string tenKH = txtTenKH.Text;
                string diaChi = cbbTinh.Text;//"Quận 1, Hồ Chí Minh
                string sdt = txtSDT.Text;
                string ngsinh = dtpngsinh.Value.ToString(format: "dd-MM-yyyy");
                string phai = cbbGioiTinh.Text;
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.InsertOneDocument<KhachHang>("kh", new KhachHang
                {
                    TenKH = tenKH,
                    DiaChi = diaChi,
                    DienThoai = sdt,
                    Phai = phai,
                    NgaySinh = ngsinh
                });
                LoadKhachHang();
                MessageBox.Show("Thêm thành công");

            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            List<string> danhSachTinhThanh = Provinces.DanhSachTinhThanh();
            cbbTinh.Items.AddRange(danhSachTinhThanh.ToArray());
            cbbGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa khách hàng '" + txtTenKH.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {

                string tenkh = txtTenKH.Text;
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.DeleteOneDocument<KhachHang>("kh", "TenKhachHang", tenkh);
                LoadKhachHang();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa thông tin khách hàng '" + txtTenKH.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string tenKH = txtTenKH.Text;
                string diaChi = cbbTinh.Text;//"Quận 1, Hồ Chí Minh
                string sdt = txtSDT.Text;
                string phai = cbbGioiTinh.Text;
                string ngsinh = dtpngsinh.Value.ToString(format: "dd-MM-yyyy");
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.UpdateOneDocument<KhachHang>("kh", "TenKhachHang", tenKH, new KhachHang
                {
                    TenKH = tenKH,
                    DiaChi = diaChi,
                    DienThoai = sdt,
                    Phai = phai,
                    NgaySinh = ngsinh
                });
                LoadKhachHang();
                MessageBox.Show("Sửa thành công");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTenKH.Text = row.Cells[0].Value.ToString();
                string diaChi = row.Cells[1].Value.ToString();
                dtpngsinh.Text = row.Cells[2].Value.ToString();
                string gioiTinh = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                string diaChiDaChon = "Khác"; // Mặc định hiển thị "Khác"

                foreach (var item in cbbTinh.Items)
                {
                    if (item.ToString() == diaChi)
                    {
                        diaChiDaChon = diaChi;
                        break; // Tìm thấy tỉnh, thoát khỏi vòng lặp
                    }
                }
                cbbTinh.Text = diaChiDaChon;
                foreach (var item in cbbGioiTinh.Items)
                {
                    if (item.ToString() == gioiTinh)
                    {
                        cbbGioiTinh.Text = gioiTinh;
                        break;
                    }
                }
                cbbGioiTinh.Text = gioiTinh;
                // Sau khi vòng lặp kết thúc, diaChiDaChon sẽ chứa giá trị của tỉnh nếu tìm thấy, hoặc "Khác" nếu không tìm thấy.

            }
        }
    }
}
