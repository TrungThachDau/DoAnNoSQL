using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBaoHanh.Model
{
    [BsonIgnoreExtraElements]
    public class TaiKhoan
    {
        [BsonElement("Taikhoan")]
        public string Username { get; set; }
        [BsonElement("Matkhau")]
        public string Password { get; set; }
        [BsonElement("Hoten")]
        public string TenNV { get; set; }
        [BsonElement("Quyen")]
        public double Quyen { get; set; }
    }
}
