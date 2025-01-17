﻿using QLBaoHanh.Model;
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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
        public void LoadSanPham()
        {
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            dataGridView1.DataSource = mongoDBHelper.DocSanPham();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSp.Text == "" || txtTenSp.Text == "" || txtGia.Text == "" || txtImei.Text == "" || txtTSKT.Text == "" || txtNSX.Text == "" || dtpNgayKichHoat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string maSP = txtMaSp.Text;
            string tenSP = txtTenSp.Text;
            int gia = int.Parse(txtGia.Text);
            string imei = txtImei.Text;
            string tskt = txtTSKT.Text;
            string nsx = txtNSX.Text;
            string ngayKichHoat = dtpNgayKichHoat.Value.ToString("dd-MM-yyyy");
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm '" + txtTenSp.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {

                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.InsertOneDocument<SanPham>("sp", new SanPham
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    Gia = gia,
                    ImeiSP = imei,
                    ThongSoKyThuat = tskt,
                    NhaSanXuat = nsx,
                    NgayKichHoatBaoHanh = ngayKichHoat
                });

                LoadSanPham();
                MessageBox.Show("Thêm thành công");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm '" + txtTenSp.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string maSP = txtMaSp.Text;
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.DeleteOneDocument<SanPham>("sp", "MaSp", maSP);
                LoadSanPham();
                MessageBox.Show("Xóa thành công");
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSp.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa");
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa thông tin sản phẩm '" + txtTenSp.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string maSP = txtMaSp.Text;
                string tenSP = txtTenSp.Text;
                int gia = int.Parse(txtGia.Text);
                string imei = txtImei.Text;
                string tskt = txtTSKT.Text;
                string nsx = txtNSX.Text;
                string ngayKichHoat = dtpNgayKichHoat.Value.ToString("dd-MM-yyyy");

                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.UpdateOneDocument<SanPham>("sp", "MaSp", maSP, new SanPham
                {
                    MaSP = maSP,
                    TenSP = tenSP,
                    Gia = gia,
                    ImeiSP = imei,
                    ThongSoKyThuat = tskt,
                    NhaSanXuat = nsx,
                    NgayKichHoatBaoHanh = ngayKichHoat
                });
                LoadSanPham();
                MessageBox.Show("Sửa thành công");
            }   
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txtGia.Text = "";
            txtImei.Text = "";
            txtMaSp.Text = "";
            txtNSX.Text = "";
            txtTenSp.Text = "";
            txtTSKT.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSp.Text = row.Cells[0].Value.ToString();
                txtTenSp.Text = row.Cells[1].Value.ToString();
                txtGia.Text = row.Cells[2].Value.ToString();
                txtImei.Text = row.Cells[3].Value.ToString();
                txtTSKT.Text = row.Cells[4].Value.ToString();
                txtNSX.Text = row.Cells[5].Value.ToString();
                dtpNgayKichHoat.Text = row.Cells[6].Value.ToString();


            }
        }
    }
}
