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
        }
        public void LoadData()
        {

            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            dataGridView1.DataSource = mongoDBHelper.DocPhieuBaoHanh();


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FormThemPhieu f= new FormThemPhieu();
            f.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
