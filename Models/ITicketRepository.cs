
using System.Collections.Generic;
namespace UdayChinhamoraWebsite.Models
{
    public interface ITicketRepository
    {
        List<Ticket> GetTickets();
    }
}
