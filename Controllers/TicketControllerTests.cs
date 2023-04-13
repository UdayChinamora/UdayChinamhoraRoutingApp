using Moq;

using UdayChinhamoraWebsite.Models;

namespace UdayChinhamoraWebsite.Controllers
{
    public class TicketControllerTests
    {
        private readonly Mock<ITicketRepository> _mockRepo;
        private readonly TicketController _controller;
        public TicketControllerTests()
        {
            _mockRepo = new Mock<ITicketRepository>();
            _controller = new TicketController(_mockRepo.Object);
        }
    }
}
