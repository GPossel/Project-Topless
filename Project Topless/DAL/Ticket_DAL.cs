using MongoDB.Bson;
using MongoDB.Driver;
using Project_Topless.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topless.DAL
{
    public class Ticket_DAL : Base
    {
        public IMongoCollection<Ticket> GetAllTickets()
        {
            IMongoCollection<Ticket> TicketList = MongoDB_GetAllTickets();
            return TicketList;
        }

        public void ChangeStatus(Ticket ticket)
        { }

        public void GetTicketByUser(User user)
        { }

        public void GetTicketsByEmail(string email)
        { }

        public void AddTicket(Ticket ticket)
        { }
    }
}
