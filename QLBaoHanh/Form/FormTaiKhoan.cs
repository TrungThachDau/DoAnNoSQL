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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            LoadComboBoxQuyen();
        }
        private void LoadTaiKhoan()
        {
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            dgvTaiKhoan.DataSource = mongoDBHelper.DocTaiKhoan();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dgvTaiKhoan.Rows[e.RowIndex];
            //    txtUsername.Text = row.Cells[0].Value.ToString();
            //    txtTen.Text = row.Cells[1].Value.ToString();
            //    comboBox1.Text = row.Cells[2].Value.ToString();
            //}
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTaiKhoan.Rows.Count)
            {
                DataGridViewRow row = this.dgvTaiKhoan.Rows[e.RowIndex];
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
            }
        }
        private void LoadComboBoxQuyen()
        {
            XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
            mongoDBHelper.LoadComboBoxQuyenTK(comboBox1);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "" || txtTen.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thêm thông tin tài khoản của '" + txtTen.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string ten = txtTen.Text;
                double quyen = double.Parse(comboBox1.Text);
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.InsertOneDocument<TaiKhoan>("tk", new TaiKhoan
                {
                    Username = username,
                    Password = password,
                    TenNV = ten,
                    Quyen = quyen
                });
                LoadTaiKhoan();
                MessageBox.Show("Thêm thành công");
            }
               
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa thông tin tài khoản của '" + txtTen.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string username = txtUsername.Text;
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.DeleteOneDocument<TaiKhoan>("tk", "TaiKhoan", username);
                LoadTaiKhoan();
                MessageBox.Show("Xóa thành công");
            }
               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtTen.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thêm thông tin tài khoản của '" + txtTen.Text + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {

                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string ten = txtTen.Text;
                double quyen = double.Parse(comboBox1.SelectedValue.ToString());
                XuLy.XuLyTruyVan mongoDBHelper = new XuLy.XuLyTruyVan();
                mongoDBHelper.UpdateOneDocument<TaiKhoan>("tk", "TaiKhoan", username, new TaiKhoan
                {
                    Username = username,
                    Password = password,
                    TenNV = ten,
                    Quyen = quyen
                });
                LoadTaiKhoan();
                MessageBox.Show("Sửa thành công");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtTen.Text = "";
            comboBox1.SelectedValue = 2;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
