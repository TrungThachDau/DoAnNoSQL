using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
namespace QLBaoHanh.Data
{
    public class MongoDBQuery
    {
        private static readonly string url = Properties.Settings.Default.url;
        private static readonly string database = Properties.Settings.Default.dbname;
        private static IMongoDatabase db;
        public MongoDBQuery()
        {
            var client = new MongoClient(url);
            db = client.GetDatabase(database);
        }
        public List<BsonDocument> GetAllDocument<BsonDocument>(string collectionName)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            var result = collection.Find(d=>true).ToList();
            return result;
        }
        public List<BsonDocument> GetDocumentByFilter<BsonDocument>(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            var result = collection.Find(filter).ToList();
            return result;
        }
        public void InsertDocument<BsonDocument>(string collectionName, BsonDocument document)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }
        public void UpdateDocument<BsonDocument>(string collectionName, FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            var collection = db.GetCollection<BsonDocument>(collectionName);
            collection.UpdateOne(filter, update);
        }
    }
}
