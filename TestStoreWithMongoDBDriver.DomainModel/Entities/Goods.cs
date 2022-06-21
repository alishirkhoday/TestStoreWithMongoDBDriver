using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TestStoreWithMongoDBDriver.DomainModel.Entities
{
    public class Goods
    {
        [BsonId]
        [BsonRepresentation((BsonType.ObjectId))]
        public string Id { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
    }
}
