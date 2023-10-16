using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using QLBaoHanh.Model;

namespace QLBaoHanh.XuLy;

public class XuLyTruyVan
{
    
    private static IMongoDatabase db;
    private static readonly string url = Properties.Settings.Default.url;
    private static readonly string dbName = Properties.Settings.Default.dbname;
    public XuLyTruyVan()
    {
        var client = new MongoClient(url);
        db = client.GetDatabase(dbName);
    }

    public DataTable DocPhieuBaoHanh()
    {
        DataTable dt = new DataTable();
        // Tạo các cột cho DataTable
        // Đặt kiểu dữ liệu cho cột
        dt.Columns.Add("Ma");
        dt.Columns.Add("NgayYeuCauBH");
        dt.Columns.Add("TenKhachHang");            
        dt.Columns.Add("TinhTrangXuLy");
        dt.Columns.Add("NgayCapNhat");
        var list = GetAllDocuments<PhieuBaoHanh>("bh");
        
        foreach (var item in list)
        {
            // Thêm dòng dữ liệu vào DataTable
            dt.Rows.Add(item.Id,item.NgayYCBaoHanh, item.KhachHang.TenKH, item.TinhTrangXuLy, item.NgayCapNhat);               
        }
        return dt;
    }
    public DataTable DocSanPham()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Masp");
        dt.Columns.Add("Tensp");
        dt.Columns.Add("Gia");
        dt.Columns.Add("ImeiSanPham");
        dt.Columns.Add("Thongsokythuat");
        dt.Columns.Add("Nhasanxuat");
        dt.Columns.Add("Ngaykichhoatbaohanh");
        var list =  GetAllDocuments<SanPham>("sp");
        foreach (var item in list)
        {
            dt.Rows.Add(item.MaSP, item.TenSP, item.Gia, item.ImeiSP, item.ThongSoKyThuat, item.NhaSanXuat, item.NgayKichHoatBaoHanh);
        }
        return dt;
    }
    public DataTable DocTaiKhoan()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("TaiKhoan");
        dt.Columns.Add("HoTen");
        dt.Columns.Add("Quyen");
        var list = GetAllDocuments<TaiKhoan>("tk");
        foreach (var item in list)
        {
            dt.Rows.Add(item.Username, item.TenNV, item.Quyen);
        }
        return dt;
    }
    public ComboBox LoadComboBoxQuyenTK(ComboBox cbb)
    {
        var list = GetAllDocuments<TaiKhoan>("tk");
        foreach (var item in list)
        {
            cbb.Items.Add(new TaiKhoan
            {
                
                Quyen = item.Quyen
            });
        }
        cbb.ValueMember= "Quyen";
        cbb.DisplayMember = "Quyen"; // Hiển thị giá trị "Quyen"
         // Chọn "Quyen" làm giá trị cho mỗi mục

        // Đặt giá trị mặc định cho ComboBox dựa trên giá trị "Quyen" của mục đầu tiên
      
        return cbb;
    }
    public DataTable DocKhachHang()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Tenkhachhang");
        dt.Columns.Add("Diachi");
        dt.Columns.Add("Ngaysinh");
        dt.Columns.Add("Phai");
        dt.Columns.Add("SDT");
        var list = GetAllDocuments<KhachHang>("kh");
        foreach (var item in list)
        {
            dt.Rows.Add(item.TenKH, item.DiaChi, item.NgaySinh, item.Phai, item.DienThoai);
        }
        return dt;
    }
    public ComboBox LoadDSSanPham(ComboBox cbb)
    {
        var list = GetAllDocuments<SanPham>("sp");
        foreach (var item in list)
        {
            cbb.Items.Add(new SanPham
            {
                MaSP = item.MaSP,
                TenSP = item.TenSP,
                Gia = item.Gia,
                ImeiSP = item.ImeiSP,
                ThongSoKyThuat = item.ThongSoKyThuat,
                NhaSanXuat = item.NhaSanXuat,
                NgayKichHoatBaoHanh = item.NgayKichHoatBaoHanh
            });
        }
        cbb.DisplayMember = "TenSP";
        cbb.ValueMember = "MaSP";
        return cbb;
    }
    public ComboBox LoadDSKhachHang(ComboBox cbb)
    {
        var list = GetAllDocuments<KhachHang>("kh");
        foreach (var item in list)
        {
            cbb.Items.Add(new KhachHang
            {
                TenKH = item.TenKH,
                DiaChi = item.DiaChi,
                DienThoai = item.DienThoai,
                NgaySinh = item.NgaySinh,
                Phai  = item.Phai
            });

        }
        cbb.DisplayMember = "TenKH";
        cbb.ValueMember = "TenKH";
        return cbb;
    }
        //public DataTable DocPhieuBaoHanh()
        //{
        //    DataTable dt = new DataTable();
        //    // Tạo các cột cho DataTable
        //    // Đặt kiểu dữ liệu cho cột
        //    dt.Columns.Add("Ma");
        //    dt.Columns.Add("NgayYeuCauBH");
        //    dt.Columns.Add("TenKhachHang");
        //    dt.Columns.Add("TinhTrangXuLy");
        //    dt.Columns.Add("NgayCapNhat");
        //    var list = GetAllDocuments<PhieuBaoHanh>("bh");

        //    foreach (var item in list)
        //    {
        //        // Thêm dòng dữ liệu vào DataTable
        //        dt.Rows.Add(item.Id, item.NgayYCBaoHanh, item.KhachHang.TenKH, item.TinhTrangXuLy, item.NgayCapNhat);
        //    }
        //    return dt;
        //}
  //  public DataTable GetWarrantyStatistics()  //
		//{


		//	// Lấy danh sách phiếu bảo hành
		//	var warrantyCollection = db.GetCollection<PhieuBaoHanh>("bh");
		//	var warrantyFilter = Builders<PhieuBaoHanh>.Filter.Empty;
		//	var warrantyDocuments = warrantyCollection.Find(warrantyFilter).ToList();
            
		//	// Lấy danh sách sản phẩm
		//	var productCollection = db.GetCollection<SanPham>("sp");
		//	var productFilter = Builders<SanPham>.Filter.Empty;
		//	var productDocuments = productCollection.Find(productFilter).ToList();

		//	// Tạo DataTable để lưu kết quả thống kê
		//	DataTable resultDataTable = new DataTable();
		//	resultDataTable.Columns.Add("MaSp");
		//	resultDataTable.Columns.Add("TenSanPham");
		//	resultDataTable.Columns.Add("Gia");
		//	resultDataTable.Columns.Add("NgayKichHoatBH");
		//	resultDataTable.Columns.Add("TenKhachHang");
		//	resultDataTable.Columns.Add("DiachiKhachHang");
		//	resultDataTable.Columns.Add("PhaiKhachHang");
		//	resultDataTable.Columns.Add("SDTKhachHang");
		//	resultDataTable.Columns.Add("NgayYeuCauBH");

		//	// Kết hợp thông tin từ các bảng
		//	foreach (var warrantyDoc in warrantyDocuments)
		//	{
		//		var masp = warrantyDoc.SanPham.MaSP;

		//		var productDoc = productDocuments.FirstOrDefault(p => p.MaSP == masp);

		//		if (productDoc != null)
		//		{
		//			var row = resultDataTable.NewRow();
		//			row["Masp"] = masp;
		//			row["TenSanPham"] = productDoc.TenSP;
		//			row["Gia"] = productDoc.Gia;
		//			row["NgayKichHoatBH"] = productDoc.NgayKichHoatBaoHanh;
		//			row["TenKhachHang"] = warrantyDoc.KhachHang.TenKH;
		//			row["DiachiKhachHang"] = warrantyDoc.KhachHang.DiaChi;
		//			row["PhaiKhachHang"] = warrantyDoc.KhachHang.Phai;
		//			row["SDTKhachHang"] = warrantyDoc.KhachHang.DienThoai;
		//			row["NgayYeuCauBH"] = warrantyDoc.NgayYCBaoHanh;

		//			resultDataTable.Rows.Add(row);
		//		}
		//	}

		//	return resultDataTable;
		//}
        public DataTable GetWarrantyStatistics()
       {
            DataTable resultDataTable = new DataTable();
            resultDataTable.Columns.Add("MaSp");
            resultDataTable.Columns.Add("TenSanPham");
            resultDataTable.Columns.Add("Gia");
            resultDataTable.Columns.Add("NgayKichHoatBH");
            resultDataTable.Columns.Add("TenKhachHang");
            resultDataTable.Columns.Add("DiachiKhachHang");
            resultDataTable.Columns.Add("PhaiKhachHang");
            resultDataTable.Columns.Add("SDTKhachHang");
            resultDataTable.Columns.Add("NgayYeuCauBH");
            var list = GetAllDocuments<PhieuBaoHanh>("bh");
            foreach(var item in list)
            {
                var masp = item.SanPham.MaSP;
                if(masp!=null)
                {
                    var row = resultDataTable.NewRow();
                    row["Masp"] = masp;
                    row["TenSanPham"] = item.SanPham.TenSP;
                    row["Gia"] = item.SanPham.Gia;
                    row["NgayKichHoatBH"] = item.SanPham.NgayKichHoatBaoHanh;
                    row["TenKhachHang"] = item.KhachHang.TenKH;
                    row["DiachiKhachHang"] = item.KhachHang.DiaChi;
                    row["PhaiKhachHang"] = item.KhachHang.Phai;
                    row["SDTKhachHang"] = item.KhachHang.DienThoai;
                    row["NgayYeuCauBH"] = item.NgayYCBaoHanh;

                    resultDataTable.Rows.Add(row);
                }
            }
            return resultDataTable;
        }
        public DataTable GetWarrantyStatisticsByYear(int year)  //
		{
			// Lấy danh sách phiếu bảo hành dựa trên năm
			var warrantyCollection = db.GetCollection<PhieuBaoHanh>("bh");
			var warrantyFilter = Builders<PhieuBaoHanh>.Filter.Empty; // Lọc tất cả phiếu bảo hành
			var warrantyDocuments = warrantyCollection.Find(warrantyFilter).ToList();

			// Tạo DataTable để lưu kết quả thống kê
			DataTable resultDataTable = new DataTable();
			resultDataTable.Columns.Add("Masp");
			resultDataTable.Columns.Add("TenSanPham");
			resultDataTable.Columns.Add("Gia");
			resultDataTable.Columns.Add("NgayKichHoatBH");
			resultDataTable.Columns.Add("TenKhachHang");
			resultDataTable.Columns.Add("DiachiKhachHang");
			resultDataTable.Columns.Add("PhaiKhachHang");
			resultDataTable.Columns.Add("SDTKhachHang");
			resultDataTable.Columns.Add("NgayYeuCauBH");

			// Kết hợp thông tin từ các bảng
			foreach (var warrantyDoc in warrantyDocuments)
			{
				var masp = warrantyDoc.SanPham.MaSP;

				// Lấy thông tin sản phẩm từ cơ sở dữ liệu sản phẩm
				var productCollection = db.GetCollection<SanPham>("sp");
				var productFilter = Builders<SanPham>.Filter.Eq("MaSp", masp);
				var productDoc = productCollection.Find(productFilter).FirstOrDefault();

				if (productDoc != null)
				{
					// Chuyển đổi chuỗi ngày thành kiểu DateTime
					DateTime ngayYeuCauBH = DateTime.Parse(warrantyDoc.NgayYCBaoHanh);

					// Lấy năm từ kiểu DateTime
					int yearFromNgayYeuCauBH = ngayYeuCauBH.Year;

					if (yearFromNgayYeuCauBH == year)
					{
						var row = resultDataTable.NewRow();
						row["Masp"] = masp;
						row["TenSanPham"] = productDoc.TenSP;
						row["Gia"] = productDoc.Gia;
						row["NgayKichHoatBH"] = productDoc.NgayKichHoatBaoHanh;
						row["TenKhachHang"] = warrantyDoc.KhachHang.TenKH;
						row["DiachiKhachHang"] = warrantyDoc.KhachHang.DiaChi;
						row["PhaiKhachHang"] = warrantyDoc.KhachHang.Phai;
						row["SDTKhachHang"] = warrantyDoc.KhachHang.DienThoai;
						row["NgayYeuCauBH"] = warrantyDoc.NgayYCBaoHanh;

						resultDataTable.Rows.Add(row);
					}
				}
			}

			return resultDataTable;
		}

		public DataTable GetWarrantyStatisticsByMonth(int month)  //
		{
			// Lấy danh sách phiếu bảo hành dựa trên tháng
			var warrantyCollection = db.GetCollection<PhieuBaoHanh>("bh");
			var warrantyFilter = Builders<PhieuBaoHanh>.Filter.Empty; // Lọc tất cả phiếu bảo hành
			var warrantyDocuments = warrantyCollection.Find(warrantyFilter).ToList();

			// Tạo DataTable để lưu kết quả thống kê
			DataTable resultDataTable = new DataTable();
			resultDataTable.Columns.Add("MaSp");
			resultDataTable.Columns.Add("TenSanPham");
			resultDataTable.Columns.Add("Gia");
			resultDataTable.Columns.Add("NgayKichHoatBH");
			resultDataTable.Columns.Add("TenKhachHang");
			resultDataTable.Columns.Add("DiachiKhachHang");
			resultDataTable.Columns.Add("PhaiKhachHang");
			resultDataTable.Columns.Add("SDTKhachHang");
			resultDataTable.Columns.Add("NgayYeuCauBH");

			// Kết hợp thông tin từ các bảng
			foreach (var warrantyDoc in warrantyDocuments)
			{
				var masp = warrantyDoc.SanPham.MaSP;

				// Lấy thông tin sản phẩm từ cơ sở dữ liệu sản phẩm
				var productCollection = db.GetCollection<SanPham>("sp");
				var productFilter = Builders<SanPham>.Filter.Eq("MaSp", masp);
				var productDoc = productCollection.Find(productFilter).FirstOrDefault();

				if (productDoc != null)
				{
					// Chuyển đổi chuỗi ngày thành kiểu DateTime
					DateTime ngayYeuCauBH = DateTime.Parse(warrantyDoc.NgayYCBaoHanh);

					// Lấy tháng từ kiểu DateTime
					int monthFromNgayYeuCauBH = ngayYeuCauBH.Month;

					if (monthFromNgayYeuCauBH == month)
					{
						var row = resultDataTable.NewRow();
						row["Masp"] = masp;
						row["TenSanPham"] = productDoc.TenSP;
						row["Gia"] = productDoc.Gia;
						row["NgayKichHoatBH"] = productDoc.NgayKichHoatBaoHanh;
						row["TenKhachHang"] = warrantyDoc.KhachHang.TenKH;
						row["DiachiKhachHang"] = warrantyDoc.KhachHang.DiaChi;
						row["PhaiKhachHang"] = warrantyDoc.KhachHang.Phai;
						row["SDTKhachHang"] = warrantyDoc.KhachHang.DienThoai;
						row["NgayYeuCauBH"] = warrantyDoc.NgayYCBaoHanh;

						resultDataTable.Rows.Add(row);
					}
				}
			}

			return resultDataTable;
		}

		public List<BsonDocument> GetAllDocuments<BsonDocument>(string collectionName)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        return collection.Find(_ => true).ToList();
    }
    public BsonDocument GetDocumentById<BsonDocument>(string collectionName, string objectId)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(objectId));
        return collection.Find(filter).FirstOrDefault();
    }
    public BsonDocument GetDocument<BsonDocument>(string collectionName, string field, string value)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        var filter = Builders<BsonDocument>.Filter.Eq(field, value);
        return collection.Find(filter).FirstOrDefault();
    }
    public void DeleteOneDocument<BsonDocument>(string collectionName, string field, string value)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        var filter = Builders<BsonDocument>.Filter.Eq(field, value);
        collection.DeleteOne(filter);

    }
    public void DeleteAllDocument<BsonDocument>(string collectionName)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        collection.DeleteMany(_ => true);
    }
    public void InsertOneDocument<BsonDocument>(string collectionName, BsonDocument document)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        collection.InsertOne(document);
    }
    public void InsertManyDocument<BsonDocument>(string collectionName, List<BsonDocument> documents)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        collection.InsertMany(documents);
    }
    public void UpdateOneDocument<BsonDocument>(string collectionName, string field, string value, BsonDocument document)
    {
        var collection = db.GetCollection<BsonDocument>(collectionName);
        var filter = Builders<BsonDocument>.Filter.Eq(field, value);
        collection.ReplaceOne(filter, document);
    }

    
}

