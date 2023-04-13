using Microsoft.AspNetCore.Mvc.ModelBinding;





using UdayChinhamoraWebsite.Models;

using UdayChinhamoraWebsite.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TicketsUnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void CreateTicketRequiredLastName()
        {
            // Arrange
            var ticket = new Ticket() { Id = 13, Name = " ", SprintNum = "12", PointVal = "35", Description = "ndgterwrwerwewrewrwewreeqreew", StatusId = "2346" }; ;

            // Act
            var result = _service.CreateTicket(ticket);

            // Assert
            Assert.IsFalse(result);
            var error = _modelState["Name"].Errors[0];
            Assert.AreEqual("Name is required.", error.ErrorMessage);
        }
       
        [Fact]
        public void Index_ActionExecutes_ReturnsViewForIndex()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_ActionExecutes_ReturnsExactNumberOfTickets()
        {
            _mockRepo.Setup(repo => repo.GetAll())
                .Returns(new List<Ticket>() { new Ticket(), new Ticket() });
            var result = _controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);
            var Tickets = Assert.IsType<List<Ticket>>(viewResult.Model);
            Assert.Equal(2, Tickets.Count);
        }
        [Fact]
        public void Create_ActionExecutes_ReturnsViewForCreate()
        {
            var result = _controller.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_InvalidModelState_ReturnsView()
        {
            _controller.ModelState.AddModelError("Name", "Name is required");

            var ticket = new Ticket() { Id = 13, Name = "", SprintNum = "12", PointVal = "35", Description = "ndgterwrwerwewrewrwewreeqreew", StatusId = "2346" };

            var result = _controller.Create(ticket);

            var viewResult = Assert.IsType<ViewResult>(result);
            var testTicket = Assert.IsType<Ticket>(viewResult.Model);

            Assert.Equal(ticket.Id, testTicket.Id);

            Assert.Equal(ticket.SprintNum, testTicket.SprintNum);
        }
        [Fact]
        public void Create_InvalidModelState_CreateTicketNeverExecutes()
        {
            _controller.ModelState.AddModelError("Name", "Name is required");

            var ticket = new Ticket { Id = 34 };

            _controller.Create(ticket);

            _mockRepo.Verify(x => x.CreateTicket(It.IsAny<Ticket>()), Times.Never);
        }
        
        [Fact]
        public void Create_ModelStateValid_CreateTicketCalledOnce()
        {
            Ticket? tic = null;
            _mockRepo.Setup(r => r.CreateTicket(It.IsAny<Ticket>()))
                .Callback<Ticket>(x => tic = x);
            var ticket = new Ticket
            {
                Id = 67,
                Name = "Test Ticket",
                SprintNum = "13",
                PointVal = "32",
                Description = "nxbdhbfbfeoog8effe8vjhbkjfbvbfvbdbfv",
                Status = "hgt",
                StatusId ="787"
                

              
            };
            _controller.Create(ticket);
            _mockRepo.Verify(x => x.CreateTicket(It.IsAny<Ticket>()), Times.Once);
            Assert.Equal(tic.Name, ticket.Name);
            Assert.Equal(tic.Age, ticket.Age);
            Assert.Equal(tic.AccountNumber, ticket.AccountNumber);
        }
    }
}