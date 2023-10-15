using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using QLBaoHanh.Model;
using QLBaoHanh.XuLy;

namespace QLBaoHanh
{
    public class XuLyDangNhap
    {
        private static string CollectionName = "tk";
        XuLyTruyVan mongoDBHelper = new XuLyTruyVan();
        public int KiemTraDangNhap(string username, string password)
        {
         
            var result = mongoDBHelper.GetAllDocuments<TaiKhoan>(CollectionName);
            foreach (var item in result)
            {
                if (item.Username == username && item.Password == password)
                {
                    if (item.Quyen == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }
    }
}
