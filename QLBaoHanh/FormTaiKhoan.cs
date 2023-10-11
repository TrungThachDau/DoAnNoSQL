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
        }
        public void LoadTaiKhoan()
        {
            XuLy.MongoDBHelper mongoDBHelper = new XuLy.MongoDBHelper();
            dgvTaiKhoan.DataSource = mongoDBHelper.DocTaiKhoan();
        }
    }
}
