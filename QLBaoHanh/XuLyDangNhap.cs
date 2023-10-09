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
        MongoDBHelper mongoDBHelper = new MongoDBHelper();
        public bool KiemTraDangNhap(string username, string password)
        {
         
            var result = MongoDBHelper.GetInstance().GetAllDocuments<TaiKhoan>(CollectionName);
            foreach (var item in result)
            {
                if (item.Username == username && item.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
