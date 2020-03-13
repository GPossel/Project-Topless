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
    class Ticket_DAO : Base
    {
        public IMongoCollection<BsonDocument> ticketCollection;

        public Ticket_DAO()
        {
            ticketCollection = database.GetCollection<BsonDocument>("Tickets");
        }

        public List<Ticket> Get_All_Tickets_Db()
        {
            List<Ticket> tickets = new List<Ticket>();

            var filter = Builders<BsonDocument>.Filter.Empty;
            var result = ticketCollection.Find(filter).ToList();

            foreach (BsonDocument doc in result)
            {
                tickets.Add(BsonSerializer.Deserialize<Ticket>(doc));
            }

            return tickets;
        }

        public Ticket Get_Ticket_Db(string ticketSubject)
        {
            Ticket ticket;

                var filter = Builders<BsonDocument>.Filter.Eq("ticketSubject", ticketSubject);
                var result = ticketCollection.Find(filter).ToList();

                ticket = BsonSerializer.Deserialize<Ticket>(result[0]);


            return ticket;
        }

        public List<Ticket> Select_List_Of_Ticket_Db(string ticketSubject)
        {
            List<Ticket> tickets = new List<Ticket>();

            var filter = Builders<BsonDocument>.Filter.Empty;
            var result = ticketCollection.Find(filter).ToList();

            foreach (BsonDocument doc in result)
            {
                tickets.Add(BsonSerializer.Deserialize<Ticket>(doc));
            }

            return tickets;
        }

        public void Insert_One_Ticket_Db(string subject)
        {
            var document = new BsonDocument { { "ticketSubject", subject } };

            ticketCollection.InsertOne(document);
        }

        public void Delete_One_Ticket_Db(string ID)
        {
            // filter the uniek item you want to delete
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", ID);
            // deleting tis item from your collection
            ticketCollection.DeleteOne(deleteFilter);
        }

        public void Update_One_Ticket_Db(Ticket ticket, string field, string newValue)
        {
            // find the masterID and replace it
            var result = ticketCollection.FindOneAndUpdateAsync(
                    // Vind het ticket behorende bij het unieke object dmv id
                    Builders<BsonDocument>.Filter.Eq("_id", ticket.Id),
                    // update het onderwerp dat je wilt, in dit geval id
                    Builders<BsonDocument>.Update.Set(field.ToString(), newValue)
                    );

            //retrive the data from collection
            ticketCollection.Find(new BsonDocument());
        }

    }
}
