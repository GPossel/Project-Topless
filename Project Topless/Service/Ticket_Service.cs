using MongoDB.Bson;
using MongoDB.Driver;
using Project_Topless.DAL;
using Project_Topless.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topless.Service
{
    public class Ticket_Service
    {
        Ticket_DAO ticket_DAO = new Ticket_DAO();


        public List<Ticket> Get_All_Tickets_service()
        {
           List<Ticket> tickets = ticket_DAO.Get_All_Tickets_Db();

            return tickets;
        }

        public Ticket Get_Ticket(string ticketSubject)
        {
            Ticket ticket = ticket_DAO.Get_Ticket_Db(ticketSubject);

            return ticket;
        }

        public void Insert_One_Ticket(string subject)
        {
            ticket_DAO.Insert_One_Ticket_Db(subject);
        }

        public void Delete_One_Ticket(string ID)
        {
            ticket_DAO.Delete_One_Ticket_Db(ID);
        }

        public void UpdateOneTicket(Ticket ticket, string field, string newValue)
        {
            ticket_DAO.Update_One_Ticket_Db(ticket, field, newValue);
        }

    }
}
