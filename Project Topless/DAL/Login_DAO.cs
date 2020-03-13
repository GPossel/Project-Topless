using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Project_Topless.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topless.DAL
{
    class Login_DAO : Base
    {

        public IMongoCollection<BsonDocument> userCollection;

        public Login_DAO()
        {
            userCollection = database.GetCollection<BsonDocument>("UserData");
        }

        public List<User> Get_All_Users_Db()
        {
            List<User> users = new List<User>();

            var filter = Builders<BsonDocument>.Filter.Empty;
            var result = userCollection.Find(filter).ToList();

            foreach (BsonDocument doc in result)
            {
                users.Add(BsonSerializer.Deserialize<User>(doc));
            }

            return users;
        }

        public User Get_User_Db(string userName)
        {
            User user;

            var filter = Builders<BsonDocument>.Filter.Eq("userName", userName);
            var result = userCollection.Find(filter).ToList();

            user = BsonSerializer.Deserialize<User>(result[0]);

            return user;
        }
    }
}
