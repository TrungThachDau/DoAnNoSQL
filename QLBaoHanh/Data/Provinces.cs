using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBaoHanh.Data
{
    public class Provinces
    {
        public static List<string> DanhSachTinhThanh()
        {
            List<string> danhSachTinhThanh = new List<string>
        {
            "Sài Gòn","Tây Ninh","Bình Dương","Đồng Nai","Bà Rịa - Vũng Tàu","Long An",
            "Bình Phước","Bình Thuận","Tiền Giang","Bến Tre","Trà Vinh","Vĩnh Long",
            "Đồng Tháp","An Giang","Kiên Giang","Cần Thơ","Hậu Giang","Sóc Trăng",
            "Bạc Liêu","Cà Mau","Đà Nẵng","Quảng Nam","Quảng Ngãi","Bình Định",
            "Phú Yên","Khánh Hòa","Ninh Thuận","Bình Thuận","Kon Tum","Gia Lai",
            "Đắk Lắk","Đắk Nông","Lâm Đồng","Quảng Trị","Thừa Thiên Huế","Khác"
            // Thêm các tỉnh khác vào danh sách
        };
            return danhSachTinhThanh;
        }
    }
    
}
