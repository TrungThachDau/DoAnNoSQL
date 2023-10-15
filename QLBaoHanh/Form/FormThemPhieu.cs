using MongoDB.Bson;
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
    public partial class FormThemPhieu : Form
    {
        public FormThemPhieu()
        {
            InitializeComponent();
            
        }

        private void FormThemPhieu_Load(object sender, EventArgs e)
        {
            LoadCbbSanPham();
            LoadCbbKhachHang();
        }
        public void LoadCbbSanPham()
        {
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            mongoDBHelper.LoadDSSanPham(cbbSanPham);

        }
        public void LoadCbbKhachHang()
        {
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            mongoDBHelper.LoadDSKhachHang(cbbKhachHang);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maPhieu = int.Parse(DateTime.Now.ToString("ddmmyy"));
            string moTaLoi = txtMoTaLoi.Text;
            string NgayYeuCau = DateTime.Now.ToString(format: "dd-MM-yyyy");
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            SanPham sanPham = cbbSanPham.SelectedItem as SanPham;
            string maSP = sanPham.MaSP;
            string tenSP = sanPham.TenSP;
            double gia = sanPham.Gia;
            string imei = sanPham.ImeiSP;
            string tskt = sanPham.ThongSoKyThuat;
            string nsx = sanPham.NhaSanXuat;
            string ngayKichHoat = sanPham.NgayKichHoatBaoHanh;
            KhachHang kh = cbbKhachHang.SelectedItem as KhachHang;
            string tenKH = kh.TenKH;
            string diaChi = kh.DiaChi;
            string sdt = kh.DienThoai;
            string ngaySinh = kh.NgaySinh;
            string phai = kh.Phai;

            mongoDBHelper.InsertOneDocument<PhieuBaoHanh>("bh", new PhieuBaoHanh
            {
                NgayYCBaoHanh = NgayYeuCau,
                KhachHang = new KhachHang
                {
                    TenKH = tenKH,
                    DiaChi = diaChi,
                    DienThoai = sdt,
                    NgaySinh = ngaySinh,
                    Phai = phai
                },
                SanPham = new SanPham
                {

                    MaSP = maSP,
                    TenSP = tenSP,
                    Gia = gia,
                    ImeiSP = imei,
                    ThongSoKyThuat = tskt,
                    NhaSanXuat = nsx,
                    NgayKichHoatBaoHanh = ngayKichHoat

                },
                MoTaLoi = moTaLoi,
                TinhTrangXuLy = "Chưa xử lý",
                NgayCapNhat = DateTime.Now.ToString(format: "dd-MM-yyyy")
            });
            MessageBox.Show("Thêm thành công");

        }
    }
}
