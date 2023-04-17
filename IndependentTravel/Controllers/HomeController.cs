using IndependentTravel.DataModels;
using IndependentTravel.Models;
using IndependentTravel.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IndependentTravel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDestinationService destinationService;
  
        private static Random rnd = new Random();
        public HomeController(IDestinationService destinationService)
        {
            this.destinationService = destinationService;
        }

        public IActionResult Index(int currentPage = 1)
        {
            var skip = (currentPage - 1) * 3;
            var take = 3;
            var destinations = this.destinationService.GetAll(skip, take);
            var totalDestinationsCount = this.destinationService.GetCount();
            var totalPages = totalDestinationsCount / 3;
            if (totalDestinationsCount % 3 > 0)
            {
                totalPages++;
            }
            var model = new DestinationViewModelList
            {
                List = GetDestinationsViewModel(destinations),
                CurrentPage = currentPage,
                TotalPages = totalPages
            };
            return View(model);

        }

        public IActionResult GetRandomDestination()
        {
            var destinations = this.destinationService.GetAllDestinations();
            var nextDestination = rnd.Next(0, destinations.Count);

            return Ok(new
            {
               picture = destinations[nextDestination].PictureURL,
               town = destinations[nextDestination].Town,
               country = destinations[nextDestination].Country
            });
        }

        public IActionResult ForMe()
        {
            return View();
        }
        public IActionResult TipsAndTricks()
        {
            return View();
        }

        public IActionResult Delete(int destinationId)
        {
            this.destinationService.Delete(destinationId);
            return Ok();
        }


        public IActionResult EditDestination(DestinationViewModel destination)
        {
            this.destinationService.Update(GetDestinationDataModel(destination));
            return RedirectToAction("Index");
        }

        public IActionResult DestinationDetails(int destinationId)
        {
            var destinationDataModel = this.destinationService.GetById(destinationId); ;
            return View(GetDestinationViewModel(destinationDataModel));
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddDestination(DestinationViewModel destination)
        {
            this.destinationService.Add(GetDestinationDataModel(destination));
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private Destination GetDestinationDataModel(DestinationViewModel destination)
        {
            return new Destination
            {
                Id = destination.Id,
                Country = destination.Country,
                Town = destination.Town,
                Description = destination.Description,
                PlaceToEat = destination.PlaceToEat,
                PlaceToSleep = destination.PlaceToSleep,
                PictureURL = destination.PictureURL
            };
        }

        private DestinationViewModel GetDestinationViewModel(Destination d)
        {
            return new DestinationViewModel
            {
                Id = d.Id,
                Country = d.Country,
                Town = d.Town,
                Description = d.Description,
                PlaceToSleep = d.PlaceToSleep,
                PlaceToEat = d.PlaceToEat,
                PictureURL = d.PictureURL,
            };
        }
        private List<DestinationViewModel> GetDestinationsViewModel(List<Destination> source)
        {
            var destinations = new List<DestinationViewModel>();

            foreach (var d in source)
            {
                destinations.Add(GetDestinationViewModel(d));
            }
            return destinations;
        }

    }
}
