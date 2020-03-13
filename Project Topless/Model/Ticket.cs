using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topless.Model
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string ticketSubject { get; set; }
        public User user { get; set; }
        public DateTime date { get; set; }

        public int status { get; set; }
        public int priority { get; set; }

        public enum Status { voltooid, onvoltooid }
        public enum Priority { high, mid, low }


    }
}
