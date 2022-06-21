using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TestStoreWithMongoDBDriver.DomainModel.Entities
{
    public class Invoice
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Customer Customer { get; set; }
        public List<Goods> Goods { get; set; }
        public int TotalPrice { get; set; }
    }
}
