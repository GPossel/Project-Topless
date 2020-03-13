using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topless.Model
{
    public class User
    {
        public ObjectId _id { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    }
}
