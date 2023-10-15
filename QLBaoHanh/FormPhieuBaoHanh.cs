﻿using MongoDB.Bson;
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
        private readonly List<PhieuBaoHanh> customerModels;
        public FormPhieuBaoHanh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            //LoadPhieuBaoHanh("6529fde10a78b52b333fb408");
        }
        public void LoadData()
        {

            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            dataGridView1.DataSource = mongoDBHelper.DocPhieuBaoHanh();


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //FormThemPhieu f = new FormThemPhieu();
            //f.Show();

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
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int index = dataGridView1.SelectedRows[0].Index;
                var data = customerModels[index];
                FormThemPhieu f = new FormThemPhieu(data, true, ObjectId.Empty);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                // string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                LoadPhieuBaoHanh(id);
            }
        }
        private void LoadPhieuBaoHanh(string id)
        {
            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            var document = mongoDBHelper.GetDocumentById<PhieuBaoHanh>("bh", id);
            txtMaBH.Text = document.Id.ToString();
            txtNgayYC.Text = document.NgayYCBaoHanh.ToString();
            txtTenKH.Text = document.KhachHang.TenKH.ToString();
            txtDiaChi.Text = document.KhachHang.DiaChi.ToString();
            txtSDT.Text = document.KhachHang.DienThoai.ToString();
            txtSanPham.Text = document.SanPham.TenSP.ToString();
            txtIMEI.Text = document.SanPham.ImeiSP.ToString();
            txtNgayKichHoat.Text = document.SanPham.NgayKichHoatBaoHanh.ToString();
            txtMoTaLoi.Text = document.MoTaLoi.ToString();
            cbbTinhTrang.DisplayMember = document.TinhTrangXuLy.ToString();
            if (document.TinhTrangXuLy == "Đang xử lý")
            {
                cbbTinhTrang.SelectedIndex = 0;
            }
            else
            {
                cbbTinhTrang.SelectedIndex = 1;
            }
        }
    }
}
