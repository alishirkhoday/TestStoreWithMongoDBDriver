using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace TestStoreWithMongoDBDriver.DomainModel.ListForDropDown
{
    public class CustomersListItemForDropDown
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
    }
}
