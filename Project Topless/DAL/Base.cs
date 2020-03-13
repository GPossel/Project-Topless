using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Project_Topless.Model;

namespace Project_Topless.DAL
{
    public class Base
    {
        public MongoClient dbClient;

        public IMongoDatabase database;


        public Base()
        {
            dbClient = new MongoClient("mongodb+srv://ProjectGroep3:NoSQL@cluster0-wlzd9.azure.mongodb.net/test?retryWrites=true&w=majority");
            database = dbClient.GetDatabase("TheGardenGroupDb");
        }

    }
}
