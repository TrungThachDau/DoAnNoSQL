using MongoDB.Bson;
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

namespace QLBaoHanh
{
    public partial class FormPhieuBaoHanh : Form
    {

        public FormPhieuBaoHanh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            List<string> danhSachTinhThanh = Provinces.DanhSachTinhThanh();
            cbbTinh.Items.AddRange(danhSachTinhThanh.ToArray());
            cbbTinhTrang.Items.AddRange(new string[] { "Đang xử lý", "Chưa xử lý", "Đã xử lý" });
        }
        public void LoadData()
        {

            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            dataGridView1.DataSource = mongoDBHelper.DocPhieuBaoHanh();


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FormThemPhieu f = new FormThemPhieu();
            f.Show();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txtMaBH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu bảo hành cần sửa");
                return;
            }
            string maBH = txtMaBH.Text;
            string ngayYC = txtNgayYC.Text;
            string tenKH = txtTenKH.Text;
            string diaChi = cbbTinh.Text;
            string sdt = txtSDT.Text;
            string sanPham = txtSanPham.Text;
            string imei = txtIMEI.Text;
            string ngayKichHoat = txtNgayKichHoat.Text;
            string moTaLoi = txtMoTaLoi.Text;
            string tinhTrang = cbbTinhTrang.Text;
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa thông tin phiếu bảo hành '" +maBH + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.UpdateOneDocumentById<PhieuBaoHanh>("bh", maBH, new PhieuBaoHanh
                {
                    Id = ObjectId.Parse(maBH),
                    NgayYCBaoHanh = ngayYC,
                    KhachHang = new KhachHang
                    {
                        TenKH = tenKH,
                        DiaChi = diaChi,
                        DienThoai = sdt
                    },
                    SanPham = new SanPham
                    {
                        TenSP = sanPham,
                        ImeiSP = imei,
                        NgayKichHoatBaoHanh = ngayKichHoat
                    },
                    MoTaLoi = moTaLoi,
                    TinhTrangXuLy = tinhTrang,
                    NgayCapNhat = DateTime.Now.ToString("dd-MM-yyyy")

                });
                LoadData();
                MessageBox.Show("Cập nhật thành công");
            }    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                if (id == "")
                {
                    return;
                }
                LoadPhieuBaoHanh(id);
            }
        }
        private void LoadPhieuBaoHanh(string id)
        {
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            var document = mongoDBHelper.GetDocumentById<PhieuBaoHanh>("bh", id);
            txtMaBH.Text = document.Id.ToString();
            txtNgayYC.Text = document.NgayYCBaoHanh.ToString();
            txtTenKH.Text = document.KhachHang.TenKH.ToString();

            txtSDT.Text = document.KhachHang.DienThoai.ToString();
            txtSanPham.Text = document.SanPham.TenSP.ToString();
            txtIMEI.Text = document.SanPham.ImeiSP.ToString();
            txtNgayKichHoat.Text = document.SanPham.NgayKichHoatBaoHanh.ToString();
            txtMoTaLoi.Text = document.MoTaLoi.ToString();

            string tinh = document.KhachHang.DiaChi.ToString();
            if (tinh == "")
            {
                return;
            }
            cbbTinh.Text = tinh;
            string tinhTrang = document.TinhTrangXuLy.ToString();
            if (tinhTrang == "")
            {
                return;
            }
            cbbTinhTrang.Text = tinhTrang;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text;
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            dataGridView1.DataSource = mongoDBHelper.TimPhieuBaoHanh(search);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
