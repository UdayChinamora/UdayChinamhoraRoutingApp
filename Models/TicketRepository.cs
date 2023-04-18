using System.Collections.Generic;

namespace UdayChinhamoraWebsite.Models
{
    public class TicketRepository : ITicketRepository
    {
        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = new List<Ticket>();

            Ticket ticket = new Ticket() { Id =12, Name = "Uday", SprintNum = "12" , PointVal ="34", Description ="ndgterwrwerwewrewrwewreeqreew", StatusId ="2345", Status ="ghdg"};
            tickets.Add(ticket);

            ticket = new Ticket() { Id = 13, Name = "James", SprintNum = "12", PointVal = "35", Description = "ndgterwrwerwewrewrwewreeqreew", StatusId = "2346", Status = "ghdg" }; ;
            tickets.Add(ticket);

            return tickets;
        }
    }
}

