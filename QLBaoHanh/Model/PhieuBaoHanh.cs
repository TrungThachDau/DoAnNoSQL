using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace QLBaoHanh.Model
{
    [BsonIgnoreExtraElements]
    public class PhieuBaoHanh
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("NgayYeuCauBH")]
        public string NgayYCBaoHanh { get; set; }
        [BsonElement("KhachHang")]
        public KhachHang KhachHang { get; set; }
        [BsonElement("SamPham")]
        public SanPham SanPham { get; set; }
        [BsonElement("MoTaLoi")]
        public string MoTaLoi { get; set; }
        [BsonElement("TinhTrangXuLy")]
        public string TinhTrangXuLy { get; set; }
        [BsonElement("NgayCapNhat")]
        public string NgayCapNhat { get; set; }

    }
}
