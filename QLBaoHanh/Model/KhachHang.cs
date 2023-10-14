using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBaoHanh.Model
{
    [BsonIgnoreExtraElements]
    public class KhachHang
    {
        [BsonElement("TenKhachHang")]
        public string TenKH { get; set; }
        [BsonElement("DiaChi")]
        public string DiaChi { get; set; }
        [BsonElement("SDT")]
        public string DienThoai { get; set; }
        [BsonElement("NgaySinh")]
        public string NgaySinh { get; set; }
        [BsonElement("GioiTinh")]
        public string Phai { get; set; }
    }
}
