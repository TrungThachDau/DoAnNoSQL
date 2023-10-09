using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using QLBaoHanh.Model;

namespace QLBaoHanh.XuLy
{
    public class MongoDBHelper
    {
        private static MongoDBHelper mongoHelper;
        private static IMongoDatabase db;
        private static string url = "mongodb://localhost:27017";
        private static string dbName = "BaoHanh";
        public MongoDBHelper()
        {
            var client = new MongoClient(url);
            db = client.GetDatabase(dbName);
        }
        public static MongoDBHelper GetInstance()
        {
            if (mongoHelper == null)
            {
                mongoHelper = new MongoDBHelper();
            }
            return mongoHelper;
        }
        public void InsertDocument<T>(string collectionName, T document)
        {
            var collection = db.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }
        public void UpdateDocument<T>(string collectionName, string field, string value, T document)
        {
            var collection = db.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq(field, value);
            collection.ReplaceOne(filter, document);
        }

        public DataTable DocPhieuBaoHanh()
        {
            DataTable dt = new DataTable();
            // Tạo các cột cho DataTable
             // Đặt kiểu dữ liệu cho cột
            dt.Columns.Add("NgayYeuCauBH");
            dt.Columns.Add("TenKhachHang");
            dt.Columns.Add("SanPham");
            var list = GetAllDocuments<PhieuBaoHanh>("bh");           
            foreach (var item in list)
            {
                // Thêm dòng dữ liệu vào DataTable
                dt.Rows.Add(item.NgayYCBaoHanh, item.KhachHang.TenKH, item.SanPham.TenSP);               
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
            var list =  GetAllDocuments<SanPham>("sanpham");
            foreach (var item in list)
            {
                dt.Rows.Add(item.MaSP, item.TenSP, item.Gia, item.ImeiSP, item.ThongSoKyThuat, item.NhaSanXuat, item.NgayKichHoatBaoHanh);
            }
            return dt;
        }
        public List<BsonDocument> GetAllDocuments<BsonDocument>(string collectionName)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            return collection.Find(_ => true).ToList();
        }
        public List<BsonDocument> GetDocument<BsonDocument>(string collectionName, string field, string value)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(field, value);
            return collection.Find(filter).ToList();
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
    
}
