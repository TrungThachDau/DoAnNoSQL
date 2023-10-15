using QLBaoHanh.XuLy;
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
    public partial class FormThongKe : Form
    {
        private XuLyTruyVan mongoDBHelper;


        public FormThongKe()
        {
            InitializeComponent();
            mongoDBHelper = new XuLyTruyVan();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //txt_nhap.Enabled = false;
                // muốn vô hiệu hóa và làm sạch nội dung của txt_nhap
                txt_nhap.Enabled = false;
                txt_nhap.Text = "";
            }
            else
            {
                txt_nhap.Enabled = true;
            }
        }
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            // Gọi hàm từ đối tượng MongoDBHelper để lấy dữ liệu thống kê
            DataTable statisticsData = mongoDBHelper.GetWarrantyStatistics();

            // Bind dữ liệu vào DataGridView
            dataGridView1.DataSource = statisticsData;
            // Mặc định chọn nút radio "Tất cả"
            radioButton1.Checked = true;
            txt_nhap.Enabled = false; // Vô hiệu hóa textbox khi chọn "Tất cả"
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            DataTable statisticsData = null;
            if (radioButton1.Checked)
            {

                statisticsData = mongoDBHelper.GetWarrantyStatistics();
            }
            else if (radioButton2.Checked)
            {
                txt_nhap.Enabled = true;
                // Lọc theo năm
                if (int.TryParse(txt_nhap.Text, out int selectedYear))
                {
                    statisticsData = mongoDBHelper.GetWarrantyStatisticsByYear(selectedYear);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một năm hợp lệ.");
                }
            }
            else if (radioButton3.Checked)
            {
                txt_nhap.Enabled = true;
                // Lọc theo tháng
                if (int.TryParse(txt_nhap.Text, out int selectedMonth))
                {
                    statisticsData = mongoDBHelper.GetWarrantyStatisticsByMonth(selectedMonth);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một tháng hợp lệ.");
                }
            }

            if (statisticsData != null)
            {
                dataGridView1.DataSource = statisticsData;

                // Tính toán doanh thu từ dữ liệu thống kê
                double totalRevenue = 0;
                foreach (DataRow row in statisticsData.Rows)
                {
                    if (double.TryParse(row["Gia"].ToString(), out double productPrice))
                    {
                        totalRevenue += productPrice;
                    }
                }

                // Hiển thị doanh thu trong TextBox
                txt_doanhthu.Text = totalRevenue.ToString("C"); // Định dạng số tiền
            }
        }
    }
}
