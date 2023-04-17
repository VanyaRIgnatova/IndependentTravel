using NUnit.Framework;
using IndependentTravel.DataModels;
using Microsoft.AspNetCore.Mvc;
using IndependentTravel.Controllers;
using IndependentTravel.Services;
using System.Collections.Generic;
using Moq;

namespace IndependentTravel.Tests
{
    public class IndependentTravelTests
    {

        private HomeController homeController;
        private IDestinationService destinationService;

        [SetUp]
        public void Setup()
        {
            var destination = new Destination { Id = 1, Country = "USA", Town = "New York" };

            var DestinationServiceMock = new Mock<IDestinationService>();
            DestinationServiceMock.Setup(x => x.GetById(1)).Returns(destination);
            DestinationServiceMock.Setup(x => x.GetAllDestinations()).Returns(new List<Destination>{destination});
            DestinationServiceMock.Setup(x => x.Delete(1));
            destinationService = DestinationServiceMock.Object;

            homeController = new HomeController(destinationService);
        }

        [Test]
        public void GetRandomDestination_ReturnsOkResult()
        {
            var result = homeController.GetRandomDestination();

            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public void DestinationDetails_ReturnsViewResult()
        {
            var result = homeController.DestinationDetails(1);

            Assert.IsInstanceOf<ViewResult>(result);
        }


        [Test]
        public void Delete_RemovesDestinationFromRepository()
        {
            var result = homeController.Delete(1);

            Assert.IsInstanceOf<OkResult>(result);
        }

        [Test]
        public void Test_DestinationWithInvalidTownLenght_Property()
        {
            var destination = new Destination();

            Assert.That(() => destination.Town = "a", Throws.Exception);

        }

        [Test]
        public void Test_DestinationWithInvalidCountryLenght_Property()
        {
            var destination = new Destination();

            Assert.That(() => destination.Country = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", Throws.Exception);

        }

        [Test]
        public void Test_IsDeletedProperty()
        {
            var destination = new Destination();

            Assert.That(() => destination.IsDeleted = true);
        }
    }
}