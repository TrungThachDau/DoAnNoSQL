using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBaoHanh.Model
{
    [BsonIgnoreExtraElements]
    public class SanPham
    {
        [BsonElement("Masp")]
        public string MaSP { get; set; }
        [BsonElement("TenSanPham")]
        public string TenSP { get; set; }
        [BsonElement("EmeiSanPham")]
        public string ImeiSP { get; set; }
        [BsonElement("Thongsokythuat")]
        public string ThongSoKyThuat { get; set; }
        [BsonElement("Gia")]
        public double Gia { get; set; }
        [BsonElement("NgayKichHoatBH")]
        public string NgayKichHoatBaoHanh { get; set; }
        [BsonElement("NhaSanXuat")]
        public string NhaSanXuat { get; set; }

    }
}
