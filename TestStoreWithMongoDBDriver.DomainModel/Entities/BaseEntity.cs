using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace TestStoreWithMongoDBDriver.DomainModel.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreationDateTime = DateTime.Now;
        }
        public ObjectId Id { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime ModificationDateTime { get; set; }
    }
}
